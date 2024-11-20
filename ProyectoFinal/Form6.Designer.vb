<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtComuna = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellidoM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellidoP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarRut = New System.Windows.Forms.Button()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVerDatosBD = New System.Windows.Forms.Button()
        Me.btnActualizarBD = New System.Windows.Forms.Button()
        Me.btnCrearCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiarDatos = New System.Windows.Forms.Button()
        Me.btnVolverMenu = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 411)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtComuna)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtApellidoM)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtApellidoP)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnBuscarRut)
        Me.Panel2.Controls.Add(Me.txtRut)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnVerDatosBD)
        Me.Panel2.Controls.Add(Me.btnActualizarBD)
        Me.Panel2.Controls.Add(Me.btnCrearCliente)
        Me.Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(335, 375)
        Me.Panel2.TabIndex = 9
        '
        'txtComuna
        '
        Me.txtComuna.Location = New System.Drawing.Point(94, 234)
        Me.txtComuna.Multiline = True
        Me.txtComuna.Name = "txtComuna"
        Me.txtComuna.Size = New System.Drawing.Size(227, 21)
        Me.txtComuna.TabIndex = 35
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(94, 163)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(227, 21)
        Me.txtDireccion.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 161)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 21)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Dirección"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 232)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 21)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Comuna"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(94, 196)
        Me.txtTelefono.Multiline = True
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(227, 21)
        Me.txtTelefono.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 196)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "N° Teléfono"
        '
        'txtApellidoM
        '
        Me.txtApellidoM.Location = New System.Drawing.Point(94, 128)
        Me.txtApellidoM.Multiline = True
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(227, 21)
        Me.txtApellidoM.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Apellido M."
        '
        'txtApellidoP
        '
        Me.txtApellidoP.Location = New System.Drawing.Point(94, 94)
        Me.txtApellidoP.Multiline = True
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(227, 21)
        Me.txtApellidoP.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Apellido P."
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(94, 59)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(227, 21)
        Me.txtNombre.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Rut"
        '
        'btnBuscarRut
        '
        Me.btnBuscarRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarRut.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRut.ForeColor = System.Drawing.Color.White
        Me.btnBuscarRut.Location = New System.Drawing.Point(229, 20)
        Me.btnBuscarRut.Name = "btnBuscarRut"
        Me.btnBuscarRut.Size = New System.Drawing.Size(79, 31)
        Me.btnBuscarRut.TabIndex = 21
        Me.btnBuscarRut.Text = "Buscar"
        Me.btnBuscarRut.UseVisualStyleBackColor = False
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(66, 25)
        Me.txtRut.Multiline = True
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(144, 21)
        Me.txtRut.TabIndex = 15
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(178, 330)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(142, 32)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar Cliente"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnVerDatosBD
        '
        Me.btnVerDatosBD.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVerDatosBD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDatosBD.ForeColor = System.Drawing.Color.White
        Me.btnVerDatosBD.Location = New System.Drawing.Point(13, 330)
        Me.btnVerDatosBD.Name = "btnVerDatosBD"
        Me.btnVerDatosBD.Size = New System.Drawing.Size(136, 32)
        Me.btnVerDatosBD.TabIndex = 9
        Me.btnVerDatosBD.Text = "Leer Cliente"
        Me.btnVerDatosBD.UseVisualStyleBackColor = False
        '
        'btnActualizarBD
        '
        Me.btnActualizarBD.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnActualizarBD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarBD.ForeColor = System.Drawing.Color.Transparent
        Me.btnActualizarBD.Location = New System.Drawing.Point(178, 280)
        Me.btnActualizarBD.Name = "btnActualizarBD"
        Me.btnActualizarBD.Size = New System.Drawing.Size(142, 32)
        Me.btnActualizarBD.TabIndex = 8
        Me.btnActualizarBD.Text = "Actualizar BD"
        Me.btnActualizarBD.UseVisualStyleBackColor = False
        '
        'btnCrearCliente
        '
        Me.btnCrearCliente.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCrearCliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCliente.ForeColor = System.Drawing.Color.White
        Me.btnCrearCliente.Location = New System.Drawing.Point(13, 280)
        Me.btnCrearCliente.Name = "btnCrearCliente"
        Me.btnCrearCliente.Size = New System.Drawing.Size(136, 32)
        Me.btnCrearCliente.TabIndex = 7
        Me.btnCrearCliente.Text = "Crear Cliente"
        Me.btnCrearCliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.Diseño_sin_título__1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 411)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnLimpiarDatos
        '
        Me.btnLimpiarDatos.BackColor = System.Drawing.Color.PaleGreen
        Me.btnLimpiarDatos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiarDatos.Location = New System.Drawing.Point(23, 431)
        Me.btnLimpiarDatos.Name = "btnLimpiarDatos"
        Me.btnLimpiarDatos.Size = New System.Drawing.Size(136, 32)
        Me.btnLimpiarDatos.TabIndex = 31
        Me.btnLimpiarDatos.Text = "Limpiar"
        Me.btnLimpiarDatos.UseVisualStyleBackColor = False
        '
        'btnVolverMenu
        '
        Me.btnVolverMenu.BackColor = System.Drawing.Color.Orange
        Me.btnVolverMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenu.ForeColor = System.Drawing.Color.White
        Me.btnVolverMenu.Location = New System.Drawing.Point(178, 431)
        Me.btnVolverMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVolverMenu.Name = "btnVolverMenu"
        Me.btnVolverMenu.Size = New System.Drawing.Size(142, 36)
        Me.btnVolverMenu.TabIndex = 32
        Me.btnVolverMenu.Text = "Volver a Menú"
        Me.btnVolverMenu.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 486)
        Me.Controls.Add(Me.btnVolverMenu)
        Me.Controls.Add(Me.btnLimpiarDatos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBuscarRut As Button
    Friend WithEvents txtRut As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVerDatosBD As Button
    Friend WithEvents btnActualizarBD As Button
    Friend WithEvents btnCrearCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellidoP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApellidoM As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtComuna As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLimpiarDatos As Button
    Friend WithEvents btnVolverMenu As Button
End Class
