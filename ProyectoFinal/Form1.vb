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

        'Color del texto para el cursor de Usuario y Contraseña
        txtUsuario.Text = "Rut o Correo"
        txtUsuario.ForeColor = Color.DarkGray
        txtContrasena.Text = "Contraseña"
        txtContrasena.ForeColor = Color.Gray
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim input As String = txtUsuario.Text
        Dim contrasena As String = txtContrasena.Text

        ' Verifica si ambos campos están vacíos
        If (input = "" Or input = "Rut o Correo") And (contrasena = "" Or contrasena = "Contraseña") Then
            MessageBox.Show("Por favor, completar ambos campos para continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsuario.Select()
            Return
        End If

        ' Verifica si el campo de usuario está vacío
        If input = "" Or input = "Rut o Correo" Then
            MessageBox.Show("Por favor, ingrese usuario.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsuario.Select()
            Return
        End If

        ' Verifica si el campo de contraseña está vacío
        If contrasena = "" Or contrasena = "Contraseña" Then
            MessageBox.Show("Por favor, ingrese contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContrasena.Select()
            Return
        End If

        ' Validamos si el input es un correo o un RUT
        Dim esCorreo As Boolean = EsCorreoElectronico(input)

        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim queryUsuario As String
            Dim queryContrasena As String

            ' Si es correo electrónico, consultamos con el correo, de lo contrario, con el RUT
            If esCorreo Then
                queryUsuario = "SELECT COUNT(*) FROM usuarios WHERE correo = @input"
                queryContrasena = "SELECT COUNT(*) FROM usuarios WHERE correo = @input AND `contraseña` = @contrasena"
            Else
                queryUsuario = "SELECT COUNT(*) FROM usuarios WHERE rut = @input"
                queryContrasena = "SELECT COUNT(*) FROM usuarios WHERE rut = @input AND `contraseña` = @contrasena"
            End If

            ' Verificar si el usuario existe
            Dim cmdUsuario As New MySqlCommand(queryUsuario, conn)
            cmdUsuario.Parameters.AddWithValue("@input", input)

            Dim usuarioExiste As Integer = Convert.ToInt32(cmdUsuario.ExecuteScalar())

            If usuarioExiste = 0 Then
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsuario.Select()
                Return
            End If

            ' Verificar si la contraseña es correcta
            Dim cmdContrasena As New MySqlCommand(queryContrasena, conn)
            cmdContrasena.Parameters.AddWithValue("@input", input)
            cmdContrasena.Parameters.AddWithValue("@contrasena", contrasena)

            Dim contrasenaCorrecta As Integer = Convert.ToInt32(cmdContrasena.ExecuteScalar())

            ' Comprobar si hay coincidencia de usuario y contraseña
            If contrasenaCorrecta > 0 Then
                MessageBox.Show("Hola de nuevo!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Mostrar Form2 solo si la autenticación es exitosa
                Dim formSecundario As New Form2()
                formSecundario.Show()

                ' Ocultar el Form1
                Me.Hide()
            Else
                MessageBox.Show("La contraseña es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContrasena.Select()
            End If

        Catch ex As MySqlException
            ' Mensaje más específico para errores de MySQL
            MessageBox.Show("Error de MySQL: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            ' Captura cualquier otro tipo de excepción
            MessageBox.Show("Error: " & ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
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

