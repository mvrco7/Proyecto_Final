Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Form6

    ' Propiedad para recibir el RUT desde el Form5
    Public Property RutCliente As String

    Public Sub New()
        InitializeComponent()

        ' Centrar el formulario
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Llenar el campo de RUT en Form6 cuando se carga el formulario
        txtRut.Text = RutCliente
    End Sub

    Private Sub btnBuscarRut_Click(sender As Object, e As EventArgs) Handles btnBuscarRut.Click
        ' Verificar que el campo RUT no esté vacío
        If String.IsNullOrEmpty(txtRut.Text) Then
            MessageBox.Show("Por favor, ingrese el RUT del cliente que desea buscar.")
            Exit Sub
        End If

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM clientes WHERE Rut = @rut"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@rut", txtRut.Text)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Verifica si se encontró algún registro
                        If reader.HasRows Then
                            While reader.Read()
                                txtNombre.Text = reader("Nombre").ToString()
                                txtApellidoP.Text = reader("ApellidoP").ToString()
                                txtApellidoM.Text = reader("ApellidoM").ToString()
                                txtDireccion.Text = reader("Direccion").ToString()
                                txtTelefono.Text = reader("Telefono").ToString()
                                txtComuna.Text = reader("Comuna").ToString()
                            End While
                            MessageBox.Show("Cliente encontrado.")
                        Else
                            MessageBox.Show("No se encontró un cliente con el RUT proporcionado.")
                            ' Si no se encuentra el cliente, mostrar un MessageBox con opción de crear uno nuevo
                            Dim result As DialogResult = MessageBox.Show("No se encontró un cliente con el RUT proporcionado. ¿Desea crear uno nuevo?", "Cliente no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If result = DialogResult.Yes Then
                                ' Limpiar los campos para permitir la creación de un nuevo cliente
                                txtNombre.Clear()
                                txtApellidoP.Clear()
                                txtApellidoM.Clear()
                                txtDireccion.Clear()
                                txtTelefono.Clear()
                                txtComuna.Clear()
                                MessageBox.Show("Ingrese los datos del nuevo cliente y luego haga clic en 'Crear Cliente'.")
                            End If
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error al buscar el registro: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub


    Private Sub btnVolverMenu_Click(sender As Object, e As EventArgs) Handles btnVolverMenu.Click
        ' Evento para volver al menú principal
        Form2.Show()
        Me.Hide() ' Ocultar formulario actual
    End Sub

    Private Sub btnLimpiarDatos_Click(sender As Object, e As EventArgs) Handles btnLimpiarDatos.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtRut.Clear()
        txtNombre.Clear()
        txtApellidoP.Clear()
        txtApellidoM.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtComuna.Clear()
    End Sub

    Private Sub btnCrearCliente_Click(sender As Object, e As EventArgs) Handles btnCrearCliente.Click

        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellidop As String = txtApellidoP.Text
        Dim apellidom As String = txtApellidoM.Text
        Dim dirección As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim comuna As String = txtComuna.Text

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO clientes (Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna) VALUES (@rut, @nombre, @apellidop, @apellidom, @direccion, @telefono, @comuna)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@rut", rut)
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@apellidop", apellidop)
                command.Parameters.AddWithValue("@apellidom", apellidom)
                command.Parameters.AddWithValue("@direccion", dirección)
                command.Parameters.AddWithValue("@telefono", telefono)
                command.Parameters.AddWithValue("@comuna", comuna)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cliente creado exitosamente.")
                    LimpiarCampos() ' Llamada para limpiar campos después de crear el cliente
                Catch ex As MySqlException
                    MessageBox.Show("Error al crear el : " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnActualizarBD_Click(sender As Object, e As EventArgs) Handles btnActualizarBD.Click
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellidop As String = txtApellidoP.Text
        Dim apellidom As String = txtApellidoM.Text
        Dim dirección As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim comuna As String = txtComuna.Text

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Verificar si el cliente existe antes de actualizar
                Dim checkQuery As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @rut"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@rut", rut)
                    Dim clienteExists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If clienteExists = 0 Then
                        MessageBox.Show("Error: No se encontró un cliente con ese RUT para actualizar.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                ' Actualizar el usuario
                Dim query As String = "UPDATE clientes SET Nombre = @nombre, ApellidoP = @apellidop, ApellidoM = @apellidom, Direccion = @direccion, Telefono = @telefono, Comuna = @comuna WHERE Rut = @rut"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@rut", rut)
                    command.Parameters.AddWithValue("@nombre", nombre)
                    command.Parameters.AddWithValue("@apellidop", apellidop)
                    command.Parameters.AddWithValue("@apellidom", apellidom)
                    command.Parameters.AddWithValue("@direccion", dirección)
                    command.Parameters.AddWithValue("@telefono", telefono)
                    command.Parameters.AddWithValue("@comuna", comuna)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Cliente actualizado exitosamente.")
                    Else
                        MessageBox.Show("No se encontró un cliente con ese RUT para actualizar.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al actualizar el cliente: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim rut As String = txtRut.Text

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Verificar si el usuario existe antes de eliminar
                Dim checkQuery As String = "SELECT COUNT(*) FROM Clientes WHERE Rut = @rut"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@rut", rut)
                    Dim userExists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If userExists = 0 Then
                        MessageBox.Show("Error: No se encontró un cliente con ese RUT para eliminar.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                ' Eliminar el usuario
                Dim query As String = "DELETE FROM Clientes WHERE Rut = @rut"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@rut", rut)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Cliente eliminado exitosamente.")
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se encontró un cliente con ese RUT para eliminar.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al eliminar el cliente: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
    Private Sub btnVerDatosBD_Click(sender As Object, e As EventArgs) Handles btnVerDatosBD.Click
        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"
        Dim clientesInfo As New StringBuilder()

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna FROM clientes"
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                clientesInfo.AppendLine($"Rut: {reader("Rut")}, Nombre: {reader("Nombre")}, Apellido Paterno: {reader("ApellidoP")}, Apellido Materno: {reader("ApellidoM")}, Direccion: {reader("Direccion")}, Telefono: {reader("Telefono")}, Comuna: {reader("Comuna")}")
                            End While
                        Else
                            MostrarMensaje("No se encontraron clientes en la base de datos.")
                            Return
                        End If
                    End Using
                Catch ex As MySqlException
                    MostrarMensaje("Error al recuperar los clientes: " & ex.Message)
                    Return
                End Try
            End Using
        End Using

        MessageBox.Show(clientesInfo.ToString(), "Lista de Clientes")
    End Sub

    Private Sub MostrarMensaje(v As String)
        Throw New NotImplementedException()
    End Sub
End Class
