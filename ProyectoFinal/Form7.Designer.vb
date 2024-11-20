<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.DtFechaSiniestro = New System.Windows.Forms.DateTimePicker()
        Me.CmbEstadoSiniestro = New System.Windows.Forms.ComboBox()
        Me.LblRutCompania = New System.Windows.Forms.Label()
        Me.LblDetalleSiniestro = New System.Windows.Forms.Label()
        Me.LblEstadoDelSiniestro = New System.Windows.Forms.Label()
        Me.LblFechaSiniestro = New System.Windows.Forms.Label()
        Me.LblRutCliente = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtDetalleSiniestro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLimpiarCampos = New System.Windows.Forms.Button()
        Me.BtnVolverMenu = New System.Windows.Forms.Button()
        Me.BtnVerSiniestroBD = New System.Windows.Forms.Button()
        Me.BtnActualizarEstadoSiniestro = New System.Windows.Forms.Button()
        Me.BtnRegistrarSiniestro = New System.Windows.Forms.Button()
        Me.TxtRutCliente = New System.Windows.Forms.TextBox()
        Me.LblEstadoDelSeguro = New System.Windows.Forms.Label()
        Me.CmbEstadoDelSeguro = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnFiltrarEstado = New System.Windows.Forms.Button()
        Me.cmbEstadoSiniestroBD = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnFiltrarRut = New System.Windows.Forms.Button()
        Me.LblFechaBD = New System.Windows.Forms.Label()
        Me.TxtRutBD = New System.Windows.Forms.TextBox()
        Me.LblRutBD = New System.Windows.Forms.Label()
        Me.dgvSiniestros = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbRutCompania = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnEliminarSiniestro = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtFechaSiniestro
        '
        Me.DtFechaSiniestro.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DtFechaSiniestro.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.DtFechaSiniestro.Location = New System.Drawing.Point(15, 286)
        Me.DtFechaSiniestro.Name = "DtFechaSiniestro"
        Me.DtFechaSiniestro.Size = New System.Drawing.Size(218, 20)
        Me.DtFechaSiniestro.TabIndex = 58
        '
        'CmbEstadoSiniestro
        '
        Me.CmbEstadoSiniestro.FormattingEnabled = True
        Me.CmbEstadoSiniestro.Items.AddRange(New Object() {"Activo", "Pendiente", "Finalizado"})
        Me.CmbEstadoSiniestro.Location = New System.Drawing.Point(15, 229)
        Me.CmbEstadoSiniestro.Name = "CmbEstadoSiniestro"
        Me.CmbEstadoSiniestro.Size = New System.Drawing.Size(218, 21)
        Me.CmbEstadoSiniestro.TabIndex = 57
        '
        'LblRutCompania
        '
        Me.LblRutCompania.AutoSize = True
        Me.LblRutCompania.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRutCompania.ForeColor = System.Drawing.Color.Black
        Me.LblRutCompania.Location = New System.Drawing.Point(11, 148)
        Me.LblRutCompania.Name = "LblRutCompania"
        Me.LblRutCompania.Size = New System.Drawing.Size(112, 21)
        Me.LblRutCompania.TabIndex = 54
        Me.LblRutCompania.Text = "Rut(Compañia)"
        '
        'LblDetalleSiniestro
        '
        Me.LblDetalleSiniestro.AutoSize = True
        Me.LblDetalleSiniestro.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDetalleSiniestro.ForeColor = System.Drawing.Color.Black
        Me.LblDetalleSiniestro.Location = New System.Drawing.Point(10, 12)
        Me.LblDetalleSiniestro.Name = "LblDetalleSiniestro"
        Me.LblDetalleSiniestro.Size = New System.Drawing.Size(138, 21)
        Me.LblDetalleSiniestro.TabIndex = 53
        Me.LblDetalleSiniestro.Text = "Detalle del siniestro"
        '
        'LblEstadoDelSiniestro
        '
        Me.LblEstadoDelSiniestro.AutoSize = True
        Me.LblEstadoDelSiniestro.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstadoDelSiniestro.ForeColor = System.Drawing.Color.Black
        Me.LblEstadoDelSiniestro.Location = New System.Drawing.Point(11, 205)
        Me.LblEstadoDelSiniestro.Name = "LblEstadoDelSiniestro"
        Me.LblEstadoDelSiniestro.Size = New System.Drawing.Size(137, 21)
        Me.LblEstadoDelSiniestro.TabIndex = 52
        Me.LblEstadoDelSiniestro.Text = "Estado del siniestro"
        '
        'LblFechaSiniestro
        '
        Me.LblFechaSiniestro.AutoSize = True
        Me.LblFechaSiniestro.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaSiniestro.ForeColor = System.Drawing.Color.Black
        Me.LblFechaSiniestro.Location = New System.Drawing.Point(11, 262)
        Me.LblFechaSiniestro.Name = "LblFechaSiniestro"
        Me.LblFechaSiniestro.Size = New System.Drawing.Size(131, 21)
        Me.LblFechaSiniestro.TabIndex = 51
        Me.LblFechaSiniestro.Text = "Fecha del siniestro"
        '
        'LblRutCliente
        '
        Me.LblRutCliente.AutoSize = True
        Me.LblRutCliente.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRutCliente.ForeColor = System.Drawing.Color.Black
        Me.LblRutCliente.Location = New System.Drawing.Point(11, 92)
        Me.LblRutCliente.Name = "LblRutCliente"
        Me.LblRutCliente.Size = New System.Drawing.Size(89, 21)
        Me.LblRutCliente.TabIndex = 50
        Me.LblRutCliente.Text = "Rut(Cliente)"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Fuchsia
        Me.Panel2.Location = New System.Drawing.Point(679, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 296)
        Me.Panel2.TabIndex = 49
        '
        'TxtDetalleSiniestro
        '
        Me.TxtDetalleSiniestro.Location = New System.Drawing.Point(15, 36)
        Me.TxtDetalleSiniestro.Multiline = True
        Me.TxtDetalleSiniestro.Name = "TxtDetalleSiniestro"
        Me.TxtDetalleSiniestro.Size = New System.Drawing.Size(218, 44)
        Me.TxtDetalleSiniestro.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Siniestros"
        '
        'BtnLimpiarCampos
        '
        Me.BtnLimpiarCampos.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnLimpiarCampos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarCampos.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiarCampos.Location = New System.Drawing.Point(288, 453)
        Me.BtnLimpiarCampos.Name = "BtnLimpiarCampos"
        Me.BtnLimpiarCampos.Size = New System.Drawing.Size(152, 51)
        Me.BtnLimpiarCampos.TabIndex = 63
        Me.BtnLimpiarCampos.Text = "Limpiar"
        Me.BtnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'BtnVolverMenu
        '
        Me.BtnVolverMenu.BackColor = System.Drawing.Color.Orange
        Me.BtnVolverMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolverMenu.ForeColor = System.Drawing.Color.White
        Me.BtnVolverMenu.Location = New System.Drawing.Point(716, 453)
        Me.BtnVolverMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnVolverMenu.Name = "BtnVolverMenu"
        Me.BtnVolverMenu.Size = New System.Drawing.Size(164, 51)
        Me.BtnVolverMenu.TabIndex = 64
        Me.BtnVolverMenu.Text = "Volver a Menú"
        Me.BtnVolverMenu.UseVisualStyleBackColor = False
        '
        'BtnVerSiniestroBD
        '
        Me.BtnVerSiniestroBD.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnVerSiniestroBD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerSiniestroBD.ForeColor = System.Drawing.Color.White
        Me.BtnVerSiniestroBD.Location = New System.Drawing.Point(33, 468)
        Me.BtnVerSiniestroBD.Name = "BtnVerSiniestroBD"
        Me.BtnVerSiniestroBD.Size = New System.Drawing.Size(178, 38)
        Me.BtnVerSiniestroBD.TabIndex = 68
        Me.BtnVerSiniestroBD.Text = "Ver Siniestros BD"
        Me.BtnVerSiniestroBD.UseVisualStyleBackColor = False
        '
        'BtnActualizarEstadoSiniestro
        '
        Me.BtnActualizarEstadoSiniestro.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnActualizarEstadoSiniestro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarEstadoSiniestro.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarEstadoSiniestro.Location = New System.Drawing.Point(478, 125)
        Me.BtnActualizarEstadoSiniestro.Name = "BtnActualizarEstadoSiniestro"
        Me.BtnActualizarEstadoSiniestro.Size = New System.Drawing.Size(122, 32)
        Me.BtnActualizarEstadoSiniestro.TabIndex = 66
        Me.BtnActualizarEstadoSiniestro.Text = "Actualizar Estado"
        Me.BtnActualizarEstadoSiniestro.UseVisualStyleBackColor = False
        '
        'BtnRegistrarSiniestro
        '
        Me.BtnRegistrarSiniestro.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnRegistrarSiniestro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarSiniestro.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrarSiniestro.Location = New System.Drawing.Point(33, 412)
        Me.BtnRegistrarSiniestro.Name = "BtnRegistrarSiniestro"
        Me.BtnRegistrarSiniestro.Size = New System.Drawing.Size(178, 32)
        Me.BtnRegistrarSiniestro.TabIndex = 65
        Me.BtnRegistrarSiniestro.Text = "Registrar"
        Me.BtnRegistrarSiniestro.UseVisualStyleBackColor = False
        '
        'TxtRutCliente
        '
        Me.TxtRutCliente.Location = New System.Drawing.Point(15, 116)
        Me.TxtRutCliente.Multiline = True
        Me.TxtRutCliente.Name = "TxtRutCliente"
        Me.TxtRutCliente.Size = New System.Drawing.Size(218, 20)
        Me.TxtRutCliente.TabIndex = 69
        '
        'LblEstadoDelSeguro
        '
        Me.LblEstadoDelSeguro.AutoSize = True
        Me.LblEstadoDelSeguro.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstadoDelSeguro.ForeColor = System.Drawing.Color.Black
        Me.LblEstadoDelSeguro.Location = New System.Drawing.Point(11, 324)
        Me.LblEstadoDelSeguro.Name = "LblEstadoDelSeguro"
        Me.LblEstadoDelSeguro.Size = New System.Drawing.Size(129, 21)
        Me.LblEstadoDelSeguro.TabIndex = 70
        Me.LblEstadoDelSeguro.Text = "Estado del seguro"
        '
        'CmbEstadoDelSeguro
        '
        Me.CmbEstadoDelSeguro.FormattingEnabled = True
        Me.CmbEstadoDelSeguro.Items.AddRange(New Object() {"Seguro Vigente", "Seguro Vencido"})
        Me.CmbEstadoDelSeguro.Location = New System.Drawing.Point(15, 348)
        Me.CmbEstadoDelSeguro.Name = "CmbEstadoDelSeguro"
        Me.CmbEstadoDelSeguro.Size = New System.Drawing.Size(218, 21)
        Me.CmbEstadoDelSeguro.TabIndex = 71
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(248, 2)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnFiltrarEstado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbEstadoSiniestroBD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnFiltrarRut)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblFechaBD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtRutBD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblRutBD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnActualizarEstadoSiniestro)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvSiniestros)
        Me.SplitContainer1.Size = New System.Drawing.Size(649, 431)
        Me.SplitContainer1.SplitterDistance = 183
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 73
        '
        'btnFiltrarEstado
        '
        Me.btnFiltrarEstado.BackColor = System.Drawing.Color.Red
        Me.btnFiltrarEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarEstado.ForeColor = System.Drawing.Color.White
        Me.btnFiltrarEstado.Location = New System.Drawing.Point(348, 125)
        Me.btnFiltrarEstado.Name = "btnFiltrarEstado"
        Me.btnFiltrarEstado.Size = New System.Drawing.Size(124, 32)
        Me.btnFiltrarEstado.TabIndex = 76
        Me.btnFiltrarEstado.Text = "Buscar por Estado"
        Me.btnFiltrarEstado.UseVisualStyleBackColor = False
        '
        'cmbEstadoSiniestroBD
        '
        Me.cmbEstadoSiniestroBD.FormattingEnabled = True
        Me.cmbEstadoSiniestroBD.Items.AddRange(New Object() {"Activo", "Pendiente", "Finalizado"})
        Me.cmbEstadoSiniestroBD.Location = New System.Drawing.Point(348, 89)
        Me.cmbEstadoSiniestroBD.Name = "cmbEstadoSiniestroBD"
        Me.cmbEstadoSiniestroBD.Size = New System.Drawing.Size(252, 21)
        Me.cmbEstadoSiniestroBD.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(272, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 30)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Filtrar por:"
        '
        'BtnFiltrarRut
        '
        Me.BtnFiltrarRut.BackColor = System.Drawing.Color.Red
        Me.BtnFiltrarRut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrarRut.ForeColor = System.Drawing.Color.White
        Me.BtnFiltrarRut.Location = New System.Drawing.Point(72, 125)
        Me.BtnFiltrarRut.Name = "BtnFiltrarRut"
        Me.BtnFiltrarRut.Size = New System.Drawing.Size(163, 32)
        Me.BtnFiltrarRut.TabIndex = 74
        Me.BtnFiltrarRut.Text = "Buscar por Rut"
        Me.BtnFiltrarRut.UseVisualStyleBackColor = False
        '
        'LblFechaBD
        '
        Me.LblFechaBD.AutoSize = True
        Me.LblFechaBD.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaBD.ForeColor = System.Drawing.Color.Black
        Me.LblFechaBD.Location = New System.Drawing.Point(417, 65)
        Me.LblFechaBD.Name = "LblFechaBD"
        Me.LblFechaBD.Size = New System.Drawing.Size(115, 21)
        Me.LblFechaBD.TabIndex = 75
        Me.LblFechaBD.Text = "Estado Siniestro"
        '
        'TxtRutBD
        '
        Me.TxtRutBD.Location = New System.Drawing.Point(44, 90)
        Me.TxtRutBD.Multiline = True
        Me.TxtRutBD.Name = "TxtRutBD"
        Me.TxtRutBD.Size = New System.Drawing.Size(231, 20)
        Me.TxtRutBD.TabIndex = 73
        '
        'LblRutBD
        '
        Me.LblRutBD.AutoSize = True
        Me.LblRutBD.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRutBD.ForeColor = System.Drawing.Color.Black
        Me.LblRutBD.Location = New System.Drawing.Point(115, 65)
        Me.LblRutBD.Name = "LblRutBD"
        Me.LblRutBD.Size = New System.Drawing.Size(89, 21)
        Me.LblRutBD.TabIndex = 51
        Me.LblRutBD.Text = "Rut(Cliente)"
        '
        'dgvSiniestros
        '
        Me.dgvSiniestros.AllowDrop = True
        Me.dgvSiniestros.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvSiniestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSiniestros.Location = New System.Drawing.Point(-1, 2)
        Me.dgvSiniestros.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSiniestros.Name = "dgvSiniestros"
        Me.dgvSiniestros.ReadOnly = True
        Me.dgvSiniestros.RowHeadersWidth = 49
        Me.dgvSiniestros.RowTemplate.Height = 24
        Me.dgvSiniestros.Size = New System.Drawing.Size(651, 242)
        Me.dgvSiniestros.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.cmbRutCompania)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnEliminarSiniestro)
        Me.Panel1.Controls.Add(Me.LblEstadoDelSiniestro)
        Me.Panel1.Controls.Add(Me.CmbEstadoSiniestro)
        Me.Panel1.Controls.Add(Me.LblEstadoDelSeguro)
        Me.Panel1.Controls.Add(Me.CmbEstadoDelSeguro)
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.BtnVolverMenu)
        Me.Panel1.Controls.Add(Me.BtnVerSiniestroBD)
        Me.Panel1.Controls.Add(Me.DtFechaSiniestro)
        Me.Panel1.Controls.Add(Me.LblDetalleSiniestro)
        Me.Panel1.Controls.Add(Me.BtnLimpiarCampos)
        Me.Panel1.Controls.Add(Me.TxtDetalleSiniestro)
        Me.Panel1.Controls.Add(Me.LblFechaSiniestro)
        Me.Panel1.Controls.Add(Me.TxtRutCliente)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.BtnRegistrarSiniestro)
        Me.Panel1.Controls.Add(Me.LblRutCompania)
        Me.Panel1.Controls.Add(Me.LblRutCliente)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 565)
        Me.Panel1.TabIndex = 74
        '
        'cmbRutCompania
        '
        Me.cmbRutCompania.FormattingEnabled = True
        Me.cmbRutCompania.Location = New System.Drawing.Point(15, 172)
        Me.cmbRutCompania.Name = "cmbRutCompania"
        Me.cmbRutCompania.Size = New System.Drawing.Size(218, 21)
        Me.cmbRutCompania.TabIndex = 77
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(246, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 388)
        Me.Panel3.TabIndex = 77
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Panel4.TabIndex = 0
        '
        'btnEliminarSiniestro
        '
        Me.btnEliminarSiniestro.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEliminarSiniestro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarSiniestro.ForeColor = System.Drawing.Color.White
        Me.btnEliminarSiniestro.Location = New System.Drawing.Point(33, 439)
        Me.btnEliminarSiniestro.Name = "btnEliminarSiniestro"
        Me.btnEliminarSiniestro.Size = New System.Drawing.Size(178, 32)
        Me.btnEliminarSiniestro.TabIndex = 74
        Me.btnEliminarSiniestro.Text = "Eliminar Siniestro"
        Me.btnEliminarSiniestro.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.Diseño_sin_título__1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 387)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(899, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form7"
        Me.Text = "EVA 3 - EPE 3"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtFechaSiniestro As DateTimePicker
    Friend WithEvents CmbEstadoSiniestro As ComboBox
    Friend WithEvents LblRutCompania As Label
    Friend WithEvents LblDetalleSiniestro As Label
    Friend WithEvents LblEstadoDelSiniestro As Label
    Friend WithEvents LblFechaSiniestro As Label
    Friend WithEvents LblRutCliente As Label
    Friend WithEvents TxtDetalleSiniestro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLimpiarCampos As Button
    Friend WithEvents BtnVolverMenu As Button
    Friend WithEvents BtnVerSiniestroBD As Button
    Friend WithEvents BtnActualizarEstadoSiniestro As Button
    Friend WithEvents BtnRegistrarSiniestro As Button
    Friend WithEvents TxtRutCliente As TextBox
    Friend WithEvents LblEstadoDelSeguro As Label
    Friend WithEvents CmbEstadoDelSeguro As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents LblRutBD As Label
    Friend WithEvents TxtRutBD As TextBox
    Friend WithEvents dgvSiniestros As DataGridView
    Friend WithEvents BtnFiltrarRut As Button
    Friend WithEvents LblFechaBD As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEstadoSiniestroBD As ComboBox
    Friend WithEvents btnFiltrarEstado As Button
    Friend WithEvents btnEliminarSiniestro As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbRutCompania As ComboBox
    Friend WithEvents Panel4 As Panel
End Class
