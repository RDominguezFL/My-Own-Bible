<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.btnnewrecord = New System.Windows.Forms.Button()
        Me.btnviewrecord = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnnewrecord
        '
        Me.btnnewrecord.Font = New System.Drawing.Font("Copperplate Gothic Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewrecord.Location = New System.Drawing.Point(642, 15)
        Me.btnnewrecord.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnnewrecord.Name = "btnnewrecord"
        Me.btnnewrecord.Size = New System.Drawing.Size(199, 68)
        Me.btnnewrecord.TabIndex = 0
        Me.btnnewrecord.Text = "Enter a New Record"
        Me.btnnewrecord.UseVisualStyleBackColor = True
        '
        'btnviewrecord
        '
        Me.btnviewrecord.Font = New System.Drawing.Font("Copperplate Gothic Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewrecord.Location = New System.Drawing.Point(642, 110)
        Me.btnviewrecord.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnviewrecord.Name = "btnviewrecord"
        Me.btnviewrecord.Size = New System.Drawing.Size(199, 69)
        Me.btnviewrecord.TabIndex = 1
        Me.btnviewrecord.Text = "View a Record"
        Me.btnviewrecord.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Font = New System.Drawing.Font("Engravers MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(678, 211)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(133, 59)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 100)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "        Welcome to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Student Registry"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.My_Own_Bible.My.Resources.Resources.uiprbanner
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(857, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnviewrecord)
        Me.Controls.Add(Me.btnnewrecord)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registry Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnnewrecord As System.Windows.Forms.Button
    Friend WithEvents btnviewrecord As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
