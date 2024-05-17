Imports System.Data.SqlClient

Public Class Form1
    Dim query As String
    'Create a constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ' Add any initialization after the InitializeComponent() call.
        'Create a new instance of the Connection class

        query = "select id, nombre from estado"
        cboEstado.DataSource = Connection.SelectQuery(query)
        cboEstado.DisplayMember = "nombre"
        cboEstado.ValueMember = "id"

    End Sub

    Private connectionString As String = "Data Source=LAPTOP-03SGE49J; Initial Catalog=CorreosDeMexico1;Integrated Security=True"

    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged
        If cboEstado.SelectedValue IsNot Nothing Then
            Dim idEstado As Integer
            If Integer.TryParse(cboEstado.SelectedValue.ToString(), idEstado) Then
                CargarMunicipios(idEstado)
            End If
        End If
    End Sub

    Private Sub CargarMunicipios(idEstado As Integer)
        Dim query As String = "SELECT id, nombre FROM municipio WHERE idEstado = @idEstado"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add(New SqlParameter("@idEstado", idEstado))

                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()

                    adapter.Fill(table)

                    cboMunicipio.DataSource = table
                    cboMunicipio.DisplayMember = "nombre"
                    cboMunicipio.ValueMember = "id"
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar municipios: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cboMunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMunicipio.SelectedIndexChanged
        If String.IsNullOrEmpty(cboMunicipio.Text) Then
            Exit Sub
        End If

        Dim nombreMunicipio As String = cboMunicipio.Text
        CargarDatosMunicipio(nombreMunicipio)
    End Sub

    Private Sub CargarDatosMunicipio(nombreMunicipio As String)
        Dim query As String = "SELECT * FROM VnombreBUSQUEDA WHERE [Nombre Municipio] = @nombreMunicipio"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add(New SqlParameter("@nombreMunicipio", nombreMunicipio))

                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()

                    adapter.Fill(table)

                    DataGridView1.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos del municipio: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
