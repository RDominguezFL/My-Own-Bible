Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnviewrecord_Click(sender As System.Object, e As System.EventArgs) Handles btnviewrecord.Click
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

        lastrecord = Val(txtboxrecordID.Text)
        FileGet(recordID, field, lastrecord)

        lblfistname.Text = field.firstname
        lblmiddleinitial.Text = field.middlename
        lbllastname.Text = field.lastname
        radbtnmale.Checked = field.male
        radbtnfemale.Checked = field.female
        lbladress.Text = field.adress
        lblphone.Text = field.phone

        FileClose(1)

        txtboxrecordID.Focus()

    End Sub

    Private Sub btnretuntomain_Click(sender As System.Object, e As System.EventArgs) Handles btnretuntomain.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub

End Class