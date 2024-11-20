Imports MySql.Data.MySqlClient

Public Class Form8
    ' Variables de conexión
    Private connection As MySqlConnection
    Private connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

    ' Cargar Rut de clientes en el ComboBox
    Private Sub CargarClientes()
        Try
            ' Establecer la conexión a la base de datos
            connection = New MySqlConnection(connectionString)

            ' Consulta para obtener los Ruts de los clientes
            Dim query As String = "SELECT Rut FROM clientes"
            Dim command As New MySqlCommand(query, connection)
            connection.Open()

            ' Ejecutar la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Limpiar el ComboBox si lo necesitas
            ' cmbRutCliente.Items.Clear()

            ' Aquí, en vez de agregar a un ComboBox, lo vamos a cargar en un TextBox al seleccionar
            If reader.Read() Then
                ' Asignamos el primer Rut encontrado en el TextBox txtRutCliente
                txtRutCliente.Text = reader("Rut").ToString()
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar la conexión si está abierta
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Método para abrir la conexión a la base de datos
    Private Sub AbrirConexion()
        If connection Is Nothing Then
            connection = New MySqlConnection(connectionString)
        End If
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    ' Método para cerrar la conexión a la base de datos
    Private Sub CerrarConexion()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    ' Cargar Rut de empleados en el ComboBox
    Private Sub CargarEmpleados()
        Try
            connection = New MySqlConnection(connectionString)
            Dim query As String = "SELECT Rut FROM empleados"
            Dim command As New MySqlCommand(query, connection)
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            cmbRutEmpleado.Items.Clear()
            While reader.Read()
                cmbRutEmpleado.Items.Add(reader("Rut").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar empleados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Cargar SiniestroID en el ComboBox (para usar en actualización y eliminación)
    Private Sub CargarSiniestroIDs()
        Try
            connection = New MySqlConnection(connectionString)
            Dim query As String = "SELECT SiniestroID FROM siniestro"
            Dim command As New MySqlCommand(query, connection)
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            cmbSiniestroID.Items.Clear()
            While reader.Read()
                cmbSiniestroID.Items.Add(reader("SiniestroID").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar SiniestroIDs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Registrar una nueva solicitud de servicio
    Private Sub RegistrarSolicitud()
        Try
            ' Verificar si los campos obligatorios están completos
            If String.IsNullOrEmpty(txtRutCliente.Text) OrElse String.IsNullOrEmpty(txtDescripcionProblema.Text) OrElse
           String.IsNullOrEmpty(cmbEstado.Text) OrElse String.IsNullOrEmpty(cmbSiniestroID.Text) OrElse
           String.IsNullOrEmpty(cmbRutEmpleado.Text) Then
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            connection = New MySqlConnection(connectionString)

            ' Insertar sin necesidad de SolicitudID, ya que es auto-incremental
            Dim query As String = "INSERT INTO solicitudesservicio (Rut, FechaSolicitud, DescripcionProblema, Estado, SiniestroID, RutEmpleado) " &
                              "VALUES (@Rut, @FechaSolicitud, @DescripcionProblema, @Estado, @SiniestroID, @RutEmpleado)"
            Dim command As New MySqlCommand(query, connection)

            ' Usar el valor seleccionado del ComboBox para SiniestroID y RutEmpleado
            command.Parameters.AddWithValue("@Rut", txtRutCliente.Text)
            command.Parameters.AddWithValue("@FechaSolicitud", dtFechaSolicitud.Value)
            command.Parameters.AddWithValue("@DescripcionProblema", txtDescripcionProblema.Text)
            command.Parameters.AddWithValue("@Estado", cmbEstado.Text)
            command.Parameters.AddWithValue("@SiniestroID", cmbSiniestroID.SelectedValue) ' Asegúrate de que cmbSiniestroID tenga el valor correcto
            command.Parameters.AddWithValue("@RutEmpleado", cmbRutEmpleado.SelectedValue) ' Asegúrate de que cmbRutEmpleado tenga el valor correcto

            connection.Open()
            command.ExecuteNonQuery()

            MessageBox.Show("Solicitud registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Llamar a la función que recarga los datos en el DataGridView
            CargarSolicitudes()

        Catch ex As Exception
            MessageBox.Show("Error al registrar la solicitud: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub



    ' Actualizar el estado de una solicitud
    Private Sub ActualizarEstadoSolicitud()
        Try
            connection = New MySqlConnection(connectionString)
            ' Actualizamos solo el Estado
            Dim query As String = "UPDATE solicitudesservicio SET Estado = @Estado WHERE SiniestroID = @SiniestroID"
            Dim command As New MySqlCommand(query, connection)

            command.Parameters.AddWithValue("@Estado", cmbEstado.Text)
            command.Parameters.AddWithValue("@SiniestroID", cmbSiniestroID.Text)

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Estado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se encontró la solicitud con el SiniestroID proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el estado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub EliminarSolicitud()
        Try
            ' Verificar si se ha seleccionado una fila en el DataGridView
            If dgvSolicitudes.SelectedRows.Count > 0 Then
                ' Obtener el SiniestroID de la fila seleccionada
                Dim SiniestroID As Integer = Convert.ToInt32(dgvSolicitudes.SelectedRows(0).Cells("SiniestroID").Value)

                connection = New MySqlConnection(connectionString)
                ' Eliminar la solicitud por SiniestroID
                Dim query As String = "DELETE FROM solicitudesservicio WHERE SiniestroID = @SiniestroID"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@SiniestroID", SiniestroID)

                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Solicitud eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Actualizar el DataGridView después de eliminar
                    CargarSolicitudes() ' Asegúrate de que esta función esté implementada para cargar las solicitudes
                Else
                    MessageBox.Show("No se encontró la solicitud con el SiniestroID proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Por favor, seleccione una solicitud para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar la solicitud: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Evento de clic del botón Registrar
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrarSolicitud.Click
        RegistrarSolicitud()
    End Sub

    ' Evento de clic del botón Actualizar Estado
    Private Sub btnActualizarEstado_Click(sender As Object, e As EventArgs) Handles BtnActualizarEstado.Click
        ' Verifica si se ha seleccionado una fila en el DataGridView
        If dgvSolicitudes.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione una solicitud para actualizar.")
            Return
        End If

        ' Verifica si se ha seleccionado un estado en el ComboBox
        If cmbFiltroEstado.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un estado para la solicitud.")
            Return
        End If

        ' Obtiene la SolicitudID de la fila seleccionada en el DataGridView
        Dim solicitudID As Integer = Convert.ToInt32(dgvSolicitudes.SelectedRows(0).Cells("SolicitudID").Value)

        ' Muestra una advertencia antes de hacer la actualización
        Dim estadoSeleccionado As String = cmbFiltroEstado.SelectedItem.ToString()
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea actualizar el estado de la solicitud a " & estadoSeleccionado & "?", "Confirmación", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                ' Abre la conexión a la base de datos
                AbrirConexion()

                ' Query para actualizar el estado de la solicitud
                Dim query As String = "UPDATE solicitudesservicio SET Estado = @Estado WHERE SolicitudID = @SolicitudID"

                Using cmd As New MySqlCommand(query, connection)
                    ' Utiliza el nombre correcto del parámetro
                    cmd.Parameters.AddWithValue("@Estado", estadoSeleccionado) ' Estado seleccionado en el ComboBox
                    cmd.Parameters.AddWithValue("@SolicitudID", solicitudID) ' ID de la solicitud a actualizar

                    ' Ejecuta la actualización
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Estado de la solicitud actualizada exitosamente.")

                    ' Refresca el DataGridView después de la actualización
                    CargarSolicitudes() ' Llama a tu función para recargar las solicitudes en el DataGridView
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el estado de la solicitud: " & ex.Message)
            Finally
                CerrarConexion()
            End Try
        End If
    End Sub

    ' Evento de clic del botón Eliminar
    Private Sub btnEliminarSolicitud_Click(sender As Object, e As EventArgs) Handles btnEliminarSolicitud.Click
        ' Verifica si se ha seleccionado alguna fila en el DataGridView
        If dgvSolicitudes.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione una solicitud para eliminar.")
            Return
        End If

        ' Obtiene la solicitudID de la fila seleccionada en el DataGridView
        Dim solicitudID As Integer

        Try
            ' Verifica que la celda no esté vacía o nula
            If dgvSolicitudes.SelectedRows(0).Cells("SolicitudID").Value IsNot DBNull.Value Then
                ' Intenta convertir el valor de la celda en un Integer
                solicitudID = Convert.ToInt32(dgvSolicitudes.SelectedRows(0).Cells("SolicitudID").Value)
            Else
                MessageBox.Show("La solicitud está vacía o no es válidoa.")
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener el SolicitudID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Muestra una advertencia antes de hacer la eliminación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta solicitud?", "Confirmación", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                ' Abre la conexión a la base de datos
                AbrirConexion()

                ' Query para eliminar la solicitud de la tabla
                Dim query As String = "DELETE FROM solicitudesservicio WHERE SolicitudID = @SolicitudID"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@SolicitudID", solicitudID) ' ID de la solicitud a eliminar

                    ' Ejecuta la eliminación
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Solicitud eliminada exitosamente.")

                    ' Refresca el DataGridView después de la eliminación
                    CargarSolicitudes() ' Llama a tu función para recargar las solicitudes en el DataGridView
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la solicitud: " & ex.Message)
            Finally
                CerrarConexion()
            End Try
        End If
    End Sub


    ' Evento de clic del botón Filtrar Estado
    Private Sub btnFiltrarEstado_Click(sender As Object, e As EventArgs) Handles btnFiltrarEstado.Click
        ' Verificar si se ha seleccionado un estado
        If cmbFiltroEstado.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un estado para filtrar.")
            Return
        End If

        Try
            AbrirConexion()

            ' Consulta para obtener los siniestros filtrados por estado
            Dim query As String = "SELECT SolicitudID, DescripcionProblema, Rut, FechaSolicitud, Estado, RutEmpleado " &
                              "FROM solicitudesservicio WHERE Estado = @Estado"

            Using command As New MySqlCommand(query, connection)
                ' Agregar el valor del estado seleccionado en el ComboBox al parámetro de la consulta
                command.Parameters.AddWithValue("@Estado", cmbFiltroEstado.SelectedItem.ToString())

                ' Ejecutar la consulta
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Verificar si hay resultados y asignarlos al DataGridView
                If table.Rows.Count > 0 Then
                    dgvSolicitudes.DataSource = table
                Else
                    MessageBox.Show("No se encontraron siniestros para el estado seleccionado.")
                    dgvSolicitudes.DataSource = Nothing
                End If

                ' Ajustes de visualización
                dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvSolicitudes.ReadOnly = False
                dgvSolicitudes.RowHeadersVisible = True
                dgvSolicitudes.AllowUserToAddRows = False
                dgvSolicitudes.BackgroundColor = Color.White
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al filtrar las solicitudes por estado: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub


    ' Evento de carga del formulario
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
        CargarEmpleados()
        CargarSiniestroIDs()
        ' Cargar los datos al iniciar el formulario
        CargarSolicitudes()
        ' Limpiar los campos al cargar el formulario
        txtRutCliente.Clear()
        txtDescripcionProblema.Clear()
        dtFechaSolicitud.Value = DateTime.Now  ' O la fecha que prefieras establecer
    End Sub

    ' Evento para manejar la selección del SiniestroID en el ComboBox
    Private Sub cmbSiniestroID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSiniestroID.SelectedIndexChanged
        ' Limpiar el campo txtRutCliente cada vez que se cambie la selección del ComboBox
        txtRutCliente.Clear()
        txtDescripcionProblema.Clear()  ' Limpiar también la descripción
        dtFechaSolicitud.Value = DateTime.Now  ' Resetear la fecha si lo deseas
    End Sub


    Private Sub CargarSolicitudes()
        Try
            ' Abrir la conexión con la base de datos
            connection = New MySqlConnection(connectionString)
            connection.Open()

            ' Consulta para obtener las solicitudes
            Dim query As String = "SELECT SolicitudID, Rut, FechaSolicitud, DescripcionProblema, Estado, SiniestroID, RutEmpleado FROM solicitudesservicio"
            Dim command As New MySqlCommand(query, connection)

            ' Llenar el DataGridView con los datos obtenidos
            Dim adapter As New MySqlDataAdapter(command)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvSolicitudes.DataSource = dt ' Actualiza el DataGridView con los datos

        Catch ex As Exception
            MessageBox.Show("Error al cargar las solicitudes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar la conexión después de cargar los datos
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub



    ' Evento para el botón de búsqueda de siniestro
    Private Sub btnBuscarSiniestro_Click(sender As Object, e As EventArgs) Handles btnBuscarSiniestro.Click
        Try
            ' Verificar que haya un siniestro seleccionado en el ComboBox
            If cmbSiniestroID.SelectedIndex <> -1 Then
                ' Obtener el SiniestroID seleccionado
                Dim siniestroID As Integer = Convert.ToInt32(cmbSiniestroID.SelectedItem)

                ' Conectar a la base de datos
                connection = New MySqlConnection(connectionString)
                connection.Open()

                ' Consulta SQL para obtener los datos del siniestro
                Dim query As String = "SELECT Rut, Detalle, Fecha_Siniestro FROM siniestro WHERE SiniestroID = @SiniestroID"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@SiniestroID", siniestroID)

                ' Ejecutar la consulta
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Si se encuentra el siniestro, cargar los datos en los controles
                    txtRutCliente.Text = reader("Rut").ToString() ' Rut del cliente
                    txtDescripcionProblema.Text = reader("Detalle").ToString() ' Descripción del problema
                    dtFechaSolicitud.Value = Convert.ToDateTime(reader("Fecha_Siniestro")) ' Fecha del siniestro
                Else
                    MessageBox.Show("Siniestro no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ' Cerrar el reader y la conexión
                reader.Close()
            Else
                MessageBox.Show("Por favor seleccione un SiniestroID", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar el siniestro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub BtnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCampos.Click
        ' Limpiar los TextBox
        txtRutCliente.Clear()
        txtDescripcionProblema.Clear()

        ' Limpiar los ComboBox
        cmbEstado.SelectedIndex = -1
        cmbSiniestroID.SelectedIndex = -1
        cmbRutEmpleado.SelectedIndex = -1
        cmbFiltroEstado.SelectedIndex = -1

        ' Resetear el DateTimePicker a la fecha actual
        dtFechaSolicitud.Value = DateTime.Now

        ' Si hay algún otro control que desees limpiar o resetear, agrégalo aquí
        ' Ejemplo: Limpiar un DataGridView
        dgvSolicitudes.DataSource = Nothing  ' Si es necesario limpiar el DataGridView

        ' Opcionalmente, también puedes restablecer otros controles a sus valores predeterminados si lo deseas
    End Sub

    Private Sub BtnVolverMenu_Click(sender As Object, e As EventArgs) Handles BtnVolverMenu.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Close()
    End Sub

End Class
