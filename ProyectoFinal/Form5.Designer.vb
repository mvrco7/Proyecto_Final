<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnRepuestos = New System.Windows.Forms.Button()
        Me.dtFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.cmbNombreRepuesto = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnVerResumenVentasBD = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegistrarVenta = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtCantVendida = New System.Windows.Forms.TextBox()
        Me.btnVolverMenu = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Venta Repuestos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.btnRepuestos)
        Me.Panel1.Controls.Add(Me.dtFechaVenta)
        Me.Panel1.Controls.Add(Me.cmbNombreRepuesto)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btnVerResumenVentasBD)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnRegistrarVenta)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.txtCantVendida)
        Me.Panel1.Location = New System.Drawing.Point(-2, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 307)
        Me.Panel1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Ir al formulario"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProyectoFinal.My.Resources.Resources.icons8_turn_100
        Me.PictureBox3.Location = New System.Drawing.Point(385, 219)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'btnRepuestos
        '
        Me.btnRepuestos.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRepuestos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepuestos.ForeColor = System.Drawing.Color.White
        Me.btnRepuestos.Location = New System.Drawing.Point(264, 243)
        Me.btnRepuestos.Name = "btnRepuestos"
        Me.btnRepuestos.Size = New System.Drawing.Size(171, 32)
        Me.btnRepuestos.TabIndex = 43
        Me.btnRepuestos.Text = "Repuestos"
        Me.btnRepuestos.UseVisualStyleBackColor = False
        '
        'dtFechaVenta
        '
        Me.dtFechaVenta.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtFechaVenta.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.dtFechaVenta.Location = New System.Drawing.Point(23, 96)
        Me.dtFechaVenta.Name = "dtFechaVenta"
        Me.dtFechaVenta.Size = New System.Drawing.Size(215, 20)
        Me.dtFechaVenta.TabIndex = 42
        '
        'cmbNombreRepuesto
        '
        Me.cmbNombreRepuesto.FormattingEnabled = True
        Me.cmbNombreRepuesto.Location = New System.Drawing.Point(23, 35)
        Me.cmbNombreRepuesto.Name = "cmbNombreRepuesto"
        Me.cmbNombreRepuesto.Size = New System.Drawing.Size(218, 21)
        Me.cmbNombreRepuesto.TabIndex = 41
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.txtTotal)
        Me.Panel4.Location = New System.Drawing.Point(144, 156)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(216, 28)
        Me.Panel4.TabIndex = 39
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoFinal.My.Resources.Resources.icons8_dollar_100
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(25, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(188, 18)
        Me.txtTotal.TabIndex = 2
        '
        'btnVerResumenVentasBD
        '
        Me.btnVerResumenVentasBD.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnVerResumenVentasBD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerResumenVentasBD.ForeColor = System.Drawing.Color.White
        Me.btnVerResumenVentasBD.Location = New System.Drawing.Point(39, 243)
        Me.btnVerResumenVentasBD.Name = "btnVerResumenVentasBD"
        Me.btnVerResumenVentasBD.Size = New System.Drawing.Size(187, 32)
        Me.btnVerResumenVentasBD.TabIndex = 37
        Me.btnVerResumenVentasBD.Text = "Buscar Resumen Fecha Venta"
        Me.btnVerResumenVentasBD.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(258, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Cant. Vendida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 21)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Nombre de Repuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(258, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Cliente (Rut)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Fecha Venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(229, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 21)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Total"
        '
        'btnRegistrarVenta
        '
        Me.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrarVenta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarVenta.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarVenta.Location = New System.Drawing.Point(39, 205)
        Me.btnRegistrarVenta.Name = "btnRegistrarVenta"
        Me.btnRegistrarVenta.Size = New System.Drawing.Size(187, 32)
        Me.btnRegistrarVenta.TabIndex = 24
        Me.btnRegistrarVenta.Text = "Registrar"
        Me.btnRegistrarVenta.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Fuchsia
        Me.Panel2.Location = New System.Drawing.Point(459, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 296)
        Me.Panel2.TabIndex = 25
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(262, 36)
        Me.txtCliente.Multiline = True
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(190, 20)
        Me.txtCliente.TabIndex = 6
        '
        'txtCantVendida
        '
        Me.txtCantVendida.Location = New System.Drawing.Point(262, 96)
        Me.txtCantVendida.Multiline = True
        Me.txtCantVendida.Name = "txtCantVendida"
        Me.txtCantVendida.Size = New System.Drawing.Size(190, 20)
        Me.txtCantVendida.TabIndex = 5
        '
        'btnVolverMenu
        '
        Me.btnVolverMenu.BackColor = System.Drawing.Color.Orange
        Me.btnVolverMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenu.ForeColor = System.Drawing.Color.White
        Me.btnVolverMenu.Location = New System.Drawing.Point(281, 348)
        Me.btnVolverMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVolverMenu.Name = "btnVolverMenu"
        Me.btnVolverMenu.Size = New System.Drawing.Size(176, 36)
        Me.btnVolverMenu.TabIndex = 24
        Me.btnVolverMenu.Text = "Volver a Menú"
        Me.btnVolverMenu.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Location = New System.Drawing.Point(12, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 296)
        Me.Panel3.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.Diseño_sin_título__1_
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 330)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(473, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.BackColor = System.Drawing.Color.PaleGreen
        Me.btnLimpiarCampos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarCampos.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(12, 352)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(176, 32)
        Me.btnLimpiarCampos.TabIndex = 31
        Me.btnLimpiarCampos.Text = "Limpiar"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 403)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnVolverMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "EVA 3 - EPE 3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVolverMenu As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtCantVendida As TextBox
    Friend WithEvents btnRegistrarVenta As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnVerResumenVentasBD As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents cmbNombreRepuesto As ComboBox
    Friend WithEvents dtFechaVenta As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnRepuestos As Button
    Friend WithEvents btnLimpiarCampos As Button
End Class
