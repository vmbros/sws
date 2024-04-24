
Public Class frmInicio


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        End
    End Sub


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim vRut As String = txtUsuario.Text
        Dim vPass As String = txtPassword.Text

        Dim m As New Negocio
        Dim nivel As Integer
        nivel = m.validarUsuario(vRut, vPass)

        If nivel = 1 Or nivel = 2 Then

            'Administrador 1 - Usuario 0
            Me.Hide()
            Dim objeto As frmPrincipal = New frmPrincipal(nivel, vRut)
            objeto.ShowDialog()
            Me.Close()
        ElseIf nivel = 4 And Not txtPassword.TextLength = 0 Then


            MessageBox.Show("Solicite al administrador la autorización.", "ERROR DE PERMISOS", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else
            MessageBox.Show("Su rut y/o contraseña son inválidas.", "ERROR DE AUTENTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtUsuario.Clear()
        txtPassword.Clear()
        txtUsuario.Focus()

    End Sub


    Private Sub validador(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress


        If e.KeyChar = "-" Or e.KeyChar = "k" Or e.KeyChar = "K" Then

            If (txtUsuario.TextLength < 6) Then
                e.Handled = True
            Else
                e.Handled = False

            End If

        ElseIf Not IsNumeric(e.KeyChar) And Not Convert.ToChar(8) = e.KeyChar Then


            e.Handled = True
        End If




    End Sub
End Class