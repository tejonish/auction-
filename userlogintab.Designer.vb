<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userlogintab
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
        Me.Butusrcancel = New System.Windows.Forms.Button()
        Me.Butusrlogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usrpasslogintxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usrlogintxt = New System.Windows.Forms.TextBox()
        Me.lblusrlogin = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Butusrcancel
        '
        Me.Butusrcancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Butusrcancel.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butusrcancel.Location = New System.Drawing.Point(251, 134)
        Me.Butusrcancel.Name = "Butusrcancel"
        Me.Butusrcancel.Size = New System.Drawing.Size(142, 46)
        Me.Butusrcancel.TabIndex = 5
        Me.Butusrcancel.Text = "&CANCEL"
        Me.Butusrcancel.UseVisualStyleBackColor = False
        '
        'Butusrlogin
        '
        Me.Butusrlogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Butusrlogin.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butusrlogin.Location = New System.Drawing.Point(66, 134)
        Me.Butusrlogin.Name = "Butusrlogin"
        Me.Butusrlogin.Size = New System.Drawing.Size(142, 46)
        Me.Butusrlogin.TabIndex = 4
        Me.Butusrlogin.Text = "&LOGIN"
        Me.Butusrlogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Butusrcancel)
        Me.Panel1.Controls.Add(Me.Butusrlogin)
        Me.Panel1.Controls.Add(Me.usrpasslogintxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.usrlogintxt)
        Me.Panel1.Controls.Add(Me.lblusrlogin)
        Me.Panel1.Location = New System.Drawing.Point(314, 356)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 242)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(248, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = " FORGOT USER PASSWORD?"
        '
        'usrpasslogintxt
        '
        Me.usrpasslogintxt.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrpasslogintxt.Location = New System.Drawing.Point(251, 83)
        Me.usrpasslogintxt.Name = "usrpasslogintxt"
        Me.usrpasslogintxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.usrpasslogintxt.Size = New System.Drawing.Size(165, 30)
        Me.usrpasslogintxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "USER PASSWORD"
        '
        'usrlogintxt
        '
        Me.usrlogintxt.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrlogintxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.usrlogintxt.Location = New System.Drawing.Point(251, 28)
        Me.usrlogintxt.Name = "usrlogintxt"
        Me.usrlogintxt.Size = New System.Drawing.Size(165, 30)
        Me.usrlogintxt.TabIndex = 1
        '
        'lblusrlogin
        '
        Me.lblusrlogin.AutoSize = True
        Me.lblusrlogin.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusrlogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblusrlogin.Location = New System.Drawing.Point(62, 29)
        Me.lblusrlogin.Name = "lblusrlogin"
        Me.lblusrlogin.Size = New System.Drawing.Size(160, 24)
        Me.lblusrlogin.TabIndex = 0
        Me.lblusrlogin.Text = "USER LOGIN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(334, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(453, 690)
        Me.Panel2.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(273, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 24)
        Me.Label5.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(62, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "WELCOME BACK!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(143, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'userlogintab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1125, 692)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "userlogintab"
        Me.Text = "userlogintab"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Butusrcancel As System.Windows.Forms.Button
    Friend WithEvents Butusrlogin As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents usrpasslogintxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usrlogintxt As System.Windows.Forms.TextBox
    Friend WithEvents lblusrlogin As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
