<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgressForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 17)
        Label1.TabIndex = 0
        Label1.Text = "Progress report for..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F)
        Label2.Location = New Point(12, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 17)
        Label2.TabIndex = 1
        Label2.Text = "Attendance: 1/2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(12, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 17)
        Label3.TabIndex = 2
        Label3.Text = "Weight: 99kg"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F)
        Label4.Location = New Point(12, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 17)
        Label4.TabIndex = 3
        Label4.Text = "Member Since: 18/06/2025"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F)
        Label5.Location = New Point(12, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 17)
        Label5.TabIndex = 4
        Label5.Text = "Trainer Notes:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 124)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(293, 96)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Button1.Location = New Point(12, 223)
        Button1.Name = "Button1"
        Button1.Size = New Size(293, 38)
        Button1.TabIndex = 6
        Button1.Text = "Save and Exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ProgressForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(317, 278)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ProgressForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Monitor Member Progress"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
