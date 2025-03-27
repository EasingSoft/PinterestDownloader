Imports System.IO
Imports System.Net

Public Class PinForm
    Dim LastSearch As String = String.Empty
    Dim StopDownloadFlag As Boolean = False

    Async Function LoadSearch(query As String) As Task
        Dim Results = Await FetchPinterestData(query, If(ImgFilter.Checked, "pins", "videos"))
        Directory.CreateDirectory("Preview")
        ClearGrid()

        Dim rowIndex As Integer = 0
        Dim colIndex As Integer = 0

        For Each Item In Results
            Dim PreviewImgLink As String = GetPreviewImageLink(Item.images)
            If String.IsNullOrEmpty(PreviewImgLink) OrElse Not PreviewImgLink.Contains("://") Then Continue For

            Dim VideoLink As String = GetVideoLink(Item.videos)
            PreviewImgLink = PreviewImgLink.Replace("/p", "/")
            Dim FileName As String = $"Preview\{Item.id}{Path.GetExtension(New Uri(PreviewImgLink).LocalPath)}"

            If Not File.Exists(FileName) OrElse New FileInfo(FileName).Length < 500 Then
                Using downloader As New WebClient
                    Await downloader.DownloadFileTaskAsync(New Uri(PreviewImgLink), FileName)
                End Using
            End If

            Dim img As Image = Image.FromFile(FileName)
            If colIndex = 0 Then
                Grid.Rows.Add()
                InitializeRowCells(Grid.Rows.Cast(Of DataGridViewRow).Last)
            End If

            Dim cell As DataGridViewImageCell = Grid.Rows(rowIndex).Cells(colIndex)
            cell.Value = img
            cell.ErrorText = If(ImgFilter.Checked, Item.images.orig.url.Replace("/p", "/"), VideoLink)
            cell.Tag = Item.id

            colIndex += 1
            If colIndex >= 4 Then
                colIndex = 0
                rowIndex += 1
            End If
        Next

        LastSearch = query
    End Function

    Async Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        SearchBtn.Enabled = False
        DownlaodBtn.Enabled = False
        Await LoadSearch(Keyword.Text)
        SearchBtn.Enabled = True
        DownlaodBtn.Enabled = True
    End Sub

    Async Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        Dim pinId As String = Grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Tag
        Await LoadSimilar(pinId)
    End Sub

    Async Function LoadSimilar(pinId As String) As Task
        If Not IsNumeric(pinId) Then Return

        Dim Results = Await FindSimilarFetch(pinId)
        Directory.CreateDirectory("Preview")
        ClearGrid()

        Dim rowIndex As Integer = 0
        Dim colIndex As Integer = 0

        For Each Item In Results
            If Item.__typename = "Story" Then Continue For

            Dim PreviewImgLink As String = GetPreviewImageLink(Item)
            Dim OrigImgLink As String = GetOriginalImageLink(Item)
            Dim VideoLink As String = GetVideoLink(Item.videos)

            Dim FileName As String = $"Preview\{Item.entityId}{Path.GetExtension(New Uri(PreviewImgLink).LocalPath)}"
            If Not File.Exists(FileName) OrElse New FileInfo(FileName).Length < 500 Then
                Using downloader As New WebClient
                    Await downloader.DownloadFileTaskAsync(New Uri(PreviewImgLink), FileName)
                End Using
            End If

            Dim img As Image = Image.FromFile(FileName)
            If colIndex = 0 Then
                Grid.Rows.Add()
                InitializeRowCells(Grid.Rows.Cast(Of DataGridViewRow).Last)
            End If

            Dim cell As DataGridViewImageCell = Grid.Rows(rowIndex).Cells(colIndex)
            cell.Value = img
            cell.ErrorText = If(String.IsNullOrEmpty(VideoLink), OrigImgLink, VideoLink)
            cell.Tag = Item.entityId

            colIndex += 1
            If colIndex >= 4 Then
                colIndex = 0
                rowIndex += 1
            End If
        Next

        LastSearch = pinId
    End Function

    Async Sub DownlaodBtn_Click(sender As Object, e As EventArgs) Handles DownlaodBtn.Click
        StopDownloadFlag = False
        DownlaodBtn.Visible = False

        Await RefreshGridIfNeeded()


        Dim Total As Integer = Grid.Rows.Cast(Of DataGridViewRow).Sum(Function(R) R.Cells.Cast(Of DataGridViewImageCell).Count(Function(c) Not String.IsNullOrEmpty(c.ErrorText)))
        Dim Current As Integer = 0

        For Each R As DataGridViewRow In Grid.Rows.Cast(Of DataGridViewRow).ToArray
            If StopDownloadFlag Then Exit For
            For Each C As DataGridViewImageCell In R.Cells.Cast(Of DataGridViewImageCell).ToArray
                If StopDownloadFlag Then Exit For

                Current += 1
                setInfo($"Downloading {Current}/{Total}")

                Dim pinId As String = C.Tag
                Dim url As String = C.ErrorText

                If Not String.IsNullOrEmpty(pinId) Then
                    Dim Ext As String = Path.GetExtension(url).ToLower
                    Dim isVideo As Boolean = Ext = ".m3u8" OrElse Ext = ".mp4"

                    If isVideo Then
                        Await DownloadVideo(pinId, url)
                    ElseIf Not String.IsNullOrEmpty(url) Then
                        Await DownloadImage(pinId, url)
                    End If
                End If
            Next
        Next

        setInfo("Finished")
        DownlaodBtn.Visible = True
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(Pinterest.ffmpeg) Then MsgBox("Need ffmpeg.exe to be installed")
    End Sub

    Private Sub StopDownload_Click(sender As Object, e As EventArgs) Handles StopDownload.Click
        StopDownloadFlag = True
    End Sub

    Sub setInfo(info As String)
        infoLabel.Invoke(Sub() infoLabel.Text = info)
    End Sub

    Private Sub ClearGrid()
        For Each R As DataGridViewRow In Grid.Rows
            For Each C As DataGridViewImageCell In R.Cells
                If C.Value IsNot Nothing Then
                    Try
                        CType(C.Value, Bitmap).Dispose()
                        C.Value = Nothing
                    Catch ex As Exception
                    End Try
                End If
            Next
        Next
        Grid.Rows.Clear()
    End Sub

    Private Sub InitializeRowCells(row As DataGridViewRow)
        For Each C In row.Cells
            C.Value = New Bitmap(1, 1)
        Next
    End Sub

    Private Function GetPreviewImageLink(images As Object) As String
        Dim PreviewImgLink = String.Empty
        If images.orig IsNot Nothing Then PreviewImgLink = images.orig.url
        If images.p736x IsNot Nothing Then PreviewImgLink = images.p736x.url
        If images.p474x IsNot Nothing Then PreviewImgLink = images.p474x.url
        If images.p236x IsNot Nothing Then PreviewImgLink = images.p236x.url
        If images.p170x IsNot Nothing Then PreviewImgLink = images.p170x.url
        PreviewImgLink = PreviewImgLink.Replace("/p", "/")
        Return PreviewImgLink
    End Function

    Private Function GetOriginalImageLink(Item As Object) As String
        Dim OrigImgLink = String.Empty
        If Item.image236x IsNot Nothing Then OrigImgLink = Item.image236x.url
        If Item.image474x IsNot Nothing Then OrigImgLink = Item.image474x.url
        If Item.image564x IsNot Nothing Then OrigImgLink = Item.image564x.url
        If Item.image736x IsNot Nothing Then OrigImgLink = Item.image736x.url
        Return OrigImgLink
    End Function

    Private Function GetVideoLink(videos As videos) As String
        If videos Is Nothing Then Return String.Empty
        Dim V = videos.video_list
        If V Is Nothing Then V = videos.videoList
        If V IsNot Nothing Then
            If V.v720P IsNot Nothing Then Return V.v720P.url
            If V.vHLSV4 IsNot Nothing Then Return V.vHLSV4.url
            If V.vHLSV3MOBILE IsNot Nothing Then Return V.vHLSV3MOBILE.url
            If V.V_HLSV3_MOBILE IsNot Nothing Then Return V.V_HLSV3_MOBILE.url
        End If
        Return String.Empty
    End Function

    Private Async Function RefreshGridIfNeeded() As Task(Of Boolean)
        For Each R As DataGridViewRow In Grid.Rows
            For Each C As DataGridViewImageCell In R.Cells
                Dim pinId As String = C.Tag
                Dim url As String = C.ErrorText
                If Not String.IsNullOrEmpty(pinId) Then
                    Dim Ext As String = Path.GetExtension(url).ToLower
                    Dim isVideo As Boolean = Ext = ".m3u8" OrElse Ext = ".mp4"
                    If isVideo Then
                        If IsNumeric(LastSearch) Then
                            Await LoadSimilar(LastSearch)
                        Else
                            Await LoadSearch(LastSearch)
                        End If
                        Return True
                    End If
                End If
            Next
        Next
        Return False
    End Function

    Private Async Function DownloadVideo(pinId As String, url As String) As Task
        Directory.CreateDirectory("Videos")
        Dim FileName As String = $"Videos\{pinId}.mp4"
        If Not File.Exists(FileName) OrElse New FileInfo(FileName).Length < 500 Then
            Await DownloadHLSVideo(url, FileName.Replace(".mp4", String.Empty))
        End If
    End Function

    Private Async Function DownloadImage(pinId As String, url As String) As Task
        Directory.CreateDirectory("Images")
        Dim FileName As String = $"Images\{pinId}{Path.GetExtension(New Uri(url).LocalPath)}"
        If Not File.Exists(FileName) OrElse New FileInfo(FileName).Length < 500 Then
            Using downloader As New WebClient
                Await downloader.DownloadFileTaskAsync(New Uri(url), FileName)
            End Using
        End If
    End Function
End Class
