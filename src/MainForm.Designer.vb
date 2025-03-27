<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Keyword = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DownlaodBtn = New System.Windows.Forms.Button()
        Me.ImgFilter = New System.Windows.Forms.RadioButton()
        Me.VidFilter = New System.Windows.Forms.RadioButton()
        Me.StopDownload = New System.Windows.Forms.Button()
        Me.infoLabel = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Keyword
        '
        Me.Keyword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Keyword.Location = New System.Drawing.Point(167, 11)
        Me.Keyword.Margin = New System.Windows.Forms.Padding(4)
        Me.Keyword.Name = "Keyword"
        Me.Keyword.Size = New System.Drawing.Size(532, 23)
        Me.Keyword.TabIndex = 0
        '
        'SearchBtn
        '
        Me.SearchBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBtn.BackColor = System.Drawing.Color.White
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Location = New System.Drawing.Point(707, 8)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(100, 28)
        Me.SearchBtn.TabIndex = 1
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToResizeColumns = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.ColumnHeadersVisible = False
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.Grid.Location = New System.Drawing.Point(13, 43)
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowTemplate.Height = 300
        Me.Grid.RowTemplate.ReadOnly = True
        Me.Grid.Size = New System.Drawing.Size(792, 422)
        Me.Grid.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Column1"
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Column2"
        Me.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Column3"
        Me.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Column4"
        Me.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DownlaodBtn
        '
        Me.DownlaodBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownlaodBtn.BackColor = System.Drawing.Color.White
        Me.DownlaodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DownlaodBtn.Location = New System.Drawing.Point(704, 472)
        Me.DownlaodBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DownlaodBtn.Name = "DownlaodBtn"
        Me.DownlaodBtn.Size = New System.Drawing.Size(100, 28)
        Me.DownlaodBtn.TabIndex = 3
        Me.DownlaodBtn.Text = "Download"
        Me.DownlaodBtn.UseVisualStyleBackColor = False
        '
        'ImgFilter
        '
        Me.ImgFilter.AutoSize = True
        Me.ImgFilter.Checked = True
        Me.ImgFilter.Location = New System.Drawing.Point(14, 12)
        Me.ImgFilter.Name = "ImgFilter"
        Me.ImgFilter.Size = New System.Drawing.Size(71, 21)
        Me.ImgFilter.TabIndex = 4
        Me.ImgFilter.TabStop = True
        Me.ImgFilter.Text = "Images"
        Me.ImgFilter.UseVisualStyleBackColor = True
        '
        'VidFilter
        '
        Me.VidFilter.AutoSize = True
        Me.VidFilter.Location = New System.Drawing.Point(91, 12)
        Me.VidFilter.Name = "VidFilter"
        Me.VidFilter.Size = New System.Drawing.Size(69, 21)
        Me.VidFilter.TabIndex = 5
        Me.VidFilter.Text = "Videos"
        Me.VidFilter.UseVisualStyleBackColor = True
        '
        'StopDownload
        '
        Me.StopDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StopDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopDownload.Location = New System.Drawing.Point(704, 472)
        Me.StopDownload.Margin = New System.Windows.Forms.Padding(4)
        Me.StopDownload.Name = "StopDownload"
        Me.StopDownload.Size = New System.Drawing.Size(100, 28)
        Me.StopDownload.TabIndex = 6
        Me.StopDownload.Text = "Stop"
        Me.StopDownload.UseVisualStyleBackColor = False
        '
        'infoLabel
        '
        Me.infoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.infoLabel.AutoSize = True
        Me.infoLabel.Location = New System.Drawing.Point(10, 478)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(36, 17)
        Me.infoLabel.TabIndex = 7
        Me.infoLabel.Text = "[0/0]"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 512)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.VidFilter)
        Me.Controls.Add(Me.ImgFilter)
        Me.Controls.Add(Me.DownlaodBtn)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.Keyword)
        Me.Controls.Add(Me.StopDownload)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pinterest Downloader"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Keyword As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents Grid As DataGridView
    Friend WithEvents DownlaodBtn As Button
    Friend WithEvents ImgFilter As RadioButton
    Friend WithEvents VidFilter As RadioButton
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents StopDownload As Button
    Friend WithEvents infoLabel As Label
End Class
