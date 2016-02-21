Public Structure datafile2

    Public recordID As Integer
    <VBFixedString(15)> Public firstname As String
    <VBFixedString(10)> Public middlename As String
    <VBFixedString(21)> Public lastname As String
    Public male As Boolean
    Public female As Boolean
    <VBFixedString(34)> Public adress As String
    <VBFixedString(12)> Public phone As String

End Structure

Public Class Main_Menu
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnnewrecord_Click(sender As System.Object, e As System.EventArgs) Handles btnnewrecord.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnviewrecord_Click(sender As System.Object, e As System.EventArgs) Handles btnviewrecord.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End
    End Sub
End Class
