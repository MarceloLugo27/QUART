Imports QuartOK.ProcedimientosGenerales
Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtLetra.Text = ""
        If IsNumeric(txtNumero.Text) Then
            txtLetra.Text = Letras(txtNumero.Text)
        Else
            MessageBox.Show("Ingrese por favor números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtNumero.Focus()
        txtNumero.SelectionStart = 0
        txtNumero.SelectionLength = txtNumero.ToString.Length
    End Sub


    Private Sub txtNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtNumero.Text & CChar(eventArgs.KeyChar))
    End Sub

    Private Sub MaskedTextBox1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        EventArgs.Handled = Fg_SoloNumeros(EventArgs.KeyChar, MaskedTextBox1.Text & CChar(EventArgs.KeyChar))
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class