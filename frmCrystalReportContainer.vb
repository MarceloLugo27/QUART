Public Class frmCrystalReportContainer

    Private Sub frmCrystalReportContainer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With VisorCrystalReport
            .ShowCloseButton = False
            .ShowCopyButton = False
            .ShowGotoPageButton = False
            .ShowParameterPanelButton = False
        End With
    End Sub
End Class