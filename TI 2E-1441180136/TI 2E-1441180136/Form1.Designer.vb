<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.Ganti = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ganti
        '
        Me.Ganti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ganti.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Ganti.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ganti.ImageKey = "(none)"
        Me.Ganti.Location = New System.Drawing.Point(135, 287)
        Me.Ganti.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Ganti.Name = "Ganti"
        Me.Ganti.Size = New System.Drawing.Size(152, 41)
        Me.Ganti.TabIndex = 0
        Me.Ganti.Text = "Ganti"
        Me.Ganti.UseVisualStyleBackColor = True
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 342)
        Me.Controls.Add(Me.Ganti)
        Me.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form"
        Me.Text = "FormGantiWarna"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ganti As System.Windows.Forms.Button

End Class
