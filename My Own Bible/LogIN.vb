Public Class LogIN

    Private Sub LogIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txbxUserName.Focus()

    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        If txbxUserName.Text = "user" And txbxPassword.Text = "password" Then
            Me.Hide()
            Main_Menu.Show()

        Else
            MsgBox("Wrong password")
            txbxPassword.ResetText()
            txbxPassword.Focus()
        End If

    End Sub
End Class