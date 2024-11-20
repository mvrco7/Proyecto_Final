Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form4
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        txtID.ReadOnly = True ' Hacer el TextBox ID de solo lectura
        CargarNombresRepuestos() ' Cargar repuestos al iniciar
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Select()
        cmbNombreRepuesto.Text = "Seleccione un repuesto"
        cmbNombreRepuesto.ForeColor = Color.DarkGray
    End Sub

    Private Sub cmbNombreRepuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombreRepuesto.SelectedIndexChanged
        If cmbNombreRepuesto.SelectedItem IsNot Nothing Then
            txtNombre.Text = cmbNombreRepuesto.SelectedItem.ToString()
            cmbNombreRepuesto.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnVolverMenu_Click(sender As Object, e As EventArgs) Handles btnVolverMenu.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Close()
    End Sub

    Private Sub btnCrearRepuesto_Click(sender As Object, e As EventArgs) Handles btnCrearRepuesto.Click
        If Not ValidarCampos() Then Return

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        If RepuestoExiste(txtNombre.Text) Then
            MostrarMensaje("El repuesto ya existe en la base de datos. No se puede agregar.")
            Return
        End If

        Dim nuevoID As Integer = ObtenerSiguienteID()

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO repuestos (RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) VALUES (@ID, @Nombre, @Stock, @Precio, @Proveedor)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", nuevoID)
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@Stock", txtStock.Text)
                command.Parameters.AddWithValue("@Precio", txtPrecioUnitario.Text)
                command.Parameters.AddWithValue("@Proveedor", txtProveedor.Text)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MostrarMensaje("Repuesto creado exitosamente.")
                    CargarNombresRepuestos()
                    LimpiarCampos()
                Catch ex As MySqlException
                    MostrarMensaje("Error al crear el repuesto: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnActualizarRepuesto_Click(sender As Object, e As EventArgs) Handles btnActualizarRepuesto.Click
        If String.IsNullOrWhiteSpace(txtID.Text) AndAlso String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MostrarMensaje("Es obligatorio buscar el repuesto antes de actualizarlo.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse cmbNombreRepuesto.SelectedIndex = -1 Then
            MostrarMensaje("Es obligatorio seleccionar un repuesto para actualizarlo.")
            Return
        End If

        If Not ValidarCampos(True) Then Return

        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea actualizar este repuesto?", "Confirmar Actualización", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then Return

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE repuestos SET NombreRepuesto = @Nombre, CantidadStock = @Stock, PrecioUnitario = @Precio, Proveedor = @Proveedor WHERE RepuestoID = @ID"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", txtID.Text)
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@Stock", txtStock.Text)
                command.Parameters.AddWithValue("@Precio", txtPrecioUnitario.Text)
                command.Parameters.AddWithValue("@Proveedor", txtProveedor.Text)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MostrarMensaje("Repuesto actualizado exitosamente.")
                        CargarNombresRepuestos()
                        LimpiarCampos()
                    Else
                        MostrarMensaje("No se encontró ningún repuesto para actualizar.")
                    End If
                Catch ex As MySqlException
                    MostrarMensaje("Error al actualizar el repuesto: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub btnEliminarRepuesto_Click(sender As Object, e As EventArgs) Handles btnEliminarRepuesto.Click
        ' Verificar si se ha seleccionado un repuesto en el ComboBox
        If cmbNombreRepuesto.SelectedIndex = -1 Then
            MostrarMensaje("Por favor, seleccione un repuesto para eliminar.")
            Return
        End If

        ' Verificar que el campo Nombre no esté vacío
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MostrarMensaje("El campo Nombre del repuesto es obligatorio para eliminar un repuesto.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el repuesto '" & txtNombre.Text & "'?", "Confirmar Eliminación", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then Return

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "DELETE FROM repuestos WHERE NombreRepuesto = @Nombre"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MostrarMensaje("Repuesto '" & txtNombre.Text & "' eliminado exitosamente.")
                        CargarNombresRepuestos()
                        LimpiarCampos()
                    Else
                        MostrarMensaje("No se encontró ningún repuesto con ese nombre para eliminar.")
                    End If
                Catch ex As MySqlException
                    MostrarMensaje("Error al eliminar el repuesto: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub



    Private Sub btnBuscarRepuesto_Click(sender As Object, e As EventArgs) Handles btnBuscarRepuesto.Click
        Dim nombreRepuesto As String = cmbNombreRepuesto.Text

        If String.IsNullOrWhiteSpace(nombreRepuesto) Or nombreRepuesto = "Seleccione un repuesto" Then
            MostrarMensaje("Por favor, selecciona un repuesto para buscar.")
            Return
        End If

        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT RepuestoID, CantidadStock, PrecioUnitario, Proveedor FROM repuestos WHERE NombreRepuesto = @Nombre"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", nombreRepuesto)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                txtID.Text = reader("RepuestoID").ToString()
                                txtStock.Text = reader("CantidadStock").ToString()
                                txtPrecioUnitario.Text = reader("PrecioUnitario").ToString()
                                txtProveedor.Text = reader("Proveedor").ToString()
                            End While
                            MostrarMensaje("Repuesto encontrado.")
                        Else
                            MostrarMensaje("No se encontró un repuesto con ese nombre.")
                        End If
                    End Using
                Catch ex As MySqlException
                    MostrarMensaje("Error al buscar el repuesto: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnLimpiarDatos_Click(sender As Object, e As EventArgs) Handles btnLimpiarDatos.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtID.Clear()
        txtNombre.Clear()
        txtStock.Clear()
        txtPrecioUnitario.Clear()
        txtProveedor.Clear()
        cmbNombreRepuesto.SelectedIndex = -1
    End Sub

    Private Function RepuestoExiste(nombre As String) As Boolean
        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"
        Dim existe As Boolean = False

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM repuestos WHERE NombreRepuesto = @Nombre"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", nombre)

                Try
                    connection.Open()
                    existe = Convert.ToInt32(command.ExecuteScalar()) > 0
                Catch ex As MySqlException
                    MostrarMensaje("Error al verificar la existencia del repuesto: " & ex.Message)
                End Try
            End Using
        End Using

        Return existe
    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"
        Dim maxID As Integer = 0

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT IFNULL(MAX(RepuestoID), 0) + 1 FROM repuestos"
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    maxID = Convert.ToInt32(command.ExecuteScalar())
                Catch ex As MySqlException
                    MostrarMensaje("Error al obtener el siguiente ID: " & ex.Message)
                End Try
            End Using
        End Using

        Return maxID
    End Function

    Private Function ValidarCampos(Optional esActualizacion As Boolean = False) As Boolean
        Dim camposValidos As Boolean = True
        Dim mensaje As String = "Por favor complete los siguientes campos obligatorios:" & Environment.NewLine

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            mensaje &= "- Nombre" & Environment.NewLine
            camposValidos = False
        End If
        If String.IsNullOrWhiteSpace(txtStock.Text) Then
            mensaje &= "- Stock" & Environment.NewLine
            camposValidos = False
        End If
        If String.IsNullOrWhiteSpace(txtPrecioUnitario.Text) Then
            mensaje &= "- Precio Unitario" & Environment.NewLine
            camposValidos = False
        End If
        If String.IsNullOrWhiteSpace(txtProveedor.Text) Then
            mensaje &= "- Proveedor" & Environment.NewLine
            camposValidos = False
        End If

        If Not camposValidos Then
            MostrarMensaje(mensaje)
        End If

        Return camposValidos
    End Function

    ' Evento GotFocus y LostFocus para el ComboBox
    Private Sub cmbCargo_GotFocus(sender As Object, e As EventArgs) Handles cmbNombreRepuesto.GotFocus
        If cmbNombreRepuesto.Text = "Seleccione un repuesto" Then
            cmbNombreRepuesto.Text = ""
            cmbNombreRepuesto.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbCargo_LostFocus(sender As Object, e As EventArgs) Handles cmbNombreRepuesto.LostFocus
        If cmbNombreRepuesto.Text = "" Then
            cmbNombreRepuesto.Text = "Seleccione un repuesto"
            cmbNombreRepuesto.ForeColor = Color.DarkGray
        Else
            cmbNombreRepuesto.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CargarNombresRepuestos()
        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"
        cmbNombreRepuesto.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT NombreRepuesto FROM repuestos"
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            cmbNombreRepuesto.Items.Add(reader("NombreRepuesto").ToString())
                        End While
                    End Using
                Catch ex As MySqlException
                    MostrarMensaje("Error al cargar los nombres de repuestos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnVerRepuestosBD_Click(sender As Object, e As EventArgs) Handles btnVerRepuestosBD.Click
        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"
        Dim repuestosInfo As New StringBuilder()

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor FROM repuestos"
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                repuestosInfo.AppendLine($"ID: {reader("RepuestoID")}, Nombre: {reader("NombreRepuesto")}, Stock: {reader("CantidadStock")}, Precio: {reader("PrecioUnitario")}, Proveedor: {reader("Proveedor")}")
                            End While
                        Else
                            MostrarMensaje("No se encontraron repuestos en la base de datos.")
                            Return
                        End If
                    End Using
                Catch ex As MySqlException
                    MostrarMensaje("Error al recuperar los repuestos: " & ex.Message)
                    Return
                End Try
            End Using
        End Using

        MessageBox.Show(repuestosInfo.ToString(), "Lista de Repuestos")
    End Sub

    Private Sub MostrarMensaje(mensaje As String)
        MessageBox.Show(mensaje)
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub
End Class
