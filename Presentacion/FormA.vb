Public Class FormA

    'Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    'End Sub

    Dim personas As New List(Of Persona)
    Dim personaEncontrada As Persona
    Dim habilitarFiltro As Boolean
    'Dim cantidadPersonas As Integer

    Private Function AplicarFiltro(persona As Persona) As Boolean
        If (habilitarFiltro) Then
            Dim filtro As String = txtFiltro.Text.ToLower()

            If (persona.nombre.ToLower().Contains(filtro)) Then
                Return True
            End If



            If (persona.mail.ToLower().Contains(filtro)) Then
                Return True
            End If


            If (persona.cedula.ToString().Contains(filtro)) Then
                Return True
            End If

            'La persona no contiene ningún valor que sirva para el filtro de búsqueda
            Return False
        Else
            Return True
        End If

    End Function

    'Private Sub txtMail_TextChanged(sender As Object, e As EventArgs) Handles txtMail.TextChanged

    'End Sub

    Private Sub FormA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'guardarPersona(New Persona(11111111, "Ismael Schellemberg", "ismasch@gmail.com", New Date(1989, 11, 24), New Date(2020, 7, 16)))
        guardarPersona(New Persona(11111111, "Ismael Schellemberg", "ismasch@gmail.com", New Date(1989, 11, 24), New Date(2020, 7, 16)))

        guardarPersona(New Persona(22222222, "Hector Nuñez", "hector1980@gmail.com", New Date(1980, 4, 15), New Date(2010, 9, 1)))


        guardarPersona(New Persona(33333333, "Micaela Gomez", "micagomez17@gmail.com", New Date(2001, 8, 8), New Date(2022, 9, 1)))
        cargarDataGrid()
    End Sub

    Private Sub guardarPersona(persona As Persona)
        buscarPersona(persona.cedula) 'guarda resultado en personaEncontrada
        If (personaEncontrada IsNot Nothing) Then
            personaEncontrada.nombre = persona.nombre
            personaEncontrada.mail = persona.mail



            personaEncontrada.fechaNacimiento = persona.fechaNacimiento
            personaEncontrada.fechaIngreso = persona.fechaIngreso
        Else
            personas.Add(persona)
        End If

        cargarDataGrid()
    End Sub

    Private Sub botonGuardar_Click(sender As Object, e As EventArgs) Handles botonGuardar.Click
        Try
            Dim persona As New Persona()
            persona.cedula = CLng(txtCedula.Text)

            persona.nombre = txtNombre.Text
            persona.mail = txtMail.Text



            persona.fechaNacimiento = datePickerFechaNacimiento.Value
            persona.fechaIngreso = datePickerFechaIngreso.Value
            guardarPersona(persona)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscarPersona(cedula As Long)
        personaEncontrada = Nothing
        For Each persona As Persona In personas
            If (persona.cedula = cedula) Then
                personaEncontrada = persona
                Return
            End If



        Next
    End Sub

    Private Sub cargarDataGrid()
        Dim dataSet As New DataSet()
        Dim dataTable As DataTable = dataSet.Tables.Add()
        dataTable.Columns.Add("Cedula")
        dataTable.Columns.Add("Nombre")
        dataTable.Columns.Add("Mail")


        dataTable.Columns.Add("Fecha nacimiento")
        dataTable.Columns.Add("Fecha ingreso")
        For Each persona As Persona In personas
            If (AplicarFiltro(persona)) Then
                'dataTable.Rows.Add(persona.cedula)
                'dataTable.Rows.Add(persona.nombre)
                'dataTable.Rows.Add(persona.mail)
                'dataTable.Rows.Add(persona.fechaNacimiento)
                'dataTable.Rows.Add(persona.fechaIngreso)
                dataTable.Rows.Add(persona.cedula, persona.nombre, persona.mail, persona.fechaNacimiento, persona.fechaIngreso)
            End If
        Next
        dataGrid.DataSource = dataTable


        dataGrid.Refresh()
    End Sub

    Private Sub dataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid.CellClick
        Dim cedula As Long = dataGrid.Rows(e.RowIndex).Cells(0).Value

        buscarPersona(cedula) 'guarda resultado en personaEncontrada

        If (personaEncontrada IsNot Nothing) Then

            txtCedula.Text = personaEncontrada.cedula.ToString()
            labelEdad.Text = CalcularDiferenciaAños(personaEncontrada.fechaNacimiento).ToString()
            labelAntiguedad.Text = CalcularDiferenciaAños(personaEncontrada.fechaIngreso).ToString()


            txtMail.Text = personaEncontrada.mail
            datePickerFechaIngreso.Value = personaEncontrada.fechaIngreso

            datePickerFechaNacimiento.Value = personaEncontrada.fechaNacimiento
            txtNombre.Text = personaEncontrada.nombre


        End If
    End Sub

    Private Function CalcularDiferenciaAños(fecha As Date) As Long
        Dim fechaHoy = Date.Now
        Return DateDiff(DateInterval.Year, fecha, fechaHoy)
    End Function

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'Cada vez que cambie el texto de búsqueda quiero refrescar la pantalla
        habilitarFiltro = txtFiltro.Text.Length > 0

        cargarDataGrid()
    End Sub

    'Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged

    'End Sub

    'Private Sub labelEdad_Click(sender As Object, e As EventArgs) Handles labelEdad.Click

    'End Sub
End Class