<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TextBox2 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Schoolbook", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(45, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(485, 77)
        Label1.TabIndex = 0
        Label1.Text = "JW MARIOTT"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images
        PictureBox1.Location = New Point(536, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(116, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 23)
        Label2.TabIndex = 2
        Label2.Text = "CLIENT NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(439, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(225, 23)
        Label3.TabIndex = 3
        Label3.Text = "HOW MANY PEOPLE ?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(116, 265)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 23)
        Label4.TabIndex = 4
        Label4.Text = "DATE IN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(439, 265)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 23)
        Label5.TabIndex = 5
        Label5.Text = "DATE OUT"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(116, 216)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 30)
        TextBox1.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(116, 291)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 8
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.Location = New Point(439, 291)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(116, 345)
        Button1.Name = "Button1"
        Button1.Size = New Size(195, 67)
        Button1.TabIndex = 10
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(439, 345)
        Button2.Name = "Button2"
        Button2.Size = New Size(195, 67)
        Button2.TabIndex = 11
        Button2.Text = "DELETE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(439, 216)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 30)
        TextBox2.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 529)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox2 As TextBox

End Class
