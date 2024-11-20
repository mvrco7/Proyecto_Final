Public Class Form2
    Public Sub New()

        InitializeComponent()

        ' Centrar el formulario
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        ' Mostrar el Formulario 1 de nuevo
        Form1.Show()

        ' Limpiar los campos de usuario y contraseña en el Formulario 1
        Form1.txtUsuario.Clear()
        Form1.txtContrasena.Clear()

        ' Ocultar el Formulario 2
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Mostrar el formulario 3
        Form3.Show()

        'Ocultar el Formulario 2
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Mostrar el formulario 4
        Form4.Show()

        'Ocultar el Formulario 2
        Me.Hide()
    End Sub

    Private Sub btnVentaRepuestos_Click(sender As Object, e As EventArgs) Handles btnVentaRepuestos.Click
        'Mostrar el formulario 5
        Form5.Show()

        'Ocultar el Formulario 2
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Mostrar el formulario 6
        Form6.Show()

        'Ocultar el Formulario 2
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Mostrar el formulario 7
        Form7.Show()

        'Ocultar el Formulario 2
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Mostrar el formulario 8
        Form8.Show()

        'Ocultar el Formulario 2
        Me.Hide()
    End Sub
End Class