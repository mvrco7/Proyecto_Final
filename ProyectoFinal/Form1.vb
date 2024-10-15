Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Form1
    ' Cadena de conexión
    Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

    Public Sub New()
        InitializeComponent()
        ' Centrar el formulario
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cursor para que seleccione Usuario
        txtUsuario.Select()

        txtUsuario.Text = "Rut o Correo"
        txtUsuario.ForeColor = Color.DarkGray
        txtContrasena.Text = "Contraseña"
        txtContrasena.ForeColor = Color.DarkGray
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim input As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text

        ' Verifica que ambos campos estén llenos
        If input = "" Or contrasena = "" Then
            MessageBox.Show("Por favor, llena ambos campos de usuario y contraseña.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validamos si el input es un correo o un RUT
        Dim esCorreo As Boolean = EsCorreoElectronico(input)

        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim query As String

            ' Si es correo electrónico, consultamos con el correo, de lo contrario, con el RUT
            If esCorreo Then
                query = "SELECT COUNT(*) FROM usuarios WHERE correo = @input AND `contraseña` = @contrasena"
            Else
                query = "SELECT COUNT(*) FROM usuarios WHERE rut = @input AND `contraseña` = @contrasena"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@input", input)
            cmd.Parameters.AddWithValue("@contrasena", contrasena)

            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Comprobar si hay coincidencia
            If result > 0 Then
                MessageBox.Show("Hola de nuevo!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Mostrar Form2 solo si la autenticación es exitosa
                Dim formSecundario As New Form2()
                formSecundario.Show()

                ' Ocultar el Form1
                Me.Hide()
            Else
                MessageBox.Show("El usuario o la contraseña son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error al verificar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Función para verificar si el input es un correo electrónico válido
    Private Function EsCorreoElectronico(input As String) As Boolean
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(input)
    End Function

    ' Evento GotFocus y LostFocus para el TextBox de usuario
    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        If txtUsuario.Text = "Rut o Correo" Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "Rut o Correo"
            txtUsuario.ForeColor = Color.DarkGray
        End If
    End Sub

    ' Evento GotFocus y LostFocus para el TextBox de la contraseña
    Private Sub txtContrasena_GotFocus(sender As Object, e As EventArgs) Handles txtContrasena.GotFocus
        If txtContrasena.Text = "Contraseña" Then
            txtContrasena.Text = ""
            txtContrasena.PasswordChar = "*"
            txtContrasena.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtContrasena_LostFocus(sender As Object, e As EventArgs) Handles txtContrasena.LostFocus
        If txtContrasena.Text = "" Then
            txtContrasena.Text = "Contraseña"
            txtContrasena.PasswordChar = ""
            txtContrasena.ForeColor = Color.DarkGray
        End If
    End Sub
End Class
