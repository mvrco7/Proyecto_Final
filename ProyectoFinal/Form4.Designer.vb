<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnVerRepuestosBD = New System.Windows.Forms.Button()
        Me.btnEliminarRepuesto = New System.Windows.Forms.Button()
        Me.btnActualizarRepuesto = New System.Windows.Forms.Button()
        Me.btnCrearRepuesto = New System.Windows.Forms.Button()
        Me.btnBuscarRepuesto = New System.Windows.Forms.Button()
        Me.cmbNombreRepuesto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVolverMenu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiarDatos = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.btnVerRepuestosBD)
        Me.Panel1.Controls.Add(Me.btnEliminarRepuesto)
        Me.Panel1.Controls.Add(Me.btnActualizarRepuesto)
        Me.Panel1.Controls.Add(Me.btnCrearRepuesto)
        Me.Panel1.Controls.Add(Me.btnBuscarRepuesto)
        Me.Panel1.Controls.Add(Me.cmbNombreRepuesto)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtStock)
        Me.Panel1.Controls.Add(Me.txtPrecioUnitario)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.txtProveedor)
        Me.Panel1.Location = New System.Drawing.Point(-3, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 300)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Location = New System.Drawing.Point(3, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(332, 1)
        Me.Panel2.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(17, 78)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(143, 20)
        Me.txtNombre.TabIndex = 27
        '
        'btnVerRepuestosBD
        '
        Me.btnVerRepuestosBD.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVerRepuestosBD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerRepuestosBD.ForeColor = System.Drawing.Color.White
        Me.btnVerRepuestosBD.Location = New System.Drawing.Point(15, 255)
        Me.btnVerRepuestosBD.Name = "btnVerRepuestosBD"
        Me.btnVerRepuestosBD.Size = New System.Drawing.Size(136, 32)
        Me.btnVerRepuestosBD.TabIndex = 26
        Me.btnVerRepuestosBD.Text = "Ver Repuestos BD"
        Me.btnVerRepuestosBD.UseVisualStyleBackColor = False
        '
        'btnEliminarRepuesto
        '
        Me.btnEliminarRepuesto.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEliminarRepuesto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRepuesto.ForeColor = System.Drawing.Color.White
        Me.btnEliminarRepuesto.Location = New System.Drawing.Point(179, 255)
        Me.btnEliminarRepuesto.Name = "btnEliminarRepuesto"
        Me.btnEliminarRepuesto.Size = New System.Drawing.Size(136, 32)
        Me.btnEliminarRepuesto.TabIndex = 25
        Me.btnEliminarRepuesto.Text = "Eliminar"
        Me.btnEliminarRepuesto.UseVisualStyleBackColor = False
        '
        'btnActualizarRepuesto
        '
        Me.btnActualizarRepuesto.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnActualizarRepuesto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarRepuesto.ForeColor = System.Drawing.Color.White
        Me.btnActualizarRepuesto.Location = New System.Drawing.Point(179, 217)
        Me.btnActualizarRepuesto.Name = "btnActualizarRepuesto"
        Me.btnActualizarRepuesto.Size = New System.Drawing.Size(136, 32)
        Me.btnActualizarRepuesto.TabIndex = 24
        Me.btnActualizarRepuesto.Text = "Actualizar"
        Me.btnActualizarRepuesto.UseVisualStyleBackColor = False
        '
        'btnCrearRepuesto
        '
        Me.btnCrearRepuesto.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCrearRepuesto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearRepuesto.ForeColor = System.Drawing.Color.White
        Me.btnCrearRepuesto.Location = New System.Drawing.Point(15, 217)
        Me.btnCrearRepuesto.Name = "btnCrearRepuesto"
        Me.btnCrearRepuesto.Size = New System.Drawing.Size(136, 32)
        Me.btnCrearRepuesto.TabIndex = 23
        Me.btnCrearRepuesto.Text = "Registrar"
        Me.btnCrearRepuesto.UseVisualStyleBackColor = False
        '
        'btnBuscarRepuesto
        '
        Me.btnBuscarRepuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarRepuesto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRepuesto.ForeColor = System.Drawing.Color.White
        Me.btnBuscarRepuesto.Location = New System.Drawing.Point(241, 9)
        Me.btnBuscarRepuesto.Name = "btnBuscarRepuesto"
        Me.btnBuscarRepuesto.Size = New System.Drawing.Size(79, 31)
        Me.btnBuscarRepuesto.TabIndex = 22
        Me.btnBuscarRepuesto.Text = "Buscar"
        Me.btnBuscarRepuesto.UseVisualStyleBackColor = False
        '
        'cmbNombreRepuesto
        '
        Me.cmbNombreRepuesto.FormattingEnabled = True
        Me.cmbNombreRepuesto.Location = New System.Drawing.Point(15, 16)
        Me.cmbNombreRepuesto.Name = "cmbNombreRepuesto"
        Me.cmbNombreRepuesto.Size = New System.Drawing.Size(214, 21)
        Me.cmbNombreRepuesto.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(179, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ID (Solo lectura)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(125, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(179, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio Unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(17, 131)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(141, 20)
        Me.txtStock.TabIndex = 4
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(179, 131)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(143, 20)
        Me.txtPrecioUnitario.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(179, 78)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(143, 20)
        Me.txtID.TabIndex = 2
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(97, 182)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(141, 20)
        Me.txtProveedor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Repuestos"
        '
        'btnVolverMenu
        '
        Me.btnVolverMenu.BackColor = System.Drawing.Color.Orange
        Me.btnVolverMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenu.ForeColor = System.Drawing.Color.White
        Me.btnVolverMenu.Location = New System.Drawing.Point(180, 348)
        Me.btnVolverMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVolverMenu.Name = "btnVolverMenu"
        Me.btnVolverMenu.Size = New System.Drawing.Size(142, 36)
        Me.btnVolverMenu.TabIndex = 23
        Me.btnVolverMenu.Text = "Volver a Menú"
        Me.btnVolverMenu.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.Diseño_sin_título__1_
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 330)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnLimpiarDatos
        '
        Me.btnLimpiarDatos.BackColor = System.Drawing.Color.PaleGreen
        Me.btnLimpiarDatos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiarDatos.Location = New System.Drawing.Point(12, 350)
        Me.btnLimpiarDatos.Name = "btnLimpiarDatos"
        Me.btnLimpiarDatos.Size = New System.Drawing.Size(136, 32)
        Me.btnLimpiarDatos.TabIndex = 30
        Me.btnLimpiarDatos.Text = "Limpiar"
        Me.btnLimpiarDatos.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 403)
        Me.Controls.Add(Me.btnLimpiarDatos)
        Me.Controls.Add(Me.btnVolverMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 36)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "EVA 3 - EPE 3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVolverMenu As Button
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbNombreRepuesto As ComboBox
    Friend WithEvents btnActualizarRepuesto As Button
    Friend WithEvents btnCrearRepuesto As Button
    Friend WithEvents btnVerRepuestosBD As Button
    Friend WithEvents btnEliminarRepuesto As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLimpiarDatos As Button
    Friend WithEvents btnBuscarRepuesto As Button
End Class
