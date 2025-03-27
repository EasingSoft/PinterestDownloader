Public Class PinterestResponse
    Public Property data As PinterestData
End Class

Public Class PinterestData
    Public Property v3RelatedPinsForPinSeoQuery As V3RelatedPinsForPinSeoQuery
End Class

Public Class V3RelatedPinsForPinSeoQuery
    'Public Property __typename As String
    Public Property data As V3RelatedPinsForPinSeoDataConnectionContainer
End Class

Public Class V3RelatedPinsForPinSeoDataConnectionContainer
    'Public Property __typename As String
    Public Property connection As Connection
End Class

Public Class Connection
    Public Property edges As List(Of Edge)
End Class

Public Class Edge
    Public Property node As Pin
End Class

Public Class Pin
    Public Property __typename As String
    Public Property entityId As String
    'Public Property board As Board
    'Public Property pinner As Pinner
    Public Property image236x As ImageSpec
    Public Property image474x As ImageSpec
    Public Property image564x As ImageSpec
    Public Property image736x As ImageSpec

    'Public Property description As String
    Public Property dominantColor As String
    'Public Property isRepin As Boolean
    Public Property videos As videos
    Public Property id As String
End Class

'Public Class Board
'    Public Property layout As String
'    Public Property name As String
'    Public Property url As String
'    Public Property id As String
'    Public Property followedByMe As Boolean
'    Public Property owner As Owner
'    Public Property isCollaborative As Boolean
'    Public Property privacy As String
'    Public Property pinCount As Integer
'    Public Property sectionCount As Integer
'    Public Property boardOrderModifiedAt As String
'    Public Property coverImageSpec_222x As ImageSpec
'    Public Property coverImageSpec_400x300 As ImageSpec
'    Public Property coverImageSpec_216x146 As ImageSpec
'    Public Property image_170x As List(Of ImageSpec)
'    Public Property imageThumbnailUrl As String
'    Public Property collaboratorCount As Integer
'End Class

'Public Class Owner
'    Public Property entityId As String
'    Public Property id As String
'End Class

'Public Class Pinner
'    Public Property id As String
'    Public Property entityId As String
'    Public Property fullName As String
'    Public Property username As String
'    Public Property imageSmallUrl As String
'    Public Property imageMediumUrl As String
'    Public Property imageLargeUrl As String
'End Class

Public Class ImageSpec
    Public Property url As String
    Public Property height As Integer
    Public Property width As Integer
    Public Property dominantColor As String
End Class
