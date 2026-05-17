' Business Agenda v1.0.0
' Autor: Yuri Alexander Pagel Krüger
' © 2025 Yuri Alexander Pagel Krüger. Todos los derechos reservados.
Imports System.Drawing
Imports System.IO
Imports Newtonsoft.Json
Public Class Form1
    Dim contactoId As Integer = 0
    Dim rutaJson As String = Path.Combine(Application.StartupPath, "AgendaContactos.json")
    Dim listaContactos As New List(Of Contacto)
    Public Class Contacto
        Public Property Id As Integer
        Public Property Nombre As String
        Public Property Empresa As String
        Public Property Telefono As String
        Public Property Email As String
        Public Property FechaContacto As Date
    End Class
    Public Sub New()
        InitializeComponent()
        If Not File.Exists(rutaJson) Then
            Dim listaInicial As New List(Of Contacto)
            Dim jsonContenido As String = JsonConvert.SerializeObject(listaInicial, Formatting.Indented)
            File.WriteAllText(rutaJson, jsonContenido)
        End If
        Dim iconPath As String = System.IO.Path.Combine(Application.StartupPath, "Icon.ico")
        If System.IO.File.Exists(iconPath) Then
            Me.Icon = New Icon(iconPath)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = True
            Me.ControlBox = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fondoPath As String = System.IO.Path.Combine(Application.StartupPath, "Fondo.jpg")
        Me.BackgroundImage = Image.FromFile(fondoPath)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.Text = "Business Agenda"
        Me.AutoScaleMode = AutoScaleMode.Font
        dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvContactos.MultiSelect = False
        dgvContactos.AllowUserToAddRows = False
        dgvContactos.ReadOnly = True
        dgvContactos.RowHeadersVisible = False
        dgvContactos.AutoGenerateColumns = False
        With dgvContactos.DefaultCellStyle
            .SelectionBackColor = Color.Gainsboro
            .SelectionForeColor = Color.Black
        End With
        With dgvContactos.RowsDefaultCellStyle
            .BackColor = Color.Gainsboro
            .ForeColor = Color.Black
        End With
        dgvContactos.Columns.Clear()
        Dim colId As New DataGridViewTextBoxColumn() With {.Name = "Id", .HeaderText = "Id", .DataPropertyName = "Id", .Visible = False}
        dgvContactos.Columns.Add(colId)
        dgvContactos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Nombre", .HeaderText = "Nombre", .DataPropertyName = "Nombre"})
        dgvContactos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Empresa", .HeaderText = "Empresa", .DataPropertyName = "Empresa"})
        dgvContactos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Telefono", .HeaderText = "Teléfono", .DataPropertyName = "Telefono"})
        dgvContactos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Email", .HeaderText = "Email", .DataPropertyName = "Email"})
        dgvContactos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "FechaContacto", .HeaderText = "Fecha", .DataPropertyName = "FechaContacto", .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "dd/MM/yyyy"}})
        txtNombre.ForeColor = Color.Black
        txtEmpresa.ForeColor = Color.Black
        txtTelefono.ForeColor = Color.Black
        txtEmail.ForeColor = Color.Black
        txtNombre.BackColor = Color.White
        txtEmpresa.BackColor = Color.White
        txtTelefono.BackColor = Color.White
        txtEmail.BackColor = Color.White
        CargarContactos()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nuevo As New Contacto With {
            .Id = If(listaContactos.Count = 0, 1, listaContactos.Max(Function(c) c.Id) + 1),
            .Nombre = txtNombre.Text,
            .Empresa = txtEmpresa.Text,
            .Telefono = txtTelefono.Text,
            .Email = txtEmail.Text,
            .FechaContacto = dtpFecha.Value.Date
        }
        listaContactos.Add(nuevo)
        GuardarContactos()
        LimpiarCampos()
        CargarContactos()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If contactoId = 0 Then Exit Sub
        Dim contacto = listaContactos.FirstOrDefault(Function(c) c.Id = contactoId)
        If contacto IsNot Nothing Then
            contacto.Nombre = txtNombre.Text
            contacto.Empresa = txtEmpresa.Text
            contacto.Telefono = txtTelefono.Text
            contacto.Email = txtEmail.Text
            contacto.FechaContacto = dtpFecha.Value.Date
            GuardarContactos()
            LimpiarCampos()
            CargarContactos()
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If contactoId = 0 Then Exit Sub
        listaContactos.RemoveAll(Function(c) c.Id = contactoId)
        GuardarContactos()
        LimpiarCampos()
        CargarContactos()
    End Sub
    Private Sub dgvContactos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvContactos.SelectionChanged
        If dgvContactos.SelectedRows.Count = 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvContactos.SelectedRows(0)
        If row Is Nothing OrElse row.Cells.Count = 0 Then Exit Sub
        Try
            contactoId = Convert.ToInt32(row.Cells("Id").Value)
            txtNombre.Text = row.Cells("Nombre").Value?.ToString()
            txtEmpresa.Text = row.Cells("Empresa").Value?.ToString()
            txtTelefono.Text = row.Cells("Telefono").Value?.ToString()
            txtEmail.Text = row.Cells("Email").Value?.ToString()
            Dim contacto = listaContactos.FirstOrDefault(Function(c) c.Id = contactoId)
            If contacto IsNot Nothing Then
                dtpFecha.Value = contacto.FechaContacto
            End If
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar contacto: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarContactos()
        If File.Exists(rutaJson) Then
            Dim contenido As String = File.ReadAllText(rutaJson)
            listaContactos = JsonConvert.DeserializeObject(Of List(Of Contacto))(contenido)
        End If
        dgvContactos.DataSource = Nothing
        dgvContactos.DataSource = listaContactos
    End Sub
    Private Sub GuardarContactos()
        Dim json As String = JsonConvert.SerializeObject(listaContactos, Formatting.Indented)
        File.WriteAllText(rutaJson, json)
    End Sub
    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtEmpresa.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        dtpFecha.Value = DateTime.Now
        contactoId = 0
    End Sub
    Private Sub LabelEmail_Click(sender As Object, e As EventArgs) Handles LabelEmail.Click
    End Sub
    Private Sub dgvContactos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContactos.CellContentClick
    End Sub
End Class