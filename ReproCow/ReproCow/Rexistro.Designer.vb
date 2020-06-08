<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rexistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rexistro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmbResultadoRevision1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpRevision1 = New System.Windows.Forms.DateTimePicker()
        Me.gbParto = New System.Windows.Forms.GroupBox()
        Me.cmbSexoParto = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpParto = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbInseminacion = New System.Windows.Forms.GroupBox()
        Me.cmbSemental = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpInseminacion = New System.Windows.Forms.DateTimePicker()
        Me.gbRevision2 = New System.Windows.Forms.GroupBox()
        Me.cmbSexoRevision = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbResultadoRevision2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpRevision2 = New System.Windows.Forms.DateTimePicker()
        Me.gbRevision1 = New System.Windows.Forms.GroupBox()
        Me.gbSecado = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpSecado = New System.Windows.Forms.DateTimePicker()
        Me.lblProceso = New System.Windows.Forms.Label()
        Me.gbParto.SuspendLayout()
        Me.gbInseminacion.SuspendLayout()
        Me.gbRevision2.SuspendLayout()
        Me.gbRevision1.SuspendLayout()
        Me.gbSecado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de rexistro:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(594, 307)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(84, 26)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(684, 307)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 26)
        Me.btnAceptar.TabIndex = 18
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmbResultadoRevision1
        '
        Me.cmbResultadoRevision1.AutoCompleteCustomSource.AddRange(New String() {"Positivo", "Negativo"})
        Me.cmbResultadoRevision1.FormattingEnabled = True
        Me.cmbResultadoRevision1.Location = New System.Drawing.Point(440, 62)
        Me.cmbResultadoRevision1.Name = "cmbResultadoRevision1"
        Me.cmbResultadoRevision1.Size = New System.Drawing.Size(136, 26)
        Me.cmbResultadoRevision1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(348, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Resultado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Data:"
        '
        'dtpRevision1
        '
        Me.dtpRevision1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRevision1.Location = New System.Drawing.Point(115, 63)
        Me.dtpRevision1.Name = "dtpRevision1"
        Me.dtpRevision1.Size = New System.Drawing.Size(134, 24)
        Me.dtpRevision1.TabIndex = 12
        '
        'gbParto
        '
        Me.gbParto.Controls.Add(Me.cmbSexoParto)
        Me.gbParto.Controls.Add(Me.Label14)
        Me.gbParto.Controls.Add(Me.txtEstado)
        Me.gbParto.Controls.Add(Me.Label12)
        Me.gbParto.Controls.Add(Me.Label11)
        Me.gbParto.Controls.Add(Me.dtpParto)
        Me.gbParto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbParto.Location = New System.Drawing.Point(31, 77)
        Me.gbParto.Name = "gbParto"
        Me.gbParto.Size = New System.Drawing.Size(717, 174)
        Me.gbParto.TabIndex = 19
        Me.gbParto.TabStop = False
        Me.gbParto.Text = "Parto"
        '
        'cmbSexoParto
        '
        Me.cmbSexoParto.AutoCompleteCustomSource.AddRange(New String() {"Macho", "Femia"})
        Me.cmbSexoParto.FormattingEnabled = True
        Me.cmbSexoParto.Location = New System.Drawing.Point(107, 95)
        Me.cmbSexoParto.Name = "cmbSexoParto"
        Me.cmbSexoParto.Size = New System.Drawing.Size(133, 26)
        Me.cmbSexoParto.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(55, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 18)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Sexo:"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(394, 33)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(194, 24)
        Me.txtEstado.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(281, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Estado da cría:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Data:"
        '
        'dtpParto
        '
        Me.dtpParto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpParto.Location = New System.Drawing.Point(104, 31)
        Me.dtpParto.Name = "dtpParto"
        Me.dtpParto.Size = New System.Drawing.Size(134, 24)
        Me.dtpParto.TabIndex = 20
        '
        'gbInseminacion
        '
        Me.gbInseminacion.Controls.Add(Me.cmbSemental)
        Me.gbInseminacion.Controls.Add(Me.Label4)
        Me.gbInseminacion.Controls.Add(Me.Label2)
        Me.gbInseminacion.Controls.Add(Me.dtpInseminacion)
        Me.gbInseminacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbInseminacion.Location = New System.Drawing.Point(31, 78)
        Me.gbInseminacion.Name = "gbInseminacion"
        Me.gbInseminacion.Size = New System.Drawing.Size(717, 179)
        Me.gbInseminacion.TabIndex = 20
        Me.gbInseminacion.TabStop = False
        Me.gbInseminacion.Text = "Inseminación"
        '
        'cmbSemental
        '
        Me.cmbSemental.FormattingEnabled = True
        Me.cmbSemental.Location = New System.Drawing.Point(425, 56)
        Me.cmbSemental.Name = "cmbSemental"
        Me.cmbSemental.Size = New System.Drawing.Size(136, 26)
        Me.cmbSemental.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(338, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Semental:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Data:"
        '
        'dtpInseminacion
        '
        Me.dtpInseminacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInseminacion.Location = New System.Drawing.Point(95, 59)
        Me.dtpInseminacion.Name = "dtpInseminacion"
        Me.dtpInseminacion.Size = New System.Drawing.Size(134, 24)
        Me.dtpInseminacion.TabIndex = 13
        '
        'gbRevision2
        '
        Me.gbRevision2.Controls.Add(Me.cmbSexoRevision)
        Me.gbRevision2.Controls.Add(Me.Label10)
        Me.gbRevision2.Controls.Add(Me.cmbResultadoRevision2)
        Me.gbRevision2.Controls.Add(Me.Label9)
        Me.gbRevision2.Controls.Add(Me.Label7)
        Me.gbRevision2.Controls.Add(Me.dtpRevision2)
        Me.gbRevision2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbRevision2.Location = New System.Drawing.Point(31, 74)
        Me.gbRevision2.Name = "gbRevision2"
        Me.gbRevision2.Size = New System.Drawing.Size(717, 177)
        Me.gbRevision2.TabIndex = 20
        Me.gbRevision2.TabStop = False
        Me.gbRevision2.Text = "2ª Revisión"
        '
        'cmbSexoRevision
        '
        Me.cmbSexoRevision.FormattingEnabled = True
        Me.cmbSexoRevision.Items.AddRange(New Object() {"Macho", "Femia"})
        Me.cmbSexoRevision.Location = New System.Drawing.Point(127, 111)
        Me.cmbSexoRevision.Name = "cmbSexoRevision"
        Me.cmbSexoRevision.Size = New System.Drawing.Size(123, 26)
        Me.cmbSexoRevision.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(72, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Sexo:"
        '
        'cmbResultadoRevision2
        '
        Me.cmbResultadoRevision2.AutoCompleteCustomSource.AddRange(New String() {"Positivo", "Negativo"})
        Me.cmbResultadoRevision2.FormattingEnabled = True
        Me.cmbResultadoRevision2.Location = New System.Drawing.Point(451, 49)
        Me.cmbResultadoRevision2.Name = "cmbResultadoRevision2"
        Me.cmbResultadoRevision2.Size = New System.Drawing.Size(136, 26)
        Me.cmbResultadoRevision2.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(359, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Resultado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Data:"
        '
        'dtpRevision2
        '
        Me.dtpRevision2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRevision2.Location = New System.Drawing.Point(126, 50)
        Me.dtpRevision2.Name = "dtpRevision2"
        Me.dtpRevision2.Size = New System.Drawing.Size(134, 24)
        Me.dtpRevision2.TabIndex = 22
        '
        'gbRevision1
        '
        Me.gbRevision1.Controls.Add(Me.cmbResultadoRevision1)
        Me.gbRevision1.Controls.Add(Me.dtpRevision1)
        Me.gbRevision1.Controls.Add(Me.Label8)
        Me.gbRevision1.Controls.Add(Me.Label6)
        Me.gbRevision1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbRevision1.Location = New System.Drawing.Point(31, 81)
        Me.gbRevision1.Name = "gbRevision1"
        Me.gbRevision1.Size = New System.Drawing.Size(717, 176)
        Me.gbRevision1.TabIndex = 20
        Me.gbRevision1.TabStop = False
        Me.gbRevision1.Text = "1ª Revisión"
        '
        'gbSecado
        '
        Me.gbSecado.Controls.Add(Me.Label13)
        Me.gbSecado.Controls.Add(Me.dtpSecado)
        Me.gbSecado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbSecado.Location = New System.Drawing.Point(31, 81)
        Me.gbSecado.Name = "gbSecado"
        Me.gbSecado.Size = New System.Drawing.Size(717, 87)
        Me.gbSecado.TabIndex = 20
        Me.gbSecado.TabStop = False
        Me.gbSecado.Text = "Secado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(53, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 18)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Data:"
        '
        'dtpSecado
        '
        Me.dtpSecado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSecado.Location = New System.Drawing.Point(107, 37)
        Me.dtpSecado.Name = "dtpSecado"
        Me.dtpSecado.Size = New System.Drawing.Size(134, 24)
        Me.dtpSecado.TabIndex = 12
        '
        'lblProceso
        '
        Me.lblProceso.AutoSize = True
        Me.lblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProceso.ForeColor = System.Drawing.Color.Red
        Me.lblProceso.Location = New System.Drawing.Point(220, 29)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(83, 24)
        Me.lblProceso.TabIndex = 16
        Me.lblProceso.Text = "<vacio>"
        '
        'Rexistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 344)
        Me.Controls.Add(Me.lblProceso)
        Me.Controls.Add(Me.gbInseminacion)
        Me.Controls.Add(Me.gbRevision2)
        Me.Controls.Add(Me.gbRevision1)
        Me.Controls.Add(Me.gbSecado)
        Me.Controls.Add(Me.gbParto)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rexistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rexistro"
        Me.gbParto.ResumeLayout(False)
        Me.gbParto.PerformLayout()
        Me.gbInseminacion.ResumeLayout(False)
        Me.gbInseminacion.PerformLayout()
        Me.gbRevision2.ResumeLayout(False)
        Me.gbRevision2.PerformLayout()
        Me.gbRevision1.ResumeLayout(False)
        Me.gbRevision1.PerformLayout()
        Me.gbSecado.ResumeLayout(False)
        Me.gbSecado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cmbResultadoRevision1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpRevision1 As DateTimePicker
    Friend WithEvents gbParto As GroupBox
    Friend WithEvents cmbSexoParto As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpParto As DateTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gbInseminacion As GroupBox
    Friend WithEvents gbRevision2 As GroupBox
    Friend WithEvents gbRevision1 As GroupBox
    Friend WithEvents gbSecado As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpSecado As DateTimePicker
    Friend WithEvents cmbSexoRevision As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbResultadoRevision2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpRevision2 As DateTimePicker
    Friend WithEvents cmbSemental As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpInseminacion As DateTimePicker
    Friend WithEvents lblProceso As Label
End Class
