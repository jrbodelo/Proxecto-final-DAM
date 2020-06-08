<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visorPDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(visorPDF))
        Me.AxPDF = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxPDF
        '
        Me.AxPDF.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.AxPDF.Enabled = True
        Me.AxPDF.Location = New System.Drawing.Point(12, 12)
        Me.AxPDF.Name = "AxPDF"
        Me.AxPDF.OcxState = CType(resources.GetObject("AxPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxPDF.Size = New System.Drawing.Size(1524, 776)
        Me.AxPDF.TabIndex = 0
        '
        'visorPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1548, 800)
        Me.Controls.Add(Me.AxPDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "visorPDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "visorPDF"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxPDF As AxAcroPDFLib.AxAcroPDF
End Class
