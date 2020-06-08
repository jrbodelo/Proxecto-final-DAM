<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Nuevo_Modificar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevo_Modificar))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCrotal = New System.Windows.Forms.TextBox()
        Me.txtApelido2 = New System.Windows.Forms.TextBox()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.dtpNacemento = New System.Windows.Forms.DateTimePicker()
        Me.txtApelido1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRexistro = New System.Windows.Forms.TextBox()
        Me.txtXenomica = New System.Windows.Forms.TextBox()
        Me.txtAcoplamento = New System.Windows.Forms.TextBox()
        Me.btnExaminarRex = New System.Windows.Forms.Button()
        Me.btnExaminarXen = New System.Windows.Forms.Button()
        Me.btnExaminarAcop = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCancelarRexistro = New System.Windows.Forms.Button()
        Me.btnCancelarXenomica = New System.Windows.Forms.Button()
        Me.btnCancelarAcoplamento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Data de nacemento*:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Raza:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(506, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tipo*:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(508, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nome*:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(506, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Apelido paterno*:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apelido materno*:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Crotal* (14 díxitos):"
        '
        'txtCrotal
        '
        Me.txtCrotal.Location = New System.Drawing.Point(188, 58)
        Me.txtCrotal.Name = "txtCrotal"
        Me.txtCrotal.Size = New System.Drawing.Size(260, 24)
        Me.txtCrotal.TabIndex = 16
        '
        'txtApelido2
        '
        Me.txtApelido2.Location = New System.Drawing.Point(179, 129)
        Me.txtApelido2.Name = "txtApelido2"
        Me.txtApelido2.Size = New System.Drawing.Size(260, 24)
        Me.txtApelido2.TabIndex = 18
        '
        'txtRaza
        '
        Me.txtRaza.Location = New System.Drawing.Point(100, 292)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(185, 24)
        Me.txtRaza.TabIndex = 19
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(570, 57)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(221, 24)
        Me.txtNome.TabIndex = 20
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Vaca", "Novilla"})
        Me.cmbTipo.Location = New System.Drawing.Point(558, 204)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(136, 26)
        Me.cmbTipo.TabIndex = 21
        '
        'dtpNacemento
        '
        Me.dtpNacemento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacemento.Location = New System.Drawing.Point(202, 204)
        Me.dtpNacemento.Name = "dtpNacemento"
        Me.dtpNacemento.Size = New System.Drawing.Size(124, 24)
        Me.dtpNacemento.TabIndex = 22
        '
        'txtApelido1
        '
        Me.txtApelido1.Location = New System.Drawing.Point(639, 129)
        Me.txtApelido1.Name = "txtApelido1"
        Me.txtApelido1.Size = New System.Drawing.Size(258, 24)
        Me.txtApelido1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Carta de Rexistro: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 18)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Ficheiro de xenómica:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 478)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 18)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Ficheiro de acoplamento: "
        '
        'txtRexistro
        '
        Me.txtRexistro.Location = New System.Drawing.Point(190, 360)
        Me.txtRexistro.Name = "txtRexistro"
        Me.txtRexistro.ReadOnly = True
        Me.txtRexistro.Size = New System.Drawing.Size(258, 24)
        Me.txtRexistro.TabIndex = 27
        '
        'txtXenomica
        '
        Me.txtXenomica.Location = New System.Drawing.Point(213, 416)
        Me.txtXenomica.Name = "txtXenomica"
        Me.txtXenomica.ReadOnly = True
        Me.txtXenomica.Size = New System.Drawing.Size(258, 24)
        Me.txtXenomica.TabIndex = 28
        '
        'txtAcoplamento
        '
        Me.txtAcoplamento.Location = New System.Drawing.Point(242, 475)
        Me.txtAcoplamento.Name = "txtAcoplamento"
        Me.txtAcoplamento.ReadOnly = True
        Me.txtAcoplamento.Size = New System.Drawing.Size(258, 24)
        Me.txtAcoplamento.TabIndex = 29
        '
        'btnExaminarRex
        '
        Me.btnExaminarRex.Location = New System.Drawing.Point(456, 360)
        Me.btnExaminarRex.Name = "btnExaminarRex"
        Me.btnExaminarRex.Size = New System.Drawing.Size(107, 26)
        Me.btnExaminarRex.TabIndex = 30
        Me.btnExaminarRex.Text = "Examinar..."
        Me.btnExaminarRex.UseVisualStyleBackColor = True
        '
        'btnExaminarXen
        '
        Me.btnExaminarXen.Location = New System.Drawing.Point(478, 416)
        Me.btnExaminarXen.Name = "btnExaminarXen"
        Me.btnExaminarXen.Size = New System.Drawing.Size(101, 26)
        Me.btnExaminarXen.TabIndex = 31
        Me.btnExaminarXen.Text = "Examinar..."
        Me.btnExaminarXen.UseVisualStyleBackColor = True
        '
        'btnExaminarAcop
        '
        Me.btnExaminarAcop.Location = New System.Drawing.Point(507, 475)
        Me.btnExaminarAcop.Name = "btnExaminarAcop"
        Me.btnExaminarAcop.Size = New System.Drawing.Size(102, 26)
        Me.btnExaminarAcop.TabIndex = 32
        Me.btnExaminarAcop.Text = "Examinar..."
        Me.btnExaminarAcop.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(860, 618)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 30)
        Me.btnAceptar.TabIndex = 33
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(756, 618)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(84, 30)
        Me.btnCancelar.TabIndex = 34
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCancelarRexistro
        '
        Me.btnCancelarRexistro.Location = New System.Drawing.Point(570, 360)
        Me.btnCancelarRexistro.Name = "btnCancelarRexistro"
        Me.btnCancelarRexistro.Size = New System.Drawing.Size(75, 26)
        Me.btnCancelarRexistro.TabIndex = 36
        Me.btnCancelarRexistro.Text = "Eliminar"
        Me.btnCancelarRexistro.UseVisualStyleBackColor = True
        '
        'btnCancelarXenomica
        '
        Me.btnCancelarXenomica.Location = New System.Drawing.Point(585, 416)
        Me.btnCancelarXenomica.Name = "btnCancelarXenomica"
        Me.btnCancelarXenomica.Size = New System.Drawing.Size(75, 25)
        Me.btnCancelarXenomica.TabIndex = 37
        Me.btnCancelarXenomica.Text = "Eliminar"
        Me.btnCancelarXenomica.UseVisualStyleBackColor = True
        '
        'btnCancelarAcoplamento
        '
        Me.btnCancelarAcoplamento.Location = New System.Drawing.Point(619, 475)
        Me.btnCancelarAcoplamento.Name = "btnCancelarAcoplamento"
        Me.btnCancelarAcoplamento.Size = New System.Drawing.Size(75, 26)
        Me.btnCancelarAcoplamento.TabIndex = 38
        Me.btnCancelarAcoplamento.Text = "Eliminar"
        Me.btnCancelarAcoplamento.UseVisualStyleBackColor = True
        '
        'Nuevo_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 657)
        Me.Controls.Add(Me.btnCancelarAcoplamento)
        Me.Controls.Add(Me.btnCancelarXenomica)
        Me.Controls.Add(Me.btnCancelarRexistro)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnExaminarAcop)
        Me.Controls.Add(Me.btnExaminarXen)
        Me.Controls.Add(Me.btnExaminarRex)
        Me.Controls.Add(Me.txtAcoplamento)
        Me.Controls.Add(Me.txtXenomica)
        Me.Controls.Add(Me.txtRexistro)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApelido1)
        Me.Controls.Add(Me.dtpNacemento)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtRaza)
        Me.Controls.Add(Me.txtApelido2)
        Me.Controls.Add(Me.txtCrotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nuevo_Modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCrotal As TextBox
    Friend WithEvents txtApelido2 As TextBox
    Friend WithEvents txtRaza As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents dtpNacemento As DateTimePicker
    Friend WithEvents txtApelido1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRexistro As TextBox
    Friend WithEvents txtXenomica As TextBox
    Friend WithEvents txtAcoplamento As TextBox
    Friend WithEvents btnExaminarRex As Button
    Friend WithEvents btnExaminarXen As Button
    Friend WithEvents btnExaminarAcop As Button
    Friend WithEvents ofdRexistro As OpenFileDialog
    Friend WithEvents ofdAcoplamento As OpenFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCancelarRexistro As Button
    Friend WithEvents btnCancelarXenomica As Button
    Friend WithEvents btnCancelarAcoplamento As Button
End Class
