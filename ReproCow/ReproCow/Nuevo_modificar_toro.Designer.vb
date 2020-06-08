<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevo_modificar_toro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevo_modificar_toro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCrotal = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtApelido1 = New System.Windows.Forms.TextBox()
        Me.txtApelido2 = New System.Windows.Forms.TextBox()
        Me.nudDosis = New System.Windows.Forms.NumericUpDown()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.nudDosis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crotal* (14 díxitos):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2º Apelido*:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(468, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome*:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "1º Apelido*:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dosis Dispoñibles:"
        '
        'txtCrotal
        '
        Me.txtCrotal.Location = New System.Drawing.Point(182, 54)
        Me.txtCrotal.Name = "txtCrotal"
        Me.txtCrotal.Size = New System.Drawing.Size(230, 24)
        Me.txtCrotal.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(530, 54)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(283, 24)
        Me.txtNome.TabIndex = 6
        '
        'txtApelido1
        '
        Me.txtApelido1.Location = New System.Drawing.Point(134, 166)
        Me.txtApelido1.Name = "txtApelido1"
        Me.txtApelido1.Size = New System.Drawing.Size(283, 24)
        Me.txtApelido1.TabIndex = 7
        '
        'txtApelido2
        '
        Me.txtApelido2.Location = New System.Drawing.Point(556, 166)
        Me.txtApelido2.Name = "txtApelido2"
        Me.txtApelido2.Size = New System.Drawing.Size(283, 24)
        Me.txtApelido2.TabIndex = 8
        '
        'nudDosis
        '
        Me.nudDosis.Location = New System.Drawing.Point(188, 266)
        Me.nudDosis.Name = "nudDosis"
        Me.nudDosis.Size = New System.Drawing.Size(72, 24)
        Me.nudDosis.TabIndex = 9
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(798, 364)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 26)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(706, 364)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(84, 26)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Nuevo_modificar_toro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 404)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.nudDosis)
        Me.Controls.Add(Me.txtApelido2)
        Me.Controls.Add(Me.txtApelido1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCrotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nuevo_modificar_toro"
        Me.Text = "Nuevo_modificar_toro"
        CType(Me.nudDosis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCrotal As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtApelido1 As TextBox
    Friend WithEvents txtApelido2 As TextBox
    Friend WithEvents nudDosis As NumericUpDown
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
