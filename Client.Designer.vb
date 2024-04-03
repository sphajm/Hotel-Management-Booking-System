<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CLNameTb = New TextBox()
        CLAge = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        CLPhoneTb = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label7 = New Label()
        TextBox4 = New TextBox()
        GenderCb = New ComboBox()
        CountryCb = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Schoolbook", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(174, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(485, 77)
        Label1.TabIndex = 2
        Label1.Text = "JW MARIOTT"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images
        PictureBox1.Location = New Point(681, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(148, 106)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(55, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 23)
        Label2.TabIndex = 6
        Label2.Text = "CLIENT NAME"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' CLNameTb
        ' 
        CLNameTb.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CLNameTb.Location = New Point(55, 200)
        CLNameTb.Name = "CLNameTb"
        CLNameTb.Size = New Size(209, 30)
        CLNameTb.TabIndex = 7
        ' 
        ' CLAge
        ' 
        CLAge.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CLAge.Location = New Point(444, 200)
        CLAge.Name = "CLAge"
        CLAge.Size = New Size(74, 30)
        CLAge.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(298, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 23)
        Label3.TabIndex = 10
        Label3.Text = "GENDER"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(444, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 23)
        Label4.TabIndex = 11
        Label4.Text = "AGE"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' CLPhoneTb
        ' 
        CLPhoneTb.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CLPhoneTb.Location = New Point(549, 200)
        CLPhoneTb.Name = "CLPhoneTb"
        CLPhoneTb.Size = New Size(178, 30)
        CLPhoneTb.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(549, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(178, 23)
        Label5.TabIndex = 13
        Label5.Text = "PHONE NUMBER"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(752, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 23)
        Label6.TabIndex = 15
        Label6.Text = "COUNTRY"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.GradientActiveCaption
        Button1.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(123, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 50)
        Button1.TabIndex = 16
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientActiveCaption
        Button2.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(309, 245)
        Button2.Name = "Button2"
        Button2.Size = New Size(180, 50)
        Button2.TabIndex = 17
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.GradientActiveCaption
        Button3.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(495, 245)
        Button3.Name = "Button3"
        Button3.Size = New Size(180, 50)
        Button3.TabIndex = 18
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.GradientActiveCaption
        Button4.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(681, 245)
        Button4.Name = "Button4"
        Button4.Size = New Size(180, 50)
        Button4.TabIndex = 19
        Button4.Text = "RESET"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(309, 373)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 23)
        Label7.TabIndex = 20
        Label7.Text = "LIST"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(417, 373)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(209, 30)
        TextBox4.TabIndex = 21
        ' 
        ' GenderCb
        ' 
        GenderCb.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GenderCb.FormattingEnabled = True
        GenderCb.Location = New Point(298, 200)
        GenderCb.Name = "GenderCb"
        GenderCb.Size = New Size(121, 31)
        GenderCb.TabIndex = 23
        ' 
        ' CountryCb
        ' 
        CountryCb.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CountryCb.FormattingEnabled = True
        CountryCb.Location = New Point(752, 200)
        CountryCb.Name = "CountryCb"
        CountryCb.Size = New Size(121, 31)
        CountryCb.TabIndex = 24
        ' 
        ' Client
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1066, 653)
        Controls.Add(CountryCb)
        Controls.Add(GenderCb)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(CLPhoneTb)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(CLAge)
        Controls.Add(CLNameTb)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Client"
        Text = "Client"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CLNameTb As TextBox
    Friend WithEvents CLAge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CLPhoneTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GenderCb As ComboBox
    Friend WithEvents CountryCb As ComboBox
End Class
