<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrystalReportContainer
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
        Me.VisorCrystalReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'VisorCrystalReport
        '
        Me.VisorCrystalReport.ActiveViewIndex = -1
        Me.VisorCrystalReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VisorCrystalReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.VisorCrystalReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorCrystalReport.Location = New System.Drawing.Point(0, 0)
        Me.VisorCrystalReport.Name = "VisorCrystalReport"
        Me.VisorCrystalReport.ShowCloseButton = False
        Me.VisorCrystalReport.ShowLogo = False
        Me.VisorCrystalReport.ShowRefreshButton = False
        Me.VisorCrystalReport.Size = New System.Drawing.Size(839, 667)
        Me.VisorCrystalReport.TabIndex = 0
        Me.VisorCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.VisorCrystalReport.ToolPanelWidth = 233
        '
        'frmCrystalReportContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 667)
        Me.Controls.Add(Me.VisorCrystalReport)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCrystalReportContainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmCrystalReportContainer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisorCrystalReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
