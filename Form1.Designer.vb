<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNombre = New TextBox()
        txtEmpresa = New TextBox()
        txtTelefono = New TextBox()
        txtEmail = New TextBox()
        dtpFecha = New DateTimePicker()
        btnAgregar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        dgvContactos = New DataGridView()
        LabelNombre = New Label()
        LabelEmpresa = New Label()
        LabelTelefono = New Label()
        LabelEmail = New Label()
        LabelFecha = New Label()
        Label1 = New Label()
        Label2 = New Label()
        CType(dgvContactos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.BackColor = SystemColors.ScrollBar
        txtNombre.Location = New Point(135, 150)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(270, 23)
        txtNombre.TabIndex = 0
        ' 
        ' txtEmpresa
        ' 
        txtEmpresa.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmpresa.BackColor = SystemColors.ScrollBar
        txtEmpresa.Location = New Point(135, 202)
        txtEmpresa.Name = "txtEmpresa"
        txtEmpresa.Size = New Size(270, 23)
        txtEmpresa.TabIndex = 1
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefono.BackColor = SystemColors.ScrollBar
        txtTelefono.Location = New Point(135, 249)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(270, 23)
        txtTelefono.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmail.BackColor = SystemColors.ScrollBar
        txtEmail.Location = New Point(135, 300)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(270, 23)
        txtEmail.TabIndex = 3
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFecha.CalendarFont = New Font("Sitka Text", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpFecha.CalendarMonthBackground = SystemColors.ScrollBar
        dtpFecha.CalendarTitleBackColor = SystemColors.ScrollBar
        dtpFecha.CalendarTrailingForeColor = SystemColors.ScrollBar
        dtpFecha.Location = New Point(135, 358)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(270, 23)
        dtpFecha.TabIndex = 4
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnAgregar.Font = New Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgregar.Location = New Point(439, 400)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(100, 30)
        btnAgregar.TabIndex = 5
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnEditar.Font = New Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditar.Location = New Point(640, 400)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(100, 30)
        btnEditar.TabIndex = 6
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnEliminar.Font = New Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEliminar.Location = New Point(842, 400)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(100, 30)
        btnEliminar.TabIndex = 7
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' dgvContactos
        ' 
        dgvContactos.AllowUserToOrderColumns = True
        dgvContactos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvContactos.BackgroundColor = SystemColors.ScrollBar
        dgvContactos.BorderStyle = BorderStyle.Fixed3D
        dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvContactos.GridColor = SystemColors.WindowText
        dgvContactos.Location = New Point(439, 149)
        dgvContactos.Name = "dgvContactos"
        dgvContactos.Size = New Size(503, 232)
        dgvContactos.TabIndex = 8
        ' 
        ' LabelNombre
        ' 
        LabelNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelNombre.AutoSize = True
        LabelNombre.BackColor = Color.Transparent
        LabelNombre.Font = New Font("Sitka Text", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelNombre.ForeColor = SystemColors.Control
        LabelNombre.Location = New Point(49, 149)
        LabelNombre.Name = "LabelNombre"
        LabelNombre.Size = New Size(74, 24)
        LabelNombre.TabIndex = 9
        LabelNombre.Text = "Nombre"
        ' 
        ' LabelEmpresa
        ' 
        LabelEmpresa.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelEmpresa.AutoSize = True
        LabelEmpresa.BackColor = Color.Transparent
        LabelEmpresa.Font = New Font("Sitka Text", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelEmpresa.ForeColor = SystemColors.Control
        LabelEmpresa.Location = New Point(49, 202)
        LabelEmpresa.Name = "LabelEmpresa"
        LabelEmpresa.Size = New Size(80, 24)
        LabelEmpresa.TabIndex = 10
        LabelEmpresa.Text = "Empresa"
        ' 
        ' LabelTelefono
        ' 
        LabelTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelTelefono.AutoSize = True
        LabelTelefono.BackColor = Color.Transparent
        LabelTelefono.Font = New Font("Sitka Text", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTelefono.ForeColor = SystemColors.Control
        LabelTelefono.Location = New Point(49, 249)
        LabelTelefono.Name = "LabelTelefono"
        LabelTelefono.Size = New Size(77, 24)
        LabelTelefono.TabIndex = 11
        LabelTelefono.Text = "Telefono"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelEmail.AutoSize = True
        LabelEmail.BackColor = Color.Transparent
        LabelEmail.Font = New Font("Sitka Text", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelEmail.ForeColor = SystemColors.Control
        LabelEmail.Location = New Point(49, 300)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(56, 24)
        LabelEmail.TabIndex = 12
        LabelEmail.Text = "Email"
        ' 
        ' LabelFecha
        ' 
        LabelFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelFecha.AutoSize = True
        LabelFecha.BackColor = Color.Transparent
        LabelFecha.Font = New Font("Sitka Text", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelFecha.ForeColor = SystemColors.Control
        LabelFecha.Location = New Point(49, 357)
        LabelFecha.Name = "LabelFecha"
        LabelFecha.Size = New Size(55, 24)
        LabelFecha.TabIndex = 13
        LabelFecha.Text = "Fecha"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(295, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(404, 61)
        Label1.TabIndex = 14
        Label1.Text = "Business Agenda"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(269, 483)
        Label2.Name = "Label2"
        Label2.Size = New Size(450, 23)
        Label2.TabIndex = 15
        Label2.Text = "© All rights reserved by Yuri Alexander Pagel Krüger"
        ' 
        ' Form1
        ' 
        BackColor = SystemColors.ScrollBar
        BackgroundImage = My.Resources.Resources.Fondo
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1008, 537)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LabelFecha)
        Controls.Add(LabelEmail)
        Controls.Add(LabelTelefono)
        Controls.Add(LabelEmpresa)
        Controls.Add(LabelNombre)
        Controls.Add(dgvContactos)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnAgregar)
        Controls.Add(dtpFecha)
        Controls.Add(txtEmail)
        Controls.Add(txtTelefono)
        Controls.Add(txtEmpresa)
        Controls.Add(txtNombre)
        Name = "Form1"
        Text = "Agenda Empresarial"
        CType(dgvContactos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvContactos As DataGridView
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelEmpresa As Label
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class