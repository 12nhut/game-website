'Project:       Final Project - Best Game
'Programmer:    Nhuan Thi
'Date:          December 13, 2011
'Description:   This home page contain the image button and hyperlinks that all direct to the System page.
Option Strict On
Partial Class _Default
    Inherits System.Web.UI.Page
    'Variable for the hit counter
    Private VisitCounterInteger As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Lock the application so this page can use it only
        Application.Lock()
        'If the VisitCounter application is not empty
        If Application("VisitCounter") IsNot Nothing Then
            'Retrieve the value from the application
            VisitCounterInteger = CInt(Application("VisitCounter"))
            'Increment the value by 1
            VisitCounterInteger += 1
            'Add the value back to the application
            Application("VisitCounter") = VisitCounterInteger.ToString
        End If
        'Unlock the application for other pages
        Application.UnLock()
        'Show the hit counter of the pages to the label
        VisitCounterLabel.Text = "Best Game has been visited " & VisitCounterInteger.ToString & " times."
    End Sub
End Class
