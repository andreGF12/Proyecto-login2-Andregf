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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Correo = New System.Windows.Forms.TextBox()
        Me.Contra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Registrarse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Correo
        '
        Me.Correo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Correo.Location = New System.Drawing.Point(129, 275)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(192, 22)
        Me.Correo.TabIndex = 0
        '
        'Contra
        '
        Me.Contra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Contra.Location = New System.Drawing.Point(129, 337)
        Me.Contra.Name = "Contra"
        Me.Contra.Size = New System.Drawing.Size(192, 22)
        Me.Contra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(61, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Correo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(30, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'Registrarse
        '
        Me.Registrarse.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Registrarse.ForeColor = System.Drawing.Color.White
        Me.Registrarse.Location = New System.Drawing.Point(90, 403)
        Me.Registrarse.Name = "Registrarse"
        Me.Registrarse.Size = New System.Drawing.Size(176, 57)
        Me.Registrarse.TabIndex = 4
        Me.Registrarse.Text = "Registrarse"
        Me.Registrarse.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(359, 556)
        Me.Controls.Add(Me.Registrarse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Contra)
        Me.Controls.Add(Me.Correo)
        Me.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Correo As TextBox
    Friend WithEvents Contra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Registrarse As Button
End Class
