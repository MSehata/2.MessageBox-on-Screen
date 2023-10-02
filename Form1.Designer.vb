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
        btnSayHi = New Button()
        lblResponsiveButton = New Label()
        SuspendLayout()
        ' 
        ' btnSayHi
        ' 
        btnSayHi.Location = New Point(240, 129)
        btnSayHi.Name = "btnSayHi"
        btnSayHi.Size = New Size(322, 135)
        btnSayHi.TabIndex = 0
        btnSayHi.Text = "Click to Say Hi!"
        btnSayHi.UseVisualStyleBackColor = True
        ' 
        ' lblResponsiveButton
        ' 
        lblResponsiveButton.AutoSize = True
        lblResponsiveButton.Font = New Font("Viner Hand ITC", 18F, FontStyle.Italic, GraphicsUnit.Point)
        lblResponsiveButton.Location = New Point(240, 39)
        lblResponsiveButton.Name = "lblResponsiveButton"
        lblResponsiveButton.Size = New Size(278, 48)
        lblResponsiveButton.TabIndex = 1
        lblResponsiveButton.Text = "Responsive Button"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(lblResponsiveButton)
        Controls.Add(btnSayHi)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSayHi As Button
    Friend WithEvents lblResponsiveButton As Label
End Class
