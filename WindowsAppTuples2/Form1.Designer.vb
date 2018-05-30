<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdGetPersonGood = New System.Windows.Forms.Button()
        Me.cmdGetPersonBad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdGetPersonGood
        '
        Me.cmdGetPersonGood.Location = New System.Drawing.Point(23, 22)
        Me.cmdGetPersonGood.Name = "cmdGetPersonGood"
        Me.cmdGetPersonGood.Size = New System.Drawing.Size(149, 23)
        Me.cmdGetPersonGood.TabIndex = 0
        Me.cmdGetPersonGood.Text = "Get Person Good"
        Me.cmdGetPersonGood.UseVisualStyleBackColor = True
        '
        'cmdGetPersonBad
        '
        Me.cmdGetPersonBad.Location = New System.Drawing.Point(23, 51)
        Me.cmdGetPersonBad.Name = "cmdGetPersonBad"
        Me.cmdGetPersonBad.Size = New System.Drawing.Size(149, 23)
        Me.cmdGetPersonBad.TabIndex = 1
        Me.cmdGetPersonBad.Text = "Get Person Bad"
        Me.cmdGetPersonBad.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 125)
        Me.Controls.Add(Me.cmdGetPersonBad)
        Me.Controls.Add(Me.cmdGetPersonGood)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdGetPersonGood As Button
    Friend WithEvents cmdGetPersonBad As Button
End Class
