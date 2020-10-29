Public Class Persona
    Public Property cedula As Long
    Public Property nombre As String
    Public Property mail As String
    Public Property fechaNacimiento As Date
    Public Property fechaIngreso As Date

    Public Sub New()

    End Sub

    Public Sub New(pCedula As Long, pNombre As String, pMail As String, pFechaNacimiento As Date, pFechaIngreso As Date)
        Me.cedula = pCedula
        Me.nombre = pNombre
        Me.mail = pMail
        Me.fechaNacimiento = pFechaNacimiento
        Me.fechaIngreso = pFechaIngreso
    End Sub
End Class
