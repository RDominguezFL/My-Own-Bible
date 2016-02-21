<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnretuntomain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radbtnmale = New System.Windows.Forms.RadioButton()
        Me.radbtnfemale = New System.Windows.Forms.RadioButton()
        Me.txtboxrecordID = New System.Windows.Forms.TextBox()
        Me.btnnewrecord = New System.Windows.Forms.Button()
        Me.btnclearform = New System.Windows.Forms.Button()
        Me.txtboxfirstname = New System.Windows.Forms.TextBox()
        Me.txtboxmiddleinitial = New System.Windows.Forms.TextBox()
        Me.txtboxlastname = New System.Windows.Forms.TextBox()
        Me.txtboxadress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtboxphone = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnretuntomain
        '
        Me.btnretuntomain.BackColor = System.Drawing.Color.Transparent
        Me.btnretuntomain.BackgroundImage = Global.My_Own_Bible.My.Resources.Resources.back2
        Me.btnretuntomain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnretuntomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnretuntomain.Location = New System.Drawing.Point(404, 316)
        Me.btnretuntomain.Name = "btnretuntomain"
        Me.btnretuntomain.Size = New System.Drawing.Size(95, 66)
        Me.btnretuntomain.TabIndex = 0
        Me.btnretuntomain.Text = "Return to Main "
        Me.btnretuntomain.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 71)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Record ID " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Middle Initial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sex"
        '
        'radbtnmale
        '
        Me.radbtnmale.AutoSize = True
        Me.radbtnmale.BackColor = System.Drawing.Color.Transparent
        Me.radbtnmale.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnmale.Location = New System.Drawing.Point(129, 233)
        Me.radbtnmale.Name = "radbtnmale"
        Me.radbtnmale.Size = New System.Drawing.Size(68, 29)
        Me.radbtnmale.TabIndex = 6
        Me.radbtnmale.TabStop = True
        Me.radbtnmale.Text = "Male"
        Me.radbtnmale.UseVisualStyleBackColor = False
        '
        'radbtnfemale
        '
        Me.radbtnfemale.AutoSize = True
        Me.radbtnfemale.BackColor = System.Drawing.Color.Transparent
        Me.radbtnfemale.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnfemale.Location = New System.Drawing.Point(225, 233)
        Me.radbtnfemale.Name = "radbtnfemale"
        Me.radbtnfemale.Size = New System.Drawing.Size(85, 29)
        Me.radbtnfemale.TabIndex = 7
        Me.radbtnfemale.TabStop = True
        Me.radbtnfemale.Text = "Female"
        Me.radbtnfemale.UseVisualStyleBackColor = False
        '
        'txtboxrecordID
        '
        Me.txtboxrecordID.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxrecordID.Location = New System.Drawing.Point(148, 48)
        Me.txtboxrecordID.Name = "txtboxrecordID"
        Me.txtboxrecordID.Size = New System.Drawing.Size(100, 32)
        Me.txtboxrecordID.TabIndex = 12
        '
        'btnnewrecord
        '
        Me.btnnewrecord.BackgroundImage = Global.My_Own_Bible.My.Resources.Resources.back2
        Me.btnnewrecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnewrecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewrecord.Location = New System.Drawing.Point(360, 21)
        Me.btnnewrecord.Name = "btnnewrecord"
        Me.btnnewrecord.Size = New System.Drawing.Size(99, 51)
        Me.btnnewrecord.TabIndex = 13
        Me.btnnewrecord.Text = "Save Record"
        Me.btnnewrecord.UseVisualStyleBackColor = True
        '
        'btnclearform
        '
        Me.btnclearform.BackgroundImage = Global.My_Own_Bible.My.Resources.Resources.back2
        Me.btnclearform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclearform.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclearform.Location = New System.Drawing.Point(360, 94)
        Me.btnclearform.Name = "btnclearform"
        Me.btnclearform.Size = New System.Drawing.Size(99, 51)
        Me.btnclearform.TabIndex = 14
        Me.btnclearform.Text = "Clear Form"
        Me.btnclearform.UseVisualStyleBackColor = True
        '
        'txtboxfirstname
        '
        Me.txtboxfirstname.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxfirstname.Location = New System.Drawing.Point(186, 113)
        Me.txtboxfirstname.Name = "txtboxfirstname"
        Me.txtboxfirstname.Size = New System.Drawing.Size(124, 32)
        Me.txtboxfirstname.TabIndex = 15
        '
        'txtboxmiddleinitial
        '
        Me.txtboxmiddleinitial.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxmiddleinitial.Location = New System.Drawing.Point(186, 152)
        Me.txtboxmiddleinitial.Name = "txtboxmiddleinitial"
        Me.txtboxmiddleinitial.Size = New System.Drawing.Size(62, 32)
        Me.txtboxmiddleinitial.TabIndex = 16
        '
        'txtboxlastname
        '
        Me.txtboxlastname.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxlastname.Location = New System.Drawing.Point(186, 196)
        Me.txtboxlastname.Name = "txtboxlastname"
        Me.txtboxlastname.Size = New System.Drawing.Size(141, 32)
        Me.txtboxlastname.TabIndex = 17
        '
        'txtboxadress
        '
        Me.txtboxadress.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxadress.Location = New System.Drawing.Point(129, 282)
        Me.txtboxadress.Name = "txtboxadress"
        Me.txtboxadress.Size = New System.Drawing.Size(198, 32)
        Me.txtboxadress.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Adress"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 25)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Phone"
        '
        'txtboxphone
        '
        Me.txtboxphone.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxphone.Location = New System.Drawing.Point(129, 320)
        Me.txtboxphone.Name = "txtboxphone"
        Me.txtboxphone.Size = New System.Drawing.Size(152, 32)
        Me.txtboxphone.TabIndex = 20
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.My_Own_Bible.My.Resources.Resources.back2
        Me.ClientSize = New System.Drawing.Size(511, 394)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtboxphone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtboxadress)
        Me.Controls.Add(Me.txtboxlastname)
        Me.Controls.Add(Me.txtboxmiddleinitial)
        Me.Controls.Add(Me.txtboxfirstname)
        Me.Controls.Add(Me.btnclearform)
        Me.Controls.Add(Me.btnnewrecord)
        Me.Controls.Add(Me.txtboxrecordID)
        Me.Controls.Add(Me.radbtnfemale)
        Me.Controls.Add(Me.radbtnmale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnretuntomain)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter a New Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnretuntomain As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents radbtnmale As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnfemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtboxrecordID As System.Windows.Forms.TextBox
    Friend WithEvents btnnewrecord As System.Windows.Forms.Button
    Friend WithEvents btnclearform As System.Windows.Forms.Button
    Friend WithEvents txtboxfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtboxmiddleinitial As System.Windows.Forms.TextBox
    Friend WithEvents txtboxlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtboxadress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtboxphone As System.Windows.Forms.TextBox
End Class
