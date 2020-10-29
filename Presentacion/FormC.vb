Public Class FormC
    Dim prs As New List(Of Persona)

    Private Sub FormA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Accion(New Persona(11111111, "Ismael Schellemberg", "ismasch@gmail.com", New Date(1989, 11, 24), New Date(2020, 7, 16)))
        Accion(New Persona(22222222, "Hector Nuñez", "hector1980@gmail.com", New Date(1980, 4, 15), New Date(2010, 9, 1)))
        Accion(New Persona(33333333, "Micaela Gomez", "micagomez17@gmail.com", New Date(2001, 8, 8), New Date(2022, 9, 1)))
        datos()
    End Sub

    Private Sub tf_TextChanged(sender As Object, e As EventArgs) Handles tf.TextChanged
        datos()
    End Sub

    Private Sub botonGuardar_Click(sender As Object, e As EventArgs) Handles botonGuardar.Click
        Try
            Accion(New Persona(CLng(ced.Text), nom.Text, ml.Text, fn.Value, fi.Value))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dx_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dx.CellClick
        Dim x As Long = dx.Rows(e.RowIndex).Cells(0).Value
        Dim y As Persona = Texto(x)
        If (y IsNot Nothing) Then
            CD(y)
            CI(y)
        End If
    End Sub

    Private Function Texto(cedula As Long) As Persona
        For Each i As Persona In prs
            If (i.cedula = cedula) Then
                Return i
            End If
        Next
        Return Nothing
    End Function

    Private Sub Accion(x As Persona)
        Dim valor As Persona = Texto(x.cedula)
        If (valor IsNot Nothing) Then
            valor.nombre = x.nombre
            valor.mail = x.mail
            valor.fechaNacimiento = x.fechaNacimiento
            valor.fechaIngreso = x.fechaIngreso
        Else
            prs.Add(x)
        End If

        datos()
    End Sub

    Private Sub datos()
        Dim s As New DataSet()

        Dim t As DataTable = s.Tables.Add()
        t.Columns.Add("Cedula")
        t.Columns.Add("Nombre")
        t.Columns.Add("Mail")
        t.Columns.Add("Fecha nacimiento")
        t.Columns.Add("Fecha ingreso")

        For Each x As Persona In prs
            If (Prueba(x)) Then
                t.Rows.Add(x.cedula, x.nombre, x.mail, x.fechaNacimiento, x.fechaIngreso)
            End If
        Next
        dx.DataSource = t
        dx.Refresh()
    End Sub

    Private Function Prueba(persona As Persona)
        Dim f As String = tf.Text.ToLower()

        If (f.Length = 0 Or persona.nombre.ToLower().Contains(f) Or persona.mail.ToLower().Contains(f) Or persona.cedula.ToString().Contains(f)) Then
            Return True
        End If

        Return False
    End Function

    Private Sub CD(p1 As Persona)
        ced.Text = p1.cedula.ToString()
        nom.Text = p1.nombre
        ml.Text = p1.mail
        fn.Value = p1.fechaNacimiento
        fi.Value = p1.fechaIngreso
    End Sub

    Private Sub CI(obj As Persona)
        le.Text = D(obj.fechaNacimiento).ToString()
        la.Text = D(obj.fechaIngreso).ToString()
    End Sub

    Private Function D(f As Date) As Long
        Return DateDiff(DateInterval.Year, f, Date.Now)
    End Function
End Class