Public Class Administrador


    Private Sub btnEntrarAdmin_Click(sender As Object, e As EventArgs) Handles btnEntrarAdmin.Click
        If txtAdmin.Text = "miriam" AndAlso txtContraseñaAdmin.Text = "miriam" Then
            MsgBox("Bienvenida Miriam")
        Else
            MsgBox("Sentimos las molestias pero usted no tiene permiso para entrar a modo administrador. Gracias por su compresión")
        End If
    End Sub
End Class