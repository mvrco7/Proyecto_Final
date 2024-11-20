<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBuscarRut = New System.Windows.Forms.Button()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.cmbCargo = New System.Windows.Forms.ComboBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVerDatosBD = New System.Windows.Forms.Button()
        Me.btnActualizarBD = New System.Windows.Forms.Button()
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.btnVolverMenu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuarios"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 335)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.btnBuscarRut)
        Me.Panel2.Controls.Add(Me.txtCorreo)
        Me.Panel2.Controls.Add(Me.txtContrasena)
        Me.Panel2.Controls.Add(Me.cmbCargo)
        Me.Panel2.Controls.Add(Me.txtRut)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnVerDatosBD)
        Me.Panel2.Controls.Add(Me.btnActualizarBD)
        Me.Panel2.Controls.Add(Me.btnCrearUsuario)
        Me.Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(332, 296)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.ProyectoFinal.My.Resources.Resources.icons8_id_100
        Me.PictureBox5.Location = New System.Drawing.Point(13, 20)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 25
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = Global.ProyectoFinal.My.Resources.Resources.icons8_mail_100
        Me.PictureBox4.Location = New System.Drawing.Point(13, 55)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.ProyectoFinal.My.Resources.Resources.icons8_password_100__1_
        Me.PictureBox3.Location = New System.Drawing.Point(13, 94)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.ProyectoFinal.My.Resources.Resources.icons8_admin_settings_male_100
        Me.PictureBox2.Location = New System.Drawing.Point(13, 131)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'btnBuscarRut
        '
        Me.btnBuscarRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarRut.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRut.ForeColor = System.Drawing.Color.White
        Me.btnBuscarRut.Location = New System.Drawing.Point(242, 17)
        Me.btnBuscarRut.Name = "btnBuscarRut"
        Me.btnBuscarRut.Size = New System.Drawing.Size(79, 31)
        Me.btnBuscarRut.TabIndex = 21
        Me.btnBuscarRut.Text = "Buscar"
        Me.btnBuscarRut.UseVisualStyleBackColor = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(55, 59)
        Me.txtCorreo.Multiline = True
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(266, 21)
        Me.txtCorreo.TabIndex = 20
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(55, 98)
        Me.txtContrasena.Multiline = True
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(266, 21)
        Me.txtContrasena.TabIndex = 19
        '
        'cmbCargo
        '
        Me.cmbCargo.FormattingEnabled = True
        Me.cmbCargo.Location = New System.Drawing.Point(55, 136)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCargo.Size = New System.Drawing.Size(266, 21)
        Me.cmbCargo.TabIndex = 18
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(55, 23)
        Me.txtRut.Multiline = True
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(180, 21)
        Me.txtRut.TabIndex = 15
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(178, 232)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(142, 32)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar Usuario"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnVerDatosBD
        '
        Me.btnVerDatosBD.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVerDatosBD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDatosBD.ForeColor = System.Drawing.Color.White
        Me.btnVerDatosBD.Location = New System.Drawing.Point(13, 232)
        Me.btnVerDatosBD.Name = "btnVerDatosBD"
        Me.btnVerDatosBD.Size = New System.Drawing.Size(136, 32)
        Me.btnVerDatosBD.TabIndex = 9
        Me.btnVerDatosBD.Text = "Leer Usuarios"
        Me.btnVerDatosBD.UseVisualStyleBackColor = False
        '
        'btnActualizarBD
        '
        Me.btnActualizarBD.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnActualizarBD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarBD.ForeColor = System.Drawing.Color.Transparent
        Me.btnActualizarBD.Location = New System.Drawing.Point(178, 191)
        Me.btnActualizarBD.Name = "btnActualizarBD"
        Me.btnActualizarBD.Size = New System.Drawing.Size(142, 32)
        Me.btnActualizarBD.TabIndex = 8
        Me.btnActualizarBD.Text = "Actualizar BD"
        Me.btnActualizarBD.UseVisualStyleBackColor = False
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCrearUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearUsuario.ForeColor = System.Drawing.Color.White
        Me.btnCrearUsuario.Location = New System.Drawing.Point(13, 191)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(136, 32)
        Me.btnCrearUsuario.TabIndex = 7
        Me.btnCrearUsuario.Text = "Crear Usuario"
        Me.btnCrearUsuario.UseVisualStyleBackColor = False
        '
        'btnVolverMenu
        '
        Me.btnVolverMenu.BackColor = System.Drawing.Color.Orange
        Me.btnVolverMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenu.ForeColor = System.Drawing.Color.White
        Me.btnVolverMenu.Location = New System.Drawing.Point(183, 349)
        Me.btnVolverMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVolverMenu.Name = "btnVolverMenu"
        Me.btnVolverMenu.Size = New System.Drawing.Size(142, 36)
        Me.btnVolverMenu.TabIndex = 22
        Me.btnVolverMenu.Text = "Volver a Menú"
        Me.btnVolverMenu.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.Diseño_sin_título__1_
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 330)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 403)
        Me.Controls.Add(Me.btnVolverMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "EVA 3 - EPE 3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnActualizarBD As Button
    Friend WithEvents btnCrearUsuario As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVerDatosBD As Button
    Friend WithEvents txtRut As TextBox
    Friend WithEvents cmbCargo As ComboBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnBuscarRut As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVolverMenu As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
