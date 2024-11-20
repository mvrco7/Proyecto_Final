<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscarSiniestro = New System.Windows.Forms.Button()
        Me.txtRutCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcionProblema = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.cmbSiniestroID = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnFiltrarEstado = New System.Windows.Forms.Button()
        Me.cmbFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblFechaBD = New System.Windows.Forms.Label()
        Me.BtnActualizarEstado = New System.Windows.Forms.Button()
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbRutEmpleado = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminarSolicitud = New System.Windows.Forms.Button()
        Me.btnRegistrarSolicitud = New System.Windows.Forms.Button()
        Me.BtnVolverMenu = New System.Windows.Forms.Button()
        Me.BtnLimpiarCampos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.Diseño_sin_título__1_
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 430)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(899, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnBuscarSiniestro)
        Me.Panel1.Controls.Add(Me.txtRutCliente)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtDescripcionProblema)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dtFechaSolicitud)
        Me.Panel1.Controls.Add(Me.cmbSiniestroID)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.cmbRutEmpleado)
        Me.Panel1.Controls.Add(Me.cmbEstado)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(1, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 424)
        Me.Panel1.TabIndex = 64
        '
        'btnBuscarSiniestro
        '
        Me.btnBuscarSiniestro.BackColor = System.Drawing.Color.Purple
        Me.btnBuscarSiniestro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarSiniestro.ForeColor = System.Drawing.Color.White
        Me.btnBuscarSiniestro.Location = New System.Drawing.Point(162, 26)
        Me.btnBuscarSiniestro.Name = "btnBuscarSiniestro"
        Me.btnBuscarSiniestro.Size = New System.Drawing.Size(71, 32)
        Me.btnBuscarSiniestro.TabIndex = 85
        Me.btnBuscarSiniestro.Text = "Buscar"
        Me.btnBuscarSiniestro.UseVisualStyleBackColor = False
        '
        'txtRutCliente
        '
        Me.txtRutCliente.Location = New System.Drawing.Point(15, 93)
        Me.txtRutCliente.Name = "txtRutCliente"
        Me.txtRutCliente.Size = New System.Drawing.Size(218, 20)
        Me.txtRutCliente.TabIndex = 106
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 21)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Descripción Problema"
        '
        'txtDescripcionProblema
        '
        Me.txtDescripcionProblema.Location = New System.Drawing.Point(15, 155)
        Me.txtDescripcionProblema.Name = "txtDescripcionProblema"
        Me.txtDescripcionProblema.Size = New System.Drawing.Size(218, 20)
        Me.txtDescripcionProblema.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Rut(Cliente)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 21)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Fecha Solicitud"
        '
        'dtFechaSolicitud
        '
        Me.dtFechaSolicitud.Location = New System.Drawing.Point(15, 217)
        Me.dtFechaSolicitud.Margin = New System.Windows.Forms.Padding(2)
        Me.dtFechaSolicitud.Name = "dtFechaSolicitud"
        Me.dtFechaSolicitud.Size = New System.Drawing.Size(218, 20)
        Me.dtFechaSolicitud.TabIndex = 100
        '
        'cmbSiniestroID
        '
        Me.cmbSiniestroID.FormattingEnabled = True
        Me.cmbSiniestroID.Location = New System.Drawing.Point(16, 34)
        Me.cmbSiniestroID.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSiniestroID.Name = "cmbSiniestroID"
        Me.cmbSiniestroID.Size = New System.Drawing.Size(131, 21)
        Me.cmbSiniestroID.TabIndex = 92
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.btnFiltrarEstado)
        Me.Panel5.Controls.Add(Me.cmbFiltroEstado)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.LblFechaBD)
        Me.Panel5.Controls.Add(Me.BtnActualizarEstado)
        Me.Panel5.Controls.Add(Me.dgvSolicitudes)
        Me.Panel5.Location = New System.Drawing.Point(249, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(651, 419)
        Me.Panel5.TabIndex = 91
        '
        'btnFiltrarEstado
        '
        Me.btnFiltrarEstado.BackColor = System.Drawing.Color.Red
        Me.btnFiltrarEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarEstado.ForeColor = System.Drawing.Color.White
        Me.btnFiltrarEstado.Location = New System.Drawing.Point(302, 63)
        Me.btnFiltrarEstado.Name = "btnFiltrarEstado"
        Me.btnFiltrarEstado.Size = New System.Drawing.Size(164, 32)
        Me.btnFiltrarEstado.TabIndex = 84
        Me.btnFiltrarEstado.Text = "Buscar por Estado"
        Me.btnFiltrarEstado.UseVisualStyleBackColor = False
        '
        'cmbFiltroEstado
        '
        Me.cmbFiltroEstado.FormattingEnabled = True
        Me.cmbFiltroEstado.Items.AddRange(New Object() {"Recibida", "Pendiente", "Completado"})
        Me.cmbFiltroEstado.Location = New System.Drawing.Point(32, 69)
        Me.cmbFiltroEstado.Name = "cmbFiltroEstado"
        Me.cmbFiltroEstado.Size = New System.Drawing.Size(252, 21)
        Me.cmbFiltroEstado.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(255, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 30)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Filtrar por:"
        '
        'LblFechaBD
        '
        Me.LblFechaBD.AutoSize = True
        Me.LblFechaBD.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaBD.ForeColor = System.Drawing.Color.Black
        Me.LblFechaBD.Location = New System.Drawing.Point(28, 43)
        Me.LblFechaBD.Name = "LblFechaBD"
        Me.LblFechaBD.Size = New System.Drawing.Size(115, 21)
        Me.LblFechaBD.TabIndex = 83
        Me.LblFechaBD.Text = "Estado Solicitud"
        '
        'BtnActualizarEstado
        '
        Me.BtnActualizarEstado.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnActualizarEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarEstado.ForeColor = System.Drawing.Color.White
        Me.BtnActualizarEstado.Location = New System.Drawing.Point(472, 63)
        Me.BtnActualizarEstado.Name = "BtnActualizarEstado"
        Me.BtnActualizarEstado.Size = New System.Drawing.Size(164, 32)
        Me.BtnActualizarEstado.TabIndex = 78
        Me.BtnActualizarEstado.Text = "Actualizar Estado"
        Me.BtnActualizarEstado.UseVisualStyleBackColor = False
        '
        'dgvSolicitudes
        '
        Me.dgvSolicitudes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudes.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvSolicitudes.Location = New System.Drawing.Point(-2, 110)
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.RowHeadersWidth = 51
        Me.dgvSolicitudes.Size = New System.Drawing.Size(652, 314)
        Me.dgvSolicitudes.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(247, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 419)
        Me.Panel3.TabIndex = 90
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Panel4.TabIndex = 0
        '
        'cmbRutEmpleado
        '
        Me.cmbRutEmpleado.FormattingEnabled = True
        Me.cmbRutEmpleado.Location = New System.Drawing.Point(15, 351)
        Me.cmbRutEmpleado.Name = "cmbRutEmpleado"
        Me.cmbRutEmpleado.Size = New System.Drawing.Size(218, 21)
        Me.cmbRutEmpleado.TabIndex = 89
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Recibida", "Pendiente", "Completado"})
        Me.cmbEstado.Location = New System.Drawing.Point(15, 285)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(218, 21)
        Me.cmbEstado.TabIndex = 87
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 21)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Rut Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 21)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Siniestro ID"
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 21)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Solicitud de Servicio"
        '
        'btnEliminarSolicitud
        '
        Me.btnEliminarSolicitud.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnEliminarSolicitud.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarSolicitud.ForeColor = System.Drawing.Color.White
        Me.btnEliminarSolicitud.Location = New System.Drawing.Point(35, 72)
        Me.btnEliminarSolicitud.Name = "btnEliminarSolicitud"
        Me.btnEliminarSolicitud.Size = New System.Drawing.Size(178, 32)
        Me.btnEliminarSolicitud.TabIndex = 76
        Me.btnEliminarSolicitud.Text = "Eliminar"
        Me.btnEliminarSolicitud.UseVisualStyleBackColor = False
        '
        'btnRegistrarSolicitud
        '
        Me.btnRegistrarSolicitud.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnRegistrarSolicitud.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarSolicitud.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarSolicitud.Location = New System.Drawing.Point(35, 25)
        Me.btnRegistrarSolicitud.Name = "btnRegistrarSolicitud"
        Me.btnRegistrarSolicitud.Size = New System.Drawing.Size(178, 32)
        Me.btnRegistrarSolicitud.TabIndex = 82
        Me.btnRegistrarSolicitud.Text = "Registrar"
        Me.btnRegistrarSolicitud.UseVisualStyleBackColor = False
        '
        'BtnVolverMenu
        '
        Me.BtnVolverMenu.BackColor = System.Drawing.Color.Orange
        Me.BtnVolverMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolverMenu.ForeColor = System.Drawing.Color.White
        Me.BtnVolverMenu.Location = New System.Drawing.Point(703, 483)
        Me.BtnVolverMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnVolverMenu.Name = "BtnVolverMenu"
        Me.BtnVolverMenu.Size = New System.Drawing.Size(164, 51)
        Me.BtnVolverMenu.TabIndex = 84
        Me.BtnVolverMenu.Text = "Volver a Menú"
        Me.BtnVolverMenu.UseVisualStyleBackColor = False
        '
        'BtnLimpiarCampos
        '
        Me.BtnLimpiarCampos.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnLimpiarCampos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarCampos.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiarCampos.Location = New System.Drawing.Point(346, 483)
        Me.BtnLimpiarCampos.Name = "BtnLimpiarCampos"
        Me.BtnLimpiarCampos.Size = New System.Drawing.Size(152, 51)
        Me.BtnLimpiarCampos.TabIndex = 85
        Me.BtnLimpiarCampos.Text = "Limpiar"
        Me.BtnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.Controls.Add(Me.btnRegistrarSolicitud)
        Me.Panel2.Controls.Add(Me.btnEliminarSolicitud)
        Me.Panel2.Location = New System.Drawing.Point(-2, 430)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 137)
        Me.Panel2.TabIndex = 86
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnLimpiarCampos)
        Me.Controls.Add(Me.BtnVolverMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form8"
        Me.Text = "EVA 3 - EPE 3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEliminarSolicitud As Button
    Friend WithEvents btnRegistrarSolicitud As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnVolverMenu As Button
    Friend WithEvents BtnLimpiarCampos As Button
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgvSolicitudes As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents LblFechaBD As Label
    Friend WithEvents cmbSiniestroID As ComboBox
    Friend WithEvents cmbRutEmpleado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtFechaSolicitud As DateTimePicker
    Friend WithEvents btnFiltrarEstado As Button
    Friend WithEvents cmbFiltroEstado As ComboBox
    Friend WithEvents BtnActualizarEstado As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescripcionProblema As TextBox
    Friend WithEvents txtRutCliente As TextBox
    Friend WithEvents btnBuscarSiniestro As Button
End Class
