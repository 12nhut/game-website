Imports Microsoft.VisualBasic

Public Class Product
    Public Property Name As String
    Public Property DateReleased As String
    Public Property Price As Decimal
    Public Property Summary As String
    Public Property ImageFile As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal NameString As String, ByVal DateReleasedDate As String, ByVal PriceDecimal As Decimal, _
                   ByVal SummaryString As String, ByVal ImageFileImage As String)
        With Me
            .Name = NameString
            .DateReleased = DateReleasedDate
            .Price = PriceDecimal
            .Summary = SummaryString
            .ImageFile = ImageFileImage
        End With
    End Sub
End Class
