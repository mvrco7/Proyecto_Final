Public Class Form2
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Mostrar el Formulario 1 de nuevo
        Form1.Show()

        ' Limpiar los campos de usuario y contraseña en el Formulario 1
        Form1.txtUsuario.Clear()
        Form1.txtContrasena.Clear()

        ' Ocultar el Formulario 2
        Me.Hide()
    End Sub

    Public Sub New()

        InitializeComponent()

        ' Centrar el formulario
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class