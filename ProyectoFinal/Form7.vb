Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form7
    ' Variables de conexión
    Private connection As MySqlConnection
    Private connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

    ' Evento de carga del formulario
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Puedes cargar los siniestros al iniciar el formulario si lo deseas descomentando la siguiente línea
        'CargarSiniestros()
        TxtRutCliente.Focus()
        CargarRutCompania()
    End Sub

    ' Constructor del formulario
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        connection = New MySqlConnection(connectionString)
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

    ' Botón para volver al menú
    Private Sub BtnVolverMenu_Click(sender As Object, e As EventArgs) Handles BtnVolverMenu.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Close()
    End Sub

    ' Evento del botón para cargar siniestros desde la base de datos
    Private Sub BtnVerSiniestroBD_Click(sender As Object, e As EventArgs) Handles BtnVerSiniestroBD.Click
        CargarSiniestros()
    End Sub

    ' Método para cargar siniestros en el DataGridView
    Private Sub CargarSiniestros()
        Try
            AbrirConexion()

            ' Consulta para seleccionar las columnas específicas de la tabla siniestro
            Dim query As String = "SELECT SiniestroID, Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro FROM siniestro"

            ' Crear comando y adaptador para llenar el DataTable
            Using command As New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                ' Llenar el DataTable con los resultados de la consulta
                adapter.Fill(table)

                ' Asignar el DataTable como fuente de datos del DataGridView
                dgvSiniestros.DataSource = table

                ' Ajustar las columnas para que se adapten al tamaño del DataGridView
                dgvSiniestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvSiniestros.ReadOnly = False
                dgvSiniestros.RowHeadersVisible = True
                dgvSiniestros.AllowUserToAddRows = False
                dgvSiniestros.BackgroundColor = Color.White
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los siniestros: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    ' Botón para registrar un nuevo siniestro
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrarSiniestro.Click
        If String.IsNullOrEmpty(TxtDetalleSiniestro.Text) OrElse String.IsNullOrEmpty(cmbRutCompania.Text) OrElse
           String.IsNullOrEmpty(TxtRutCliente.Text) OrElse CmbEstadoSiniestro.SelectedIndex = -1 OrElse
           CmbEstadoDelSeguro.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.")
            Return
        End If

        Try
            AbrirConexion()
            Dim query As String = "INSERT INTO siniestro (Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro) " &
                                  "VALUES (@Detalle, @Estado_Siniestro, @Fecha_Siniestro, @RutCompania, @Rut, @Estado_Seguro)"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Detalle", TxtDetalleSiniestro.Text)
                cmd.Parameters.AddWithValue("@Estado_Siniestro", CmbEstadoSiniestro.Text)
                cmd.Parameters.AddWithValue("@Fecha_Siniestro", DtFechaSiniestro.Value)
                cmd.Parameters.AddWithValue("@RutCompania", cmbRutCompania.Text)
                cmd.Parameters.AddWithValue("@Rut", TxtRutCliente.Text)
                cmd.Parameters.AddWithValue("@Estado_Seguro", CmbEstadoDelSeguro.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Siniestro registrado exitosamente.")
                CargarSiniestros() ' Refrescar la lista después de registrar
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al registrar siniestro: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    ' Botón para buscar un siniestro por fecha
    Private Sub BtnBuscarFechaSiniestro_Click(sender As Object, e As EventArgs)
        If DtFechaSiniestro.Value = Nothing Then
            MessageBox.Show("Por favor, seleccione una fecha para filtrar.")
            Return
        End If

        Try
            AbrirConexion()

            ' Consulta para obtener los siniestros filtrados por fecha
            Dim query As String = "SELECT SiniestroID, Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro " &
                              "FROM siniestro WHERE Fecha_Siniestro = @Fecha_Siniestro"

            Using command As New MySqlCommand(query, connection)
                ' Usamos el valor del DateTimePicker como parámetro
                command.Parameters.AddWithValue("@Fecha_Siniestro", DtFechaSiniestro.Value.Date)

                ' Ejecutar la consulta
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Verificar si hay resultados y asignarlos al DataGridView
                If table.Rows.Count > 0 Then
                    dgvSiniestros.DataSource = table
                Else
                    MessageBox.Show("No se encontraron siniestros para la fecha seleccionada.")
                    dgvSiniestros.DataSource = Nothing
                End If

                ' Ajustes de visualización
                dgvSiniestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvSiniestros.ReadOnly = False
                dgvSiniestros.RowHeadersVisible = True
                dgvSiniestros.AllowUserToAddRows = False
                dgvSiniestros.BackgroundColor = Color.White
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al filtrar siniestros por fecha: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    'Boton para actualizar el estado del siniestro
    Private Sub BtnActualizarEstadoSiniestro_Click(sender As Object, e As EventArgs) Handles BtnActualizarEstadoSiniestro.Click
        ' Verifica si se ha seleccionado una fila en el DataGridView
        If dgvSiniestros.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un siniestro para actualizar.")
            Return
        End If

        ' Verifica si se ha seleccionado un estado en el ComboBox
        If cmbEstadoSiniestroBD.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un estado para el siniestro.")
            Return
        End If

        ' Obtiene el SiniestroID de la fila seleccionada en el DataGridView
        Dim siniestroID As Integer = Convert.ToInt32(dgvSiniestros.SelectedRows(0).Cells("SiniestroID").Value)

        ' Muestra una advertencia antes de hacer la actualización
        Dim estadoSeleccionado As String = cmbEstadoSiniestroBD.SelectedItem.ToString()
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea actualizar el estado del siniestro a " & estadoSeleccionado & "?", "Confirmación", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                ' Abre la conexión a la base de datos
                AbrirConexion()

                ' Query para actualizar el estado del siniestro
                Dim query As String = "UPDATE siniestro SET Estado_Siniestro = @Estado_Siniestro WHERE SiniestroID = @SiniestroID"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Estado_Siniestro", estadoSeleccionado) ' Estado seleccionado en el ComboBox
                    cmd.Parameters.AddWithValue("@SiniestroID", siniestroID) ' ID del siniestro a actualizar

                    ' Ejecuta la actualización
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Estado del siniestro actualizado exitosamente.")

                    ' Refresca el DataGridView después de la actualización
                    CargarSiniestros() ' Llama a tu función para recargar los siniestros en el DataGridView
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al actualizar el estado del siniestro: " & ex.Message)
            Finally
                CerrarConexion()
            End Try
        End If
    End Sub



    ' Botón para filtrar siniestros por estado
    Private Sub BtnFiltrarEstado_Click(sender As Object, e As EventArgs) Handles btnFiltrarEstado.Click
        If cmbEstadoSiniestroBD.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un estado para filtrar.")
            Return
        End If

        Try
            AbrirConexion()

            ' Consulta para obtener los siniestros filtrados por estado
            Dim query As String = "SELECT SiniestroID, Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro " &
                                  "FROM siniestro WHERE Estado_Siniestro = @Estado_Siniestro"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Estado_Siniestro", cmbEstadoSiniestroBD.SelectedItem.ToString())

                ' Ejecutar la consulta
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Verificar si hay resultados y asignarlos al DataGridView
                If table.Rows.Count > 0 Then
                    dgvSiniestros.DataSource = table
                Else
                    MessageBox.Show("No se encontraron siniestros para el estado seleccionado.")
                    dgvSiniestros.DataSource = Nothing
                End If

                ' Ajustes de visualización
                dgvSiniestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvSiniestros.ReadOnly = False
                dgvSiniestros.RowHeadersVisible = True
                dgvSiniestros.AllowUserToAddRows = False
                dgvSiniestros.BackgroundColor = Color.White
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al filtrar siniestros por estado: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    ' Botón para filtrar siniestros por rut
    Private Sub BtnFiltrarRut_Click(sender As Object, e As EventArgs) Handles BtnFiltrarRut.Click
        If String.IsNullOrEmpty(TxtRutBD.Text) Then
            MessageBox.Show("Por favor, ingrese un RUT para filtrar.")
            Return
        End If

        Try
            AbrirConexion()

            ' Consulta para obtener los siniestros filtrados por RUT
            Dim query As String = "SELECT SiniestroID, Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro " &
                                  "FROM siniestro WHERE Rut = @Rut"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Rut", TxtRutBD.Text)

                ' Ejecutar la consulta
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Verificar si hay resultados y asignarlos al DataGridView
                If table.Rows.Count > 0 Then
                    dgvSiniestros.DataSource = table
                Else
                    MessageBox.Show("No se encontraron siniestros para el RUT ingresado.")
                    dgvSiniestros.DataSource = Nothing
                End If

                ' Ajustes de visualización
                dgvSiniestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvSiniestros.ReadOnly = False
                dgvSiniestros.RowHeadersVisible = True
                dgvSiniestros.AllowUserToAddRows = False
                dgvSiniestros.BackgroundColor = Color.White
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al filtrar siniestros por RUT: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    Private Sub BtnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCampos.Click
        ' Limpiar los TextBox
        TxtDetalleSiniestro.Text = String.Empty
        TxtRutCliente.Text = String.Empty
        cmbRutCompania.SelectedIndex = -1
        CmbEstadoSiniestro.SelectedIndex = -1
        CmbEstadoDelSeguro.SelectedIndex = -1
        TxtRutBD.Text = String.Empty
        cmbEstadoSiniestroBD.SelectedIndex = -1

        ' Limpiar el DataGridView
        dgvSiniestros.DataSource = Nothing

        ' No limpiar el DateTimePicker
        DtFechaSiniestro.Value = DateTime.Now ' Puedes dejarlo con la fecha actual o vaciarlo si prefieres
    End Sub

    Private Sub Form7_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Establecer el enfoque del cursor en el campo TxtRutCliente cuando el formulario se ha mostrado
        TxtRutCliente.Focus()
    End Sub

    Private Sub btnEliminarSiniestro_Click(sender As Object, e As EventArgs) Handles btnEliminarSiniestro.Click
        ' Verifica si se ha seleccionado una fila en el DataGridView
        If dgvSiniestros.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un siniestro para eliminar.")
            Return
        End If

        ' Obtiene el SiniestroID de la fila seleccionada en el DataGridView
        Dim siniestroID As Integer = Convert.ToInt32(dgvSiniestros.SelectedRows(0).Cells("SiniestroID").Value)

        ' Muestra una advertencia antes de hacer la eliminación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este siniestro?", "Confirmación", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                ' Abre la conexión a la base de datos
                AbrirConexion()

                ' Query para eliminar el siniestro de la tabla
                Dim query As String = "DELETE FROM siniestro WHERE SiniestroID = @SiniestroID"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@SiniestroID", siniestroID) ' ID del siniestro a eliminar

                    ' Ejecuta la eliminación
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Siniestro eliminado exitosamente.")

                    ' Refresca el DataGridView después de la eliminación
                    CargarSiniestros() ' Llama a tu función para recargar los siniestros en el DataGridView
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el siniestro: " & ex.Message)
            Finally
                CerrarConexion()
            End Try
        End If
    End Sub

    ' Método para cargar los RUT de la compañía en el ComboBox
    Private Sub CargarRutCompania()
        Try
            AbrirConexion()

            ' Consulta para obtener los RUT de las compañías
            Dim query As String = "SELECT DISTINCT RutCompania FROM siniestro" ' Ajusta el nombre de la tabla y columna si es necesario

            ' Crear comando y adaptador para llenar el ComboBox
            Using command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Limpia el ComboBox antes de agregar los datos
                cmbRutCompania.Items.Clear()

                ' Cargar cada RUT en el ComboBox
                While reader.Read()
                    cmbRutCompania.Items.Add(reader("RutCompania").ToString())
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los RUT de las compañías: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub
End Class
