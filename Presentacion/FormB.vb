Public Class FormB
    Public Property personas As New List(Of Persona)

    Public Sub FormA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar persona 1
        Dim persona1 As New Persona()
        persona1.cedula = 11111111
        persona1.nombre = "Ismael Schellemberg"
        persona1.mail = "ismasch@gmail.com"
        persona1.fechaNacimiento = New Date(1989, 11, 24)
        persona1.fechaIngreso = New Date(2020, 7, 16)
        personas.Add(persona1)
        'Cargar persona 2
        Dim persona2 As New Persona()
        persona2.cedula = 22222222
        persona2.nombre = "Hector Nuñez"
        persona2.mail = "hector1980@gmail.com"
        persona2.fechaNacimiento = New Date(1980, 4, 15)
        persona2.fechaIngreso = New Date(2010, 9, 1)
        personas.Add(persona2)
        'Cargar persona 3
        Dim persona3 As New Persona()
        persona3.cedula = 33333333
        persona3.nombre = "Micaela Gomez"
        persona3.mail = "micagomez17@gmail.com"
        persona3.fechaNacimiento = New Date(2001, 8, 8)
        persona3.fechaIngreso = New Date(2022, 9, 1)
        personas.Add(persona3)
        'Creo data set
        Dim dataSet As New DataSet
        'Cargar columnas Cedula, Nombre, Mail, Fecha nacimiento, Fecha ingreso
        Dim dataTable As DataTable
        dataTable = dataSet.Tables.Add()
        dataTable.Columns.Add("Cedula")
        dataTable.Columns.Add("Nombre")
        dataTable.Columns.Add("Mail")
        dataTable.Columns.Add("Fecha nacimiento")
        dataTable.Columns.Add("Fecha ingreso")
        'Agregar personas
        For Each persona As Persona In personas
            'Para cada persona, cargar una fila con sus datos
            dataTable.Rows.Add(persona.cedula, persona.nombre, persona.mail, persona.fechaNacimiento, persona.fechaIngreso)
        Next
        'Asignar data source
        dataGrid.DataSource = dataTable
        'Refrescar tabla
        dataGrid.Refresh()
    End Sub

    Public Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim dataSet As New DataSet 'Cargar data grid
        Dim dataTable As DataTable
        dataTable = dataSet.Tables.Add() 'Cargar columnas
        dataTable.Columns.Add("Cedula") 'Cedula
        dataTable.Columns.Add("Nombre") 'Nombre
        dataTable.Columns.Add("Mail") 'Mail
        dataTable.Columns.Add("Fecha nacimiento") 'Fecha nacimiento
        dataTable.Columns.Add("Fecha ingreso") 'Fecha ingreso
        'Agregar personas
        For Each persona As Persona In personas
            Dim filtro As String
            filtro = txtFiltro.Text.ToLower() 'Paso el filtro a lowercase
            If (filtro.Length > 0) Then 'Si el filtro contiene texto
                'Verificar si debo mostrar la persona según el texto de filtrado
                If (persona.nombre.ToLower().Contains(filtro) Or persona.mail.ToLower().Contains(filtro) Or persona.cedula.ToString().Contains(filtro)) Then
                    dataTable.Rows.Add(persona.cedula, persona.nombre, persona.mail, persona.fechaNacimiento, persona.fechaIngreso)
                End If
            Else
                'Si no hay texto de búsqueda, todas las personas son válidas
                'Agrego fila con información de la persona
                dataTable.Rows.Add(persona.cedula, persona.nombre, persona.mail, persona.fechaNacimiento, persona.fechaIngreso)
            End If
        Next
        dataGrid.DataSource = dataTable 'Asignar data source
        dataGrid.Refresh() 'Refrescar tabla
    End Sub

    Public Sub botonGuardar_Click(sender As Object, e As EventArgs) Handles botonGuardar.Click
        Try
            Dim cedula As Long 'Declaro variables
            Dim nombre As String
            Dim mail As String
            Dim fechaNacimiento As Date
            Dim fechaIngreso As Date
            cedula = CLng(txtCedula.Text) 'Asigno variables
            nombre = txtNombre.Text
            mail = txtMail.Text
            fechaNacimiento = datePickerFechaNacimiento.Value
            fechaIngreso = datePickerFechaIngreso.Value
            Dim persona As New Persona() 'Creo objeto persona
            persona.cedula = cedula 'Cargo variables en persona
            persona.nombre = nombre
            persona.mail = mail
            persona.fechaNacimiento = fechaNacimiento
            persona.fechaIngreso = fechaIngreso
            Dim encontrado As Boolean = False 'Buscar si existe por cedula
            For Each personaExistente As Persona In personas
                If (personaExistente.cedula = persona.cedula) Then 'Si existe, actualizar información
                    personaExistente.nombre = persona.nombre
                    personaExistente.mail = persona.mail
                    personaExistente.fechaNacimiento = persona.fechaNacimiento
                    personaExistente.fechaIngreso = persona.fechaIngreso
                    encontrado = True 'Marco encontrado como True
                End If
            Next
            If Not encontrado Then
                personas.Add(persona) 'Si no existe, agregar
            End If
            Dim dataSet As New DataSet 'Cargar data grid
            Dim dataTable As DataTable
            dataTable = dataSet.Tables.Add() 'Cargar columnas
            dataTable.Columns.Add("Cedula") 'Cedula
            dataTable.Columns.Add("Nombre") 'Nombre
            dataTable.Columns.Add("Mail") 'Mail
            dataTable.Columns.Add("Fecha nacimiento") 'Fecha nacimiento
            dataTable.Columns.Add("Fecha ingreso") 'Fecha ingreso
            For Each personaEnLista As Persona In personas 'Agregar personas
                Dim filtro As String
                filtro = txtFiltro.Text.ToLower() 'Paso el filtro a lowercase
                If (filtro.Length > 0) Then 'Si el filtro contiene texto
                    'Verificar si debo mostrar la persona según el texto de filtrado
                    If (personaEnLista.nombre.ToLower().Contains(filtro) Or personaEnLista.mail.ToLower().Contains(filtro) Or personaEnLista.cedula.ToString().Contains(filtro)) Then
                        dataTable.Rows.Add(personaEnLista.cedula, personaEnLista.nombre, personaEnLista.mail, personaEnLista.fechaNacimiento, personaEnLista.fechaIngreso)
                    End If
                Else
                    'Si no hay texto de búsqueda, todas las personas son válidas
                    'Agrego fila con información de la persona
                    dataTable.Rows.Add(personaEnLista.cedula, personaEnLista.nombre, personaEnLista.mail, personaEnLista.fechaNacimiento, personaEnLista.fechaIngreso)
                End If
            Next
            dataGrid.DataSource = dataTable 'Asignar data source
            dataGrid.Refresh() 'Refrescar tabla
        Catch ex As Exception
            MsgBox(ex.Message) 'Mostrar error
        End Try
    End Sub

    Public Sub dataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid.CellClick
        Dim cedula As Long
        cedula = dataGrid.Rows(e.RowIndex).Cells(0).Value 'Obtener cedula de celda seleccionada
        For Each persona As Persona In personas
            If (persona.cedula = cedula) Then
                Dim cedulaPersona As String = persona.cedula.ToString() 'Leer datos de persona
                Dim nombre As String = persona.nombre
                Dim mail As String = persona.mail
                Dim fechaNacimiento As Date = persona.fechaNacimiento
                Dim fechaIngreso As Date = persona.fechaIngreso
                txtCedula.Text = cedulaPersona 'Cargar datos en textbox
                txtNombre.Text = nombre
                txtMail.Text = mail
                datePickerFechaNacimiento.Value = fechaNacimiento
                datePickerFechaIngreso.Value = fechaIngreso
                Dim edad As Long = DateDiff(DateInterval.Year, persona.fechaNacimiento, Date.Now) 'Calcular edad y antiguedad
                Dim antiguedad As Long = Date.Now.Year - persona.fechaIngreso.Year
                labelEdad.Text = edad.ToString() 'Mostrar valores en labels
                labelAntiguedad.Text = antiguedad.ToString()
            End If
        Next
    End Sub

    Public Sub CargarDataGrid()
        Dim dataSet As New DataSet
        Dim dataTable As DataTable
        dataTable = dataSet.Tables.Add() 'Cargar columnas
        dataTable.Columns.Add("Cedula") 'Cedula
        dataTable.Columns.Add("Nombre") 'Nombre
        dataTable.Columns.Add("Mail") 'Mail
        dataTable.Columns.Add("Fecha nacimiento") 'Fecha nacimiento
        dataTable.Columns.Add("Fecha ingreso") 'Fecha ingreso
        For Each persona As Persona In personas 'Agregar personas
            Dim filtro As String 'Declaro variable
            filtro = txtFiltro.Text.ToLower() 'Paso el filtro a lowercase
            If (filtro.Length > 0) Then 'Si el filtro contiene texto
                'Verificar si debo mostrar la persona según el texto de filtrado
                If (persona.nombre.ToLower().Contains(filtro) Or persona.mail.ToLower().Contains(filtro) Or persona.cedula.ToString().Contains(filtro)) Then
                    dataTable.Rows.Add(persona.cedula, persona.nombre, persona.mail, persona.fechaNacimiento, persona.fechaIngreso)
                End If
            Else
                'Si no hay texto de búsqueda, todas las personas son válidas
                'Agrego fila con información de la persona
                dataTable.Rows.Add(persona.cedula, persona.nombre, persona.mail, persona.fechaNacimiento, persona.fechaIngreso)
            End If
        Next
        dataGrid.DataSource = dataTable 'Asignar data source
        dataGrid.Refresh() 'Refrescar tabla
    End Sub
End Class