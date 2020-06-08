<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toros))
        Me.dgvToros = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NovoToroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDosis = New System.Windows.Forms.Label()
        Me.lblApelido2 = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblApelido1 = New System.Windows.Forms.Label()
        Me.lblCrotal = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvToros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvToros
        '
        Me.dgvToros.AllowUserToAddRows = False
        Me.dgvToros.AllowUserToDeleteRows = False
        Me.dgvToros.AllowUserToResizeColumns = False
        Me.dgvToros.AllowUserToResizeRows = False
        Me.dgvToros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvToros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvToros.Location = New System.Drawing.Point(28, 62)
        Me.dgvToros.Name = "dgvToros"
        Me.dgvToros.ReadOnly = True
        Me.dgvToros.RowHeadersWidth = 51
        Me.dgvToros.RowTemplate.Height = 24
        Me.dgvToros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvToros.Size = New System.Drawing.Size(606, 426)
        Me.dgvToros.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1368, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoToroToolStripMenuItem
        '
        Me.NovoToroToolStripMenuItem.Name = "NovoToroToolStripMenuItem"
        Me.NovoToroToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.NovoToroToolStripMenuItem.Text = "Novo Toro"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDosis)
        Me.GroupBox1.Controls.Add(Me.lblApelido2)
        Me.GroupBox1.Controls.Add(Me.lblNome)
        Me.GroupBox1.Controls.Add(Me.lblApelido1)
        Me.GroupBox1.Controls.Add(Me.lblCrotal)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(680, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 426)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'lblDosis
        '
        Me.lblDosis.AutoSize = True
        Me.lblDosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosis.Location = New System.Drawing.Point(184, 197)
        Me.lblDosis.Name = "lblDosis"
        Me.lblDosis.Size = New System.Drawing.Size(68, 18)
        Me.lblDosis.TabIndex = 18
        Me.lblDosis.Text = "<vacio>"
        '
        'lblApelido2
        '
        Me.lblApelido2.AutoSize = True
        Me.lblApelido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApelido2.Location = New System.Drawing.Point(419, 132)
        Me.lblApelido2.Name = "lblApelido2"
        Me.lblApelido2.Size = New System.Drawing.Size(68, 18)
        Me.lblApelido2.TabIndex = 17
        Me.lblApelido2.Text = "<vacio>"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(395, 58)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(68, 18)
        Me.lblNome.TabIndex = 16
        Me.lblNome.Text = "<vacio>"
        '
        'lblApelido1
        '
        Me.lblApelido1.AutoSize = True
        Me.lblApelido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApelido1.Location = New System.Drawing.Point(129, 132)
        Me.lblApelido1.Name = "lblApelido1"
        Me.lblApelido1.Size = New System.Drawing.Size(68, 18)
        Me.lblApelido1.TabIndex = 15
        Me.lblApelido1.Text = "<vacio>"
        '
        'lblCrotal
        '
        Me.lblCrotal.AutoSize = True
        Me.lblCrotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrotal.Location = New System.Drawing.Point(104, 58)
        Me.lblCrotal.Name = "lblCrotal"
        Me.lblCrotal.Size = New System.Drawing.Size(68, 18)
        Me.lblCrotal.TabIndex = 14
        Me.lblCrotal.Text = "<vacio>"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(339, 390)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(144, 30)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(490, 390)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(144, 30)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar Toro"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dosis Dispoñibles:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(336, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "2º Apelido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "1º Apelido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Crotal:"
        '
        'Toros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvToros)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Toros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toros"
        CType(Me.dgvToros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvToros As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NovoToroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblDosis As Label
    Friend WithEvents lblApelido2 As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblApelido1 As Label
    Friend WithEvents lblCrotal As Label
End Class
