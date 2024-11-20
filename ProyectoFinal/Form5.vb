Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form5
    ' Constructor de la clase
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        CargarVentasRepuestos() ' Cargar los repuestos al iniciar
    End Sub

    ' Evento que se dispara al cargar el formulario
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbNombreRepuesto.Select() ' Seleccionar el ComboBox
    End Sub

    ' Método para limpiar los campos del formulario
    Private Sub LimpiarCampos()
        txtCliente.Clear()
        txtCantVendida.Clear()
        txtTotal.Clear()
        cmbNombreRepuesto.SelectedIndex = -1
    End Sub

    Private Sub btnRegistrarVenta_Click(sender As Object, e As EventArgs) Handles btnRegistrarVenta.Click
        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"

        ' Verificar si hay campos vacíos
        Dim camposVacios As New List(Of String)

        If cmbNombreRepuesto.SelectedIndex = -1 Then
            camposVacios.Add("Nombre de Repuesto")
        End If

        If String.IsNullOrEmpty(txtCliente.Text) Then
            camposVacios.Add("Cliente")
        End If

        If String.IsNullOrEmpty(txtCantVendida.Text) Then
            camposVacios.Add("Cantidad Vendida")
        End If

        If String.IsNullOrEmpty(txtTotal.Text) Then
            camposVacios.Add("Total")
        End If

        ' Mostrar mensaje si hay campos vacíos
        If camposVacios.Count > 0 Then
            MessageBox.Show("Los siguientes campos son obligatorios: " & String.Join(", ", camposVacios), "Error")
            Return
        End If

        ' Verificar si el RUT del cliente existe en la base de datos
        Dim rutCliente As String = txtCliente.Text
        Dim clienteExiste As Boolean = False

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM clientes WHERE RUT = @RUT"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@RUT", rutCliente)

                Try
                    connection.Open()
                    clienteExiste = Convert.ToInt32(command.ExecuteScalar()) > 0
                Catch ex As MySqlException
                    MessageBox.Show("Error al verificar el cliente en la base de datos: " & ex.Message, "Error")
                    Return
                End Try
            End Using
        End Using

        If Not clienteExiste Then
            Dim resultado As DialogResult = MessageBox.Show("El RUT ingresado no existe en la base de datos. ¿Desea agregar un nuevo cliente?", "Cliente no encontrado", MessageBoxButtons.YesNo)

            If resultado = DialogResult.Yes Then
                ' Crear instancia de Form6 y pasar el RUT
                Dim form6 As New Form6()
                form6.RutCliente = txtCliente.Text ' Pasar el RUT al Form6
                txtCliente.Clear() ' Limpiar el campo de RUT en Form5

                form6.Show() ' Mostrar Form6 para agregar el nuevo cliente
                Return ' Salir de la función sin registrar la venta
            End If
        End If

        ' Continuar con el registro de la venta
        Dim stockDisponible As Integer
        Dim precioUnitario As Decimal
        Dim total As Decimal

        ' Obtener datos del repuesto
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT CantidadStock, PrecioUnitario FROM repuestos WHERE NombreRepuesto = @NombreRepuesto"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@NombreRepuesto", cmbNombreRepuesto.SelectedItem.ToString())
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            stockDisponible = Convert.ToInt32(reader("CantidadStock"))
                            precioUnitario = Convert.ToDecimal(reader("PrecioUnitario"))
                        Else
                            MessageBox.Show("Repuesto no encontrado.", "Error")
                            Return
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error al acceder a la base de datos: " & ex.Message, "Error")
                    Return
                End Try
            End Using
        End Using

        ' Validar stock
        Dim cantidadVendida As Integer
        If Not Integer.TryParse(txtCantVendida.Text, cantidadVendida) Then
            MessageBox.Show("La cantidad vendida debe ser un número válido.", "Error")
            Return
        End If

        If cantidadVendida > stockDisponible Then
            MessageBox.Show("Stock insuficiente. Hay " & stockDisponible & " unidades disponibles.", "Error")
            Return
        End If

        ' Calcular total
        total = cantidadVendida * precioUnitario
        txtTotal.Text = total.ToString("0.00") ' Mostrar el total sin símbolo de moneda

        ' Registrar la venta
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO ventasrepuestos (NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total) VALUES (@NombreRepuesto, @CantidadVendida, @Cliente, @FechaVenta, @Total)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@NombreRepuesto", cmbNombreRepuesto.SelectedItem.ToString())
                command.Parameters.AddWithValue("@CantidadVendida", cantidadVendida)
                command.Parameters.AddWithValue("@Cliente", txtCliente.Text)
                ' Almacenar solo la fecha sin la hora en el campo FechaVenta
                command.Parameters.AddWithValue("@FechaVenta", dtFechaVenta.Value.Date)
                command.Parameters.AddWithValue("@Total", total) ' Vincular el total calculado

                Try
                    connection.Open()
                    command.ExecuteNonQuery() ' Ejecutar la inserción
                    MessageBox.Show("Venta registrada correctamente.", "Éxito")

                    ' Actualizar el stock
                    ActualizarStockRepuesto(cmbNombreRepuesto.SelectedItem.ToString(), stockDisponible - cantidadVendida)
                    LimpiarCampos() ' Limpiar campos después de registrar
                Catch ex As MySqlException
                    MessageBox.Show("Error al registrar la venta: " & ex.Message, "Error")
                End Try
            End Using
        End Using
    End Sub

    ' Método para actualizar el stock del repuesto
    Private Sub ActualizarStockRepuesto(nombreRepuesto As String, nuevoStock As Integer)
        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE repuestos SET CantidadStock = @NuevoStock WHERE NombreRepuesto = @NombreRepuesto"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@NuevoStock", nuevoStock)
                command.Parameters.AddWithValue("@NombreRepuesto", nombreRepuesto)

                Try
                    connection.Open()
                    command.ExecuteNonQuery() ' Ejecutar la actualización
                Catch ex As MySqlException
                    MessageBox.Show("Error al actualizar el stock: " & ex.Message, "Error")
                End Try
            End Using
        End Using
    End Sub

    ' Método para cargar los nombres de los repuestos
    Private Sub CargarVentasRepuestos()
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
                    MessageBox.Show("Error al cargar los nombres de repuestos: " & ex.Message, "Error")
                End Try
            End Using
        End Using
    End Sub

    ' Evento para cargar el precio unitario al seleccionar un repuesto
    Private Sub cmbNombreRepuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombreRepuesto.SelectedIndexChanged
        ' Verificar que se haya seleccionado un repuesto
        If cmbNombreRepuesto.SelectedIndex <> -1 Then
            Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"
            Dim precioUnitario As Decimal

            ' Consultar el precio del repuesto seleccionado
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "SELECT PrecioUnitario FROM repuestos WHERE NombreRepuesto = @NombreRepuesto"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NombreRepuesto", cmbNombreRepuesto.SelectedItem.ToString())
                    Try
                        connection.Open()
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                ' Obtener el precio unitario y mostrarlo en el TextBox de total
                                precioUnitario = Convert.ToDecimal(reader("PrecioUnitario"))
                                txtTotal.Text = precioUnitario.ToString("0.00") ' Formato con dos decimales
                            Else
                                MessageBox.Show("No se encontró el repuesto seleccionado.", "Error")
                            End If
                        End Using
                    Catch ex As MySqlException
                        MessageBox.Show("Error al obtener el precio: " & ex.Message, "Error")
                    End Try
                End Using
            End Using
        End If
    End Sub

    ' Evento para actualizar el total cuando cambia la cantidad vendida
    Private Sub txtCantVendida_TextChanged(sender As Object, e As EventArgs) Handles txtCantVendida.TextChanged
        Dim cantidadVendida As Integer
        Dim precioUnitario As Decimal

        ' Verifica si la cantidad ingresada es válida y si el precio unitario ya fue obtenido
        If Integer.TryParse(txtCantVendida.Text, cantidadVendida) AndAlso Decimal.TryParse(txtTotal.Text, precioUnitario) Then
            ' Calcula el total en función de la cantidad ingresada y el precio unitario
            Dim total As Decimal = cantidadVendida * precioUnitario
            txtTotal.Text = total.ToString("0.00") ' Actualiza el total con dos decimales
        Else
            ' Si la cantidad no es un número válido, limpiar el total
            txtTotal.Clear()
        End If
    End Sub

    ' Evento para volver al formulario de repuestos
    Private Sub btnRepuestos_Click(sender As Object, e As EventArgs) Handles btnRepuestos.Click
        Form4.Show()
        Me.Hide() ' Ocultar formulario actual
    End Sub

    ' Evento para volver al menú principal
    Private Sub btnVolverMenu_Click(sender As Object, e As EventArgs) Handles btnVolverMenu.Click
        Form2.Show()
        Me.Hide() ' Ocultar formulario actual
    End Sub

    ' Evento para limpiar los campos del formulario excepto el campo de fecha
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        ' Limpiar los campos de texto y ComboBox sin afectar la fecha
        txtCliente.Clear()
        txtCantVendida.Clear()
        txtTotal.Clear()
        cmbNombreRepuesto.SelectedIndex = -1
    End Sub

    ' Evento para ver el resumen de ventas filtrado por fecha
    Private Sub btnVerResumenVentasBD_Click(sender As Object, e As EventArgs) Handles btnVerResumenVentasBD.Click
        Dim connectionString As String = "server=localhost;port=3307;userid=root;password=;database=taller;"
        Dim fechaVenta As Date = dtFechaVenta.Value.Date

        Using connection As New MySqlConnection(connectionString)
            ' Consulta para obtener ventas filtradas por fecha
            Dim query As String = "SELECT * FROM ventasrepuestos WHERE FechaVenta = @FechaVenta"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@FechaVenta", fechaVenta)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim ventasResumen As New StringBuilder()

                        ' Construye el resumen de ventas
                        If reader.HasRows Then
                            While reader.Read()
                                ventasResumen.AppendLine("Venta ID: " & reader("VentaID").ToString())
                                ventasResumen.AppendLine("Repuesto: " & reader("NombreRepuesto").ToString())
                                ventasResumen.AppendLine("Cantidad Vendida: " & reader("CantidadVendida").ToString())
                                ventasResumen.AppendLine("Cliente: " & reader("Cliente").ToString())
                                ventasResumen.AppendLine("Fecha: " & Convert.ToDateTime(reader("FechaVenta")).ToString("dd/MM/yyyy"))
                                ventasResumen.AppendLine("Total: $" & Convert.ToDecimal(reader("Total")).ToString("0.00"))
                                ventasResumen.AppendLine("-----")
                            End While
                            MessageBox.Show(ventasResumen.ToString(), "Resumen de Ventas")
                        Else
                            MessageBox.Show("No hay ventas registradas en la fecha seleccionada.", "Resumen de Ventas")
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error al acceder a la base de datos: " & ex.Message, "Error")
                End Try
            End Using
        End Using
    End Sub
End Class
