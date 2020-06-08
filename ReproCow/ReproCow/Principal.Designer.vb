<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EngadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TorosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PróximasTarefasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvAnimales = New System.Windows.Forms.DataGridView()
        Me.gbVaca = New System.Windows.Forms.GroupBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblApePaterno = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCrotal = New System.Windows.Forms.Label()
        Me.lblDataNac = New System.Windows.Forms.Label()
        Me.lblApeMaterno = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gbDocumentos = New System.Windows.Forms.GroupBox()
        Me.btnAcoplamento = New System.Windows.Forms.Button()
        Me.btnXenomica = New System.Windows.Forms.Button()
        Me.btnRexistro = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTipoRexistro = New System.Windows.Forms.Label()
        Me.lblResultadoRexistro = New System.Windows.Forms.Label()
        Me.lblDataRexistro = New System.Windows.Forms.Label()
        Me.lblSexoRexistro = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblEstadoRexistro = New System.Windows.Forms.Label()
        Me.lblSementalRexistro = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVaca.SuspendLayout()
        Me.gbDocumentos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EngadirToolStripMenuItem, Me.TorosToolStripMenuItem, Me.PróximasTarefasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1492, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EngadirToolStripMenuItem
        '
        Me.EngadirToolStripMenuItem.Name = "EngadirToolStripMenuItem"
        Me.EngadirToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.EngadirToolStripMenuItem.Text = "Novo Animal"
        '
        'TorosToolStripMenuItem
        '
        Me.TorosToolStripMenuItem.Name = "TorosToolStripMenuItem"
        Me.TorosToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.TorosToolStripMenuItem.Text = "Toros"
        '
        'PróximasTarefasToolStripMenuItem
        '
        Me.PróximasTarefasToolStripMenuItem.Name = "PróximasTarefasToolStripMenuItem"
        Me.PróximasTarefasToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.PróximasTarefasToolStripMenuItem.Text = "Próximas Tarefas"
        '
        'dgvAnimales
        '
        Me.dgvAnimales.AllowUserToAddRows = False
        Me.dgvAnimales.AllowUserToDeleteRows = False
        Me.dgvAnimales.AllowUserToResizeColumns = False
        Me.dgvAnimales.AllowUserToResizeRows = False
        Me.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnimales.Location = New System.Drawing.Point(47, 38)
        Me.dgvAnimales.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAnimales.Name = "dgvAnimales"
        Me.dgvAnimales.ReadOnly = True
        Me.dgvAnimales.RowHeadersWidth = 51
        Me.dgvAnimales.RowTemplate.Height = 24
        Me.dgvAnimales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAnimales.Size = New System.Drawing.Size(731, 722)
        Me.dgvAnimales.TabIndex = 1
        '
        'gbVaca
        '
        Me.gbVaca.Controls.Add(Me.lblRaza)
        Me.gbVaca.Controls.Add(Me.lblTipo)
        Me.gbVaca.Controls.Add(Me.lblApePaterno)
        Me.gbVaca.Controls.Add(Me.lblNome)
        Me.gbVaca.Controls.Add(Me.lblCrotal)
        Me.gbVaca.Controls.Add(Me.lblDataNac)
        Me.gbVaca.Controls.Add(Me.lblApeMaterno)
        Me.gbVaca.Controls.Add(Me.lblNumero)
        Me.gbVaca.Controls.Add(Me.btnModificar)
        Me.gbVaca.Controls.Add(Me.btnEliminar)
        Me.gbVaca.Controls.Add(Me.gbDocumentos)
        Me.gbVaca.Controls.Add(Me.Label8)
        Me.gbVaca.Controls.Add(Me.Label7)
        Me.gbVaca.Controls.Add(Me.Label6)
        Me.gbVaca.Controls.Add(Me.Label5)
        Me.gbVaca.Controls.Add(Me.Label4)
        Me.gbVaca.Controls.Add(Me.Label3)
        Me.gbVaca.Controls.Add(Me.Label2)
        Me.gbVaca.Controls.Add(Me.Label1)
        Me.gbVaca.Location = New System.Drawing.Point(786, 38)
        Me.gbVaca.Margin = New System.Windows.Forms.Padding(4)
        Me.gbVaca.Name = "gbVaca"
        Me.gbVaca.Padding = New System.Windows.Forms.Padding(4)
        Me.gbVaca.Size = New System.Drawing.Size(694, 410)
        Me.gbVaca.TabIndex = 2
        Me.gbVaca.TabStop = False
        Me.gbVaca.Text = "Información "
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(434, 224)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(68, 18)
        Me.lblRaza.TabIndex = 18
        Me.lblRaza.Text = "<vacio>"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(428, 153)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(68, 18)
        Me.lblTipo.TabIndex = 17
        Me.lblTipo.Text = "<vacio>"
        '
        'lblApePaterno
        '
        Me.lblApePaterno.AutoSize = True
        Me.lblApePaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApePaterno.Location = New System.Drawing.Point(503, 89)
        Me.lblApePaterno.Name = "lblApePaterno"
        Me.lblApePaterno.Size = New System.Drawing.Size(68, 18)
        Me.lblApePaterno.TabIndex = 16
        Me.lblApePaterno.Text = "<vacio>"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNome.ForeColor = System.Drawing.Color.Red
        Me.lblNome.Location = New System.Drawing.Point(440, 38)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(83, 24)
        Me.lblNome.TabIndex = 15
        Me.lblNome.Text = "<vacio>"
        '
        'lblCrotal
        '
        Me.lblCrotal.AutoSize = True
        Me.lblCrotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrotal.Location = New System.Drawing.Point(168, 224)
        Me.lblCrotal.Name = "lblCrotal"
        Me.lblCrotal.Size = New System.Drawing.Size(68, 18)
        Me.lblCrotal.TabIndex = 14
        Me.lblCrotal.Text = "<vacio>"
        '
        'lblDataNac
        '
        Me.lblDataNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataNac.Location = New System.Drawing.Point(191, 153)
        Me.lblDataNac.Name = "lblDataNac"
        Me.lblDataNac.Size = New System.Drawing.Size(90, 18)
        Me.lblDataNac.TabIndex = 13
        Me.lblDataNac.Text = "<vacio>"
        '
        'lblApeMaterno
        '
        Me.lblApeMaterno.AutoSize = True
        Me.lblApeMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApeMaterno.Location = New System.Drawing.Point(169, 89)
        Me.lblApeMaterno.Name = "lblApeMaterno"
        Me.lblApeMaterno.Size = New System.Drawing.Size(68, 18)
        Me.lblApeMaterno.TabIndex = 12
        Me.lblApeMaterno.Text = "<vacio>"
        '
        'lblNumero
        '
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumero.ForeColor = System.Drawing.Color.Red
        Me.lblNumero.Location = New System.Drawing.Point(84, 38)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(86, 24)
        Me.lblNumero.TabIndex = 11
        Me.lblNumero.Text = "<vacio>"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(386, 369)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(144, 30)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(537, 369)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(144, 30)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar Animal"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'gbDocumentos
        '
        Me.gbDocumentos.Controls.Add(Me.btnAcoplamento)
        Me.gbDocumentos.Controls.Add(Me.btnXenomica)
        Me.gbDocumentos.Controls.Add(Me.btnRexistro)
        Me.gbDocumentos.Location = New System.Drawing.Point(7, 273)
        Me.gbDocumentos.Name = "gbDocumentos"
        Me.gbDocumentos.Size = New System.Drawing.Size(674, 67)
        Me.gbDocumentos.TabIndex = 8
        Me.gbDocumentos.TabStop = False
        Me.gbDocumentos.Text = "Ver documentos"
        '
        'btnAcoplamento
        '
        Me.btnAcoplamento.Location = New System.Drawing.Point(450, 28)
        Me.btnAcoplamento.Name = "btnAcoplamento"
        Me.btnAcoplamento.Size = New System.Drawing.Size(215, 30)
        Me.btnAcoplamento.TabIndex = 2
        Me.btnAcoplamento.Text = "Ficheiro de acoplamento"
        Me.btnAcoplamento.UseVisualStyleBackColor = True
        '
        'btnXenomica
        '
        Me.btnXenomica.Location = New System.Drawing.Point(227, 28)
        Me.btnXenomica.Name = "btnXenomica"
        Me.btnXenomica.Size = New System.Drawing.Size(217, 30)
        Me.btnXenomica.TabIndex = 1
        Me.btnXenomica.Text = "Ficheiro de xenómica"
        Me.btnXenomica.UseVisualStyleBackColor = True
        '
        'btnRexistro
        '
        Me.btnRexistro.Location = New System.Drawing.Point(6, 28)
        Me.btnRexistro.Name = "btnRexistro"
        Me.btnRexistro.Size = New System.Drawing.Size(215, 30)
        Me.btnRexistro.TabIndex = 0
        Me.btnRexistro.Text = "Carta de Rexistro"
        Me.btnRexistro.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Data de nacemento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(381, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Raza:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(381, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(381, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apelido paterno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apelido materno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Crotal completo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 18)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Tipo:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(206, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(281, 30)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Ver todos os rexistros"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(543, 159)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 30)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Engadir rexistro"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 159)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 30)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Borrar rexistro"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(381, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 18)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Data:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(383, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 18)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Resultado:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(36, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 18)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Sexo:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(381, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 18)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Estado da cría:"
        '
        'lblTipoRexistro
        '
        Me.lblTipoRexistro.AutoSize = True
        Me.lblTipoRexistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoRexistro.ForeColor = System.Drawing.Color.Red
        Me.lblTipoRexistro.Location = New System.Drawing.Point(79, 31)
        Me.lblTipoRexistro.Name = "lblTipoRexistro"
        Me.lblTipoRexistro.Size = New System.Drawing.Size(83, 24)
        Me.lblTipoRexistro.TabIndex = 25
        Me.lblTipoRexistro.Text = "<vacio>"
        '
        'lblResultadoRexistro
        '
        Me.lblResultadoRexistro.AutoSize = True
        Me.lblResultadoRexistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultadoRexistro.Location = New System.Drawing.Point(468, 79)
        Me.lblResultadoRexistro.Name = "lblResultadoRexistro"
        Me.lblResultadoRexistro.Size = New System.Drawing.Size(68, 18)
        Me.lblResultadoRexistro.TabIndex = 26
        Me.lblResultadoRexistro.Text = "<vacio>"
        '
        'lblDataRexistro
        '
        Me.lblDataRexistro.AutoSize = True
        Me.lblDataRexistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataRexistro.Location = New System.Drawing.Point(430, 34)
        Me.lblDataRexistro.Name = "lblDataRexistro"
        Me.lblDataRexistro.Size = New System.Drawing.Size(68, 18)
        Me.lblDataRexistro.TabIndex = 27
        Me.lblDataRexistro.Text = "<vacio>"
        '
        'lblSexoRexistro
        '
        Me.lblSexoRexistro.AutoSize = True
        Me.lblSexoRexistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoRexistro.Location = New System.Drawing.Point(88, 117)
        Me.lblSexoRexistro.Name = "lblSexoRexistro"
        Me.lblSexoRexistro.Size = New System.Drawing.Size(68, 18)
        Me.lblSexoRexistro.TabIndex = 28
        Me.lblSexoRexistro.Text = "<vacio>"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(36, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 18)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Semental:"
        '
        'lblEstadoRexistro
        '
        Me.lblEstadoRexistro.AutoSize = True
        Me.lblEstadoRexistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoRexistro.Location = New System.Drawing.Point(494, 117)
        Me.lblEstadoRexistro.Name = "lblEstadoRexistro"
        Me.lblEstadoRexistro.Size = New System.Drawing.Size(68, 18)
        Me.lblEstadoRexistro.TabIndex = 29
        Me.lblEstadoRexistro.Text = "<vacio>"
        '
        'lblSementalRexistro
        '
        Me.lblSementalRexistro.AutoSize = True
        Me.lblSementalRexistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSementalRexistro.Location = New System.Drawing.Point(116, 79)
        Me.lblSementalRexistro.Name = "lblSementalRexistro"
        Me.lblSementalRexistro.Size = New System.Drawing.Size(68, 18)
        Me.lblSementalRexistro.TabIndex = 26
        Me.lblSementalRexistro.Text = "<vacio>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSementalRexistro)
        Me.GroupBox1.Controls.Add(Me.lblEstadoRexistro)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lblSexoRexistro)
        Me.GroupBox1.Controls.Add(Me.lblDataRexistro)
        Me.GroupBox1.Controls.Add(Me.lblResultadoRexistro)
        Me.GroupBox1.Controls.Add(Me.lblTipoRexistro)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(786, 455)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 204)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Último Rexistro"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1492, 773)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbVaca)
        Me.Controls.Add(Me.dgvAnimales)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReproCow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVaca.ResumeLayout(False)
        Me.gbVaca.PerformLayout()
        Me.gbDocumentos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EngadirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvAnimales As DataGridView
    Friend WithEvents gbVaca As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbDocumentos As GroupBox
    Friend WithEvents btnAcoplamento As Button
    Friend WithEvents btnXenomica As Button
    Friend WithEvents btnRexistro As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PróximasTarefasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblRaza As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblApePaterno As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblCrotal As Label
    Friend WithEvents lblDataNac As Label
    Friend WithEvents lblApeMaterno As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents TorosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblTipoRexistro As Label
    Friend WithEvents lblResultadoRexistro As Label
    Friend WithEvents lblDataRexistro As Label
    Friend WithEvents lblSexoRexistro As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblEstadoRexistro As Label
    Friend WithEvents lblSementalRexistro As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
