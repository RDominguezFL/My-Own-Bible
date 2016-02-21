Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtboxrecordID.Focus()

    End Sub

    Private Sub btnreturntomain_Click(sender As System.Object, e As System.EventArgs) Handles btnretuntomain.Click
        Me.Hide()
        Main_Menu.Show()

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnnewrecord_Click(sender As System.Object, e As System.EventArgs) Handles btnnewrecord.Click
        Dim recordID As Integer, reclenght As Long, lastrecord As Integer, field As datafile2

        field.recordID = 0
        field.firstname = " "
        field.middlename = " "
        field.lastname = " "
        field.male = False
        field.female = False
        field.adress = " "
        field.phone = 0

        reclenght = Len(field)
        recordID = FreeFile()

        FileOpen(recordID, "datafile2.dat", OpenMode.Random, OpenAccess.ReadWrite, , reclenght)

        field.firstname = txtboxfirstname.Text
        field.middlename = txtboxmiddleinitial.Text
        field.lastname = txtboxlastname.Text
        field.male = radbtnmale.Checked
        field.female = radbtnfemale.Checked
        field.adress = txtboxadress.Text
        field.phone = txtboxphone.Text

        lastrecord = txtboxrecordID.Text
        FilePut(recordID, field, lastrecord)

        FileClose(1)

        txtboxrecordID.Text = " "
        txtboxfirstname.Text = " "
        txtboxmiddleinitial.Text = " "
        txtboxlastname.Text = " "
        radbtnmale.Checked = False
        radbtnfemale.Checked = False
        txtboxadress.Text = " "
        txtboxphone.Text = " "

        txtboxrecordID.Focus()

    End Sub

    Private Sub btnclearform_Click_1(sender As System.Object, e As System.EventArgs) Handles btnclearform.Click
        txtboxrecordID.Text = " "
        txtboxfirstname.Text = " "
        txtboxmiddleinitial.Text = " "
        txtboxlastname.Text = " "
        radbtnmale.Checked = False
        radbtnfemale.Checked = False
        txtboxadress.Text = " "
        txtboxphone.Text = " "

        txtboxrecordID.Focus()

    End Sub
End Class