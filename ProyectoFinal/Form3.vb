Imports MySql.Data.MySqlClient

Public Class Form3
    Public Sub New()
        InitializeComponent()

        ' Centrar el formulario
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar el ComboBox con algunos valores
        cmbCargo.Items.AddRange(New String() {"Gerente", "Analista", "Administrador/a", "Asegurador/a", "Mecanico/a", "Vendedor/a"})
        cmbCargo.Text = "Cargo"
        cmbCargo.ForeColor = Color.DarkGray

        ' Color del texto para el cursor de Rut, Correo y Contraseña
        InicializarTextBox(txtRut, "Rut")
        InicializarTextBox(txtCorreo, "Correo")
        InicializarTextBox(txtContrasena, "Contraseña", True)

        ' Cursor para que seleccione Rut primero
        txtRut.Select()
    End Sub

    ' Inicializar el TextBox
    Private Sub InicializarTextBox(textBox As TextBox, placeholder As String, Optional isPassword As Boolean = False)
        textBox.Text = placeholder
        textBox.ForeColor = Color.DarkGray
        If isPassword Then
            textBox.PasswordChar = ""
        End If
    End Sub

    ' Validación de los campos con el mensaje "Por favor, rellena los campos"
    Private Function ValidarFormulario() As Boolean
        If String.IsNullOrWhiteSpace(txtRut.Text) OrElse txtRut.Text = "Rut" Then
            MessageBox.Show("Por favor, rellena los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCorreo.Text) OrElse txtCorreo.Text = "Correo" Then
            MessageBox.Show("Por favor, rellena los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtContrasena.Text) OrElse txtContrasena.Text = "Contraseña" Then
            MessageBox.Show("Por favor, rellena los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cmbCargo.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, rellena los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function


    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        If Not ValidarFormulario() Then Exit Sub

        Dim rut As String = txtRut.Text
        Dim correo As String = txtCorreo.Text
        Dim contrasena As String = txtContrasena.Text
        Dim cargo As String = cmbCargo.SelectedItem.ToString()

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO Usuarios (Rut, Correo, Contraseña, Tipo) VALUES (@rut, @correo, @contraseña, @tipo)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@rut", rut)
                command.Parameters.AddWithValue("@correo", correo)
                command.Parameters.AddWithValue("@contraseña", contrasena)
                command.Parameters.AddWithValue("@tipo", cargo)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Usuario creado exitosamente.")
                Catch ex As MySqlException
                    MessageBox.Show("Error al crear el usuario: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnBuscarRut_Click(sender As Object, e As EventArgs) Handles btnBuscarRut.Click
        Dim rut As String = txtRut.Text

        ' Verificar que el RUT no esté vacío
        If String.IsNullOrWhiteSpace(rut) Or rut = "Rut" Then
            MessageBox.Show("Por favor, ingresa un RUT para buscar.")
            Return
        End If

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Correo, Tipo, Contraseña FROM Usuarios WHERE Rut = @rut"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@rut", rut)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                txtCorreo.Text = reader("Correo").ToString()
                                txtContrasena.Text = reader("Contraseña").ToString()
                                cmbCargo.Text = reader("Tipo").ToString()
                            End While
                            MessageBox.Show("Usuario encontrado.")

                            ' Cambiar el color del texto a negro
                            txtCorreo.ForeColor = Color.Black
                            txtContrasena.ForeColor = Color.Black
                            cmbCargo.ForeColor = Color.Black
                        Else
                            MessageBox.Show("No se encontró un usuario con ese RUT.")
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error al buscar el usuario: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnActualizarBD_Click(sender As Object, e As EventArgs) Handles btnActualizarBD.Click
        ' Verificar que todos los campos estén llenos
        If Not ValidarFormulario() Then Exit Sub

        Dim rut As String = txtRut.Text
        Dim correo As String = txtCorreo.Text
        Dim contrasena As String = txtContrasena.Text
        Dim cargo As String = cmbCargo.SelectedItem.ToString()

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Verificar si el usuario existe antes de actualizar
                Dim checkQuery As String = "SELECT COUNT(*) FROM Usuarios WHERE Rut = @rut"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@rut", rut)
                    Dim userExists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If userExists = 0 Then
                        MessageBox.Show("Error: No se encontró un usuario con ese RUT para actualizar.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                ' Actualizar el usuario
                Dim query As String = "UPDATE Usuarios SET Correo = @correo, Contraseña = @contraseña, Tipo = @tipo WHERE Rut = @rut"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@rut", rut)
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@contraseña", contrasena)
                    command.Parameters.AddWithValue("@tipo", cargo)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario actualizado exitosamente.")
                    Else
                        MessageBox.Show("No se encontró un usuario con ese RUT para actualizar.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al actualizar el usuario: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar que todos los campos estén llenos
        If Not ValidarFormulario() Then Exit Sub

        Dim rut As String = txtRut.Text

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Verificar si el usuario existe antes de eliminar
                Dim checkQuery As String = "SELECT COUNT(*) FROM Usuarios WHERE Rut = @rut"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@rut", rut)
                    Dim userExists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If userExists = 0 Then
                        MessageBox.Show("Error: No se encontró un usuario con ese RUT para eliminar.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                ' Eliminar el usuario
                Dim query As String = "DELETE FROM Usuarios WHERE Rut = @rut"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@rut", rut)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario eliminado exitosamente.")
                        LimpiarFormulario()
                    Else
                        MessageBox.Show("No se encontró un usuario con ese RUT para eliminar.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al eliminar el usuario: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub


    Private Sub LimpiarFormulario()
        InicializarTextBox(txtRut, "Rut")
        InicializarTextBox(txtCorreo, "Correo")
        InicializarTextBox(txtContrasena, "Contraseña", True)
        cmbCargo.Text = "Cargo"
        cmbCargo.ForeColor = Color.DarkGray
    End Sub

    Private Sub btnVolverMenu_Click(sender As Object, e As EventArgs) Handles btnVolverMenu.Click
        ' Mostrar el Formulario 1 de nuevo
        Form2.Show()
        ' Ocultar el Formulario 3
        Me.Hide()
    End Sub

    ' Evento GotFocus y LostFocus para el TextBox Rut
    Private Sub txtRut_GotFocus(sender As Object, e As EventArgs) Handles txtRut.GotFocus
        CambiarPlaceholder(txtRut, "Rut", Color.Black)
    End Sub

    Private Sub txtRut_LostFocus(sender As Object, e As EventArgs) Handles txtRut.LostFocus
        CambiarPlaceholder(txtRut, "Rut", Color.DarkGray)
    End Sub

    ' Evento GotFocus y LostFocus para el TextBox Correo
    Private Sub txtCorreo_GotFocus(sender As Object, e As EventArgs) Handles txtCorreo.GotFocus
        CambiarPlaceholder(txtCorreo, "Correo", Color.Black)
    End Sub

    Private Sub txtCorreo_LostFocus(sender As Object, e As EventArgs) Handles txtCorreo.LostFocus
        CambiarPlaceholder(txtCorreo, "Correo", Color.DarkGray)
    End Sub

    ' Evento GotFocus y LostFocus para el TextBox Contraseña
    Private Sub txtContrasena_GotFocus(sender As Object, e As EventArgs) Handles txtContrasena.GotFocus
        CambiarPlaceholder(txtContrasena, "Contraseña", Color.Black, True)
    End Sub

    Private Sub txtContrasena_LostFocus(sender As Object, e As EventArgs) Handles txtContrasena.LostFocus
        CambiarPlaceholder(txtContrasena, "Contraseña", Color.DarkGray)
    End Sub

    ' Evento GotFocus y LostFocus para el ComboBox Cargo
    Private Sub cmbCargo_GotFocus(sender As Object, e As EventArgs) Handles cmbCargo.GotFocus
        If cmbCargo.Text = "Cargo" Then
            cmbCargo.Text = ""
            cmbCargo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbCargo_LostFocus(sender As Object, e As EventArgs) Handles cmbCargo.LostFocus
        If cmbCargo.Text = "" Then
            cmbCargo.Text = "Cargo"
            cmbCargo.ForeColor = Color.DarkGray
        Else
            cmbCargo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnVerDatosBD_Click(sender As Object, e As EventArgs) Handles btnVerDatosBD.Click
        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Rut, Correo, Tipo FROM Usuarios"
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            Dim datos As String = "Datos en la base de datos:" & vbCrLf
                            While reader.Read()
                                datos &= "RUT: " & reader("Rut").ToString() & vbCrLf
                                datos &= "Correo: " & reader("Correo").ToString() & vbCrLf
                                datos &= "Tipo: " & reader("Tipo").ToString() & vbCrLf
                                datos &= "-------------------------" & vbCrLf
                            End While
                            MessageBox.Show(datos)
                        Else
                            MessageBox.Show("No hay registros en la base de datos.")
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error al obtener los datos: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    ' Método para cambiar el placeholder y el color del texto
    Private Sub CambiarPlaceholder(textBox As TextBox, placeholder As String, textColor As Color, Optional isPassword As Boolean = False)
        If textBox.Text = placeholder Then
            textBox.Text = ""
            textBox.ForeColor = textColor
            If isPassword Then
                textBox.PasswordChar = "*"
            End If
        ElseIf String.IsNullOrWhiteSpace(textBox.Text) Then
            textBox.Text = placeholder
            textBox.ForeColor = Color.DarkGray
            If isPassword Then
                textBox.PasswordChar = ""
            End If
        End If
    End Sub
End Class



