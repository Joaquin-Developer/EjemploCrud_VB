<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormA
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
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botonGuardar = New System.Windows.Forms.Button()
        Me.datePickerFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.datePickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.labelEdad = New System.Windows.Forms.Label()
        Me.labelAntiguedad = New System.Windows.Forms.Label()
        Me.labelTrabajaActualmente = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(58, 15)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(188, 20)
        Me.txtFiltro.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar:"
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(12, 41)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.Size = New System.Drawing.Size(590, 209)
        Me.dataGrid.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.botonGuardar)
        Me.GroupBox1.Controls.Add(Me.datePickerFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.datePickerFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 158)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'botonGuardar
        '
        Me.botonGuardar.Location = New System.Drawing.Point(334, 17)
        Me.botonGuardar.Name = "botonGuardar"
        Me.botonGuardar.Size = New System.Drawing.Size(75, 23)
        Me.botonGuardar.TabIndex = 13
        Me.botonGuardar.Text = "Guardar"
        Me.botonGuardar.UseVisualStyleBackColor = True
        '
        'datePickerFechaIngreso
        '
        Me.datePickerFechaIngreso.Location = New System.Drawing.Point(128, 123)
        Me.datePickerFechaIngreso.Name = "datePickerFechaIngreso"
        Me.datePickerFechaIngreso.Size = New System.Drawing.Size(200, 20)
        Me.datePickerFechaIngreso.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha de ingreso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cedula:"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(128, 19)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(200, 20)
        Me.txtCedula.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mail:"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(128, 71)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(200, 20)
        Me.txtMail.TabIndex = 7
        '
        'datePickerFechaNacimiento
        '
        Me.datePickerFechaNacimiento.Location = New System.Drawing.Point(128, 97)
        Me.datePickerFechaNacimiento.Name = "datePickerFechaNacimiento"
        Me.datePickerFechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.datePickerFechaNacimiento.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha de nacimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre completo:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(128, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.labelEdad)
        Me.GroupBox2.Controls.Add(Me.labelAntiguedad)
        Me.GroupBox2.Controls.Add(Me.labelTrabajaActualmente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 65)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info"
        '
        'labelEdad
        '
        Me.labelEdad.AutoSize = True
        Me.labelEdad.Location = New System.Drawing.Point(121, 21)
        Me.labelEdad.Name = "labelEdad"
        Me.labelEdad.Size = New System.Drawing.Size(13, 13)
        Me.labelEdad.TabIndex = 5
        Me.labelEdad.Text = "0"
        '
        'labelAntiguedad
        '
        Me.labelAntiguedad.AutoSize = True
        Me.labelAntiguedad.Location = New System.Drawing.Point(121, 45)
        Me.labelAntiguedad.Name = "labelAntiguedad"
        Me.labelAntiguedad.Size = New System.Drawing.Size(13, 13)
        Me.labelAntiguedad.TabIndex = 4
        Me.labelAntiguedad.Text = "0"
        '
        'labelTrabajaActualmente
        '
        Me.labelTrabajaActualmente.AutoSize = True
        Me.labelTrabajaActualmente.Location = New System.Drawing.Point(121, 74)
        Me.labelTrabajaActualmente.Name = "labelTrabajaActualmente"
        Me.labelTrabajaActualmente.Size = New System.Drawing.Size(10, 13)
        Me.labelTrabajaActualmente.TabIndex = 3
        Me.labelTrabajaActualmente.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Antigüedad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Edad:"
        '
        'FormA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 424)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFiltro)
        Me.Name = "FormA"
        Me.Text = "FormA"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents datePickerFechaNacimiento As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents botonGuardar As Button
    Friend WithEvents datePickerFechaIngreso As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents labelEdad As Label
    Friend WithEvents labelAntiguedad As Label
    Friend WithEvents labelTrabajaActualmente As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
