<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        ListView1 = New ListView()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ListView2 = New ListView()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(207, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(277, 25)
        Label2.TabIndex = 8
        Label2.Text = "Logged in as ""Administrator"" "
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label1.Location = New Point(190, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 45)
        Label1.TabIndex = 7
        Label1.Text = "Welcome to FCMS!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 148)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label3.Location = New Point(12, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 21)
        Label3.TabIndex = 9
        Label3.Text = "Manage Users:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label4.Location = New Point(530, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 21)
        Label4.TabIndex = 10
        Label4.Text = "Manage Classes:"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader3, ColumnHeader1, ColumnHeader8})
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(12, 205)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(415, 166)
        ListView1.TabIndex = 13
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Card ID"
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Full Name"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Active Membership Until"
        ColumnHeader8.Width = 150
        ' 
        ' ListView2
        ' 
        ListView2.Columns.AddRange(New ColumnHeader() {ColumnHeader4, ColumnHeader5, ColumnHeader6})
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
        ListView2.Location = New Point(530, 205)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(404, 166)
        ListView2.TabIndex = 14
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Class"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Trainer"
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Date"
        ColumnHeader6.Width = 150
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 377)
        Button1.Name = "Button1"
        Button1.Size = New Size(197, 37)
        Button1.TabIndex = 15
        Button1.Text = "Edit / Delete User"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(215, 377)
        Button3.Name = "Button3"
        Button3.Size = New Size(212, 37)
        Button3.TabIndex = 17
        Button3.Text = "Add New User"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(530, 377)
        Button4.Name = "Button4"
        Button4.Size = New Size(193, 37)
        Button4.TabIndex = 18
        Button4.Text = "Edit / Delete Class"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(729, 377)
        Button6.Name = "Button6"
        Button6.Size = New Size(205, 37)
        Button6.TabIndex = 20
        Button6.Text = "Add New Class"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(859, 12)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 23)
        Button7.TabIndex = 21
        Button7.Text = "Logout"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(859, 41)
        Button8.Name = "Button8"
        Button8.Size = New Size(75, 23)
        Button8.TabIndex = 22
        Button8.Text = "Exit"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(944, 423)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(ListView2)
        Controls.Add(ListView1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FCMS - Administrator Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
