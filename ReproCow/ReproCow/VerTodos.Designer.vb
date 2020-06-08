<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerTodos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerTodos))
        Me.gbInseminacions = New System.Windows.Forms.GroupBox()
        Me.dgvInseminacions = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbRevision1 = New System.Windows.Forms.GroupBox()
        Me.dgvrevisions1 = New System.Windows.Forms.DataGridView()
        Me.gbRevision2 = New System.Windows.Forms.GroupBox()
        Me.dgvRevision2 = New System.Windows.Forms.DataGridView()
        Me.gbPartos = New System.Windows.Forms.GroupBox()
        Me.dgvPartos = New System.Windows.Forms.DataGridView()
        Me.gbSecados = New System.Windows.Forms.GroupBox()
        Me.dgvSecados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbInseminacions.SuspendLayout()
        CType(Me.dgvInseminacions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRevision1.SuspendLayout()
        CType(Me.dgvrevisions1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRevision2.SuspendLayout()
        CType(Me.dgvRevision2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPartos.SuspendLayout()
        CType(Me.dgvPartos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSecados.SuspendLayout()
        CType(Me.dgvSecados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbInseminacions
        '
        Me.gbInseminacions.Controls.Add(Me.dgvInseminacions)
        Me.gbInseminacions.Location = New System.Drawing.Point(14, 69)
        Me.gbInseminacions.Name = "gbInseminacions"
        Me.gbInseminacions.Size = New System.Drawing.Size(557, 186)
        Me.gbInseminacions.TabIndex = 0
        Me.gbInseminacions.TabStop = False
        Me.gbInseminacions.Text = "Inseminacións"
        '
        'dgvInseminacions
        '
        Me.dgvInseminacions.AllowUserToAddRows = False
        Me.dgvInseminacions.AllowUserToDeleteRows = False
        Me.dgvInseminacions.AllowUserToResizeColumns = False
        Me.dgvInseminacions.AllowUserToResizeRows = False
        Me.dgvInseminacions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInseminacions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInseminacions.Location = New System.Drawing.Point(6, 23)
        Me.dgvInseminacions.Name = "dgvInseminacions"
        Me.dgvInseminacions.ReadOnly = True
        Me.dgvInseminacions.RowHeadersWidth = 51
        Me.dgvInseminacions.RowTemplate.Height = 24
        Me.dgvInseminacions.Size = New System.Drawing.Size(545, 157)
        Me.dgvInseminacions.TabIndex = 0
        '
        'gbRevision1
        '
        Me.gbRevision1.Controls.Add(Me.dgvrevisions1)
        Me.gbRevision1.Location = New System.Drawing.Point(577, 69)
        Me.gbRevision1.Name = "gbRevision1"
        Me.gbRevision1.Size = New System.Drawing.Size(557, 186)
        Me.gbRevision1.TabIndex = 1
        Me.gbRevision1.TabStop = False
        Me.gbRevision1.Text = "1ª Revisións"
        '
        'dgvrevisions1
        '
        Me.dgvrevisions1.AllowUserToAddRows = False
        Me.dgvrevisions1.AllowUserToDeleteRows = False
        Me.dgvrevisions1.AllowUserToResizeColumns = False
        Me.dgvrevisions1.AllowUserToResizeRows = False
        Me.dgvrevisions1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvrevisions1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrevisions1.Location = New System.Drawing.Point(6, 23)
        Me.dgvrevisions1.Name = "dgvrevisions1"
        Me.dgvrevisions1.ReadOnly = True
        Me.dgvrevisions1.RowHeadersWidth = 51
        Me.dgvrevisions1.RowTemplate.Height = 24
        Me.dgvrevisions1.Size = New System.Drawing.Size(545, 157)
        Me.dgvrevisions1.TabIndex = 2
        '
        'gbRevision2
        '
        Me.gbRevision2.Controls.Add(Me.dgvRevision2)
        Me.gbRevision2.Location = New System.Drawing.Point(14, 261)
        Me.gbRevision2.Name = "gbRevision2"
        Me.gbRevision2.Size = New System.Drawing.Size(557, 186)
        Me.gbRevision2.TabIndex = 1
        Me.gbRevision2.TabStop = False
        Me.gbRevision2.Text = "2ª Revisións"
        '
        'dgvRevision2
        '
        Me.dgvRevision2.AllowUserToAddRows = False
        Me.dgvRevision2.AllowUserToDeleteRows = False
        Me.dgvRevision2.AllowUserToResizeColumns = False
        Me.dgvRevision2.AllowUserToResizeRows = False
        Me.dgvRevision2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRevision2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRevision2.Location = New System.Drawing.Point(6, 23)
        Me.dgvRevision2.Name = "dgvRevision2"
        Me.dgvRevision2.ReadOnly = True
        Me.dgvRevision2.RowHeadersWidth = 51
        Me.dgvRevision2.RowTemplate.Height = 24
        Me.dgvRevision2.Size = New System.Drawing.Size(545, 157)
        Me.dgvRevision2.TabIndex = 1
        '
        'gbPartos
        '
        Me.gbPartos.Controls.Add(Me.dgvPartos)
        Me.gbPartos.Location = New System.Drawing.Point(140, 453)
        Me.gbPartos.Name = "gbPartos"
        Me.gbPartos.Size = New System.Drawing.Size(788, 186)
        Me.gbPartos.TabIndex = 1
        Me.gbPartos.TabStop = False
        Me.gbPartos.Text = "Partos"
        '
        'dgvPartos
        '
        Me.dgvPartos.AllowUserToAddRows = False
        Me.dgvPartos.AllowUserToDeleteRows = False
        Me.dgvPartos.AllowUserToResizeColumns = False
        Me.dgvPartos.AllowUserToResizeRows = False
        Me.dgvPartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartos.Location = New System.Drawing.Point(6, 23)
        Me.dgvPartos.Name = "dgvPartos"
        Me.dgvPartos.ReadOnly = True
        Me.dgvPartos.RowHeadersWidth = 51
        Me.dgvPartos.RowTemplate.Height = 24
        Me.dgvPartos.Size = New System.Drawing.Size(776, 157)
        Me.dgvPartos.TabIndex = 1
        '
        'gbSecados
        '
        Me.gbSecados.Controls.Add(Me.dgvSecados)
        Me.gbSecados.Location = New System.Drawing.Point(577, 261)
        Me.gbSecados.Name = "gbSecados"
        Me.gbSecados.Size = New System.Drawing.Size(557, 186)
        Me.gbSecados.TabIndex = 2
        Me.gbSecados.TabStop = False
        Me.gbSecados.Text = "Secados"
        '
        'dgvSecados
        '
        Me.dgvSecados.AllowUserToAddRows = False
        Me.dgvSecados.AllowUserToDeleteRows = False
        Me.dgvSecados.AllowUserToResizeColumns = False
        Me.dgvSecados.AllowUserToResizeRows = False
        Me.dgvSecados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSecados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSecados.Location = New System.Drawing.Point(6, 23)
        Me.dgvSecados.Name = "dgvSecados"
        Me.dgvSecados.ReadOnly = True
        Me.dgvSecados.RowHeadersWidth = 51
        Me.dgvSecados.RowTemplate.Height = 24
        Me.dgvSecados.Size = New System.Drawing.Size(545, 157)
        Me.dgvSecados.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nº:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(599, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome:"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.ForeColor = System.Drawing.Color.Red
        Me.lblNumero.Location = New System.Drawing.Point(305, 24)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(83, 24)
        Me.lblNumero.TabIndex = 5
        Me.lblNumero.Text = "<vacio>"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.Color.Red
        Me.lblNome.Location = New System.Drawing.Point(656, 25)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(83, 24)
        Me.lblNome.TabIndex = 6
        Me.lblNome.Text = "<vacio>"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(137, 92)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(0, 18)
        Me.lblCodigo.TabIndex = 7
        Me.lblCodigo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 678)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(938, 36)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tabla Partos -->Sexo: (1)=Macho, (0)=Femia           " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tablas de Revisións --> Se" &
    "xo: (1)=Macho, (0)=Femia    -  Revisión:(1)=2ª Revisión, (0)=1ª Revisión   -   R" &
    "esultado: (1)=Positivo, (0)=Negativo"
        '
        'VerTodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 742)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbRevision2)
        Me.Controls.Add(Me.gbSecados)
        Me.Controls.Add(Me.gbPartos)
        Me.Controls.Add(Me.gbRevision1)
        Me.Controls.Add(Me.gbInseminacions)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerTodos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VerTodos"
        Me.gbInseminacions.ResumeLayout(False)
        CType(Me.dgvInseminacions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRevision1.ResumeLayout(False)
        CType(Me.dgvrevisions1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRevision2.ResumeLayout(False)
        CType(Me.dgvRevision2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPartos.ResumeLayout(False)
        CType(Me.dgvPartos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSecados.ResumeLayout(False)
        CType(Me.dgvSecados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbInseminacions As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gbRevision1 As GroupBox
    Friend WithEvents gbRevision2 As GroupBox
    Friend WithEvents gbPartos As GroupBox
    Friend WithEvents gbSecados As GroupBox
    Friend WithEvents dgvInseminacions As DataGridView
    Friend WithEvents dgvrevisions1 As DataGridView
    Friend WithEvents dgvRevision2 As DataGridView
    Friend WithEvents dgvPartos As DataGridView
    Friend WithEvents dgvSecados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label3 As Label
End Class
