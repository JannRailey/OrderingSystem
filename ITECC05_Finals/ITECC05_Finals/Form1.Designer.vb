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
        Panel1 = New Panel()
        bttn_maincourse = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(bttn_maincourse)
        Panel1.Dock = DockStyle.Bottom
        Panel1.ForeColor = SystemColors.ControlLight
        Panel1.Location = New Point(0, 464)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(912, 45)
        Panel1.TabIndex = 0
        ' 
        ' bttn_maincourse
        ' 
        bttn_maincourse.Location = New Point(99, -16)
        bttn_maincourse.Name = "bttn_maincourse"
        bttn_maincourse.Size = New Size(105, 29)
        bttn_maincourse.TabIndex = 1
        bttn_maincourse.Text = "Main Course"
        bttn_maincourse.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 509)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttn_maincourse As Button

End Class
