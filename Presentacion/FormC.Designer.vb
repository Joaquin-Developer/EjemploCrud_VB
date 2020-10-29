<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.le = New System.Windows.Forms.Label()
        Me.la = New System.Windows.Forms.Label()
        Me.labelTrabajaActualmente = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.botonGuardar = New System.Windows.Forms.Button()
        Me.fi = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ced = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ml = New System.Windows.Forms.TextBox()
        Me.fn = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dx = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'le
        '
        Me.le.AutoSize = True
        Me.le.Location = New System.Drawing.Point(121, 21)
        Me.le.Name = "le"
        Me.le.Size = New System.Drawing.Size(13, 13)
        Me.le.TabIndex = 5
        Me.le.Text = "0"
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.Location = New System.Drawing.Point(121, 45)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(13, 13)
        Me.la.TabIndex = 4
        Me.la.Text = "0"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Edad:"
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
        'fi
        '
        Me.fi.Location = New System.Drawing.Point(128, 123)
        Me.fi.Name = "fi"
        Me.fi.Size = New System.Drawing.Size(200, 20)
        Me.fi.TabIndex = 12
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
        'ced
        '
        Me.ced.Location = New System.Drawing.Point(128, 19)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(200, 20)
        Me.ced.TabIndex = 9
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.le)
        Me.GroupBox2.Controls.Add(Me.la)
        Me.GroupBox2.Controls.Add(Me.labelTrabajaActualmente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 65)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info"
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
        'ml
        '
        Me.ml.Location = New System.Drawing.Point(128, 71)
        Me.ml.Name = "ml"
        Me.ml.Size = New System.Drawing.Size(200, 20)
        Me.ml.TabIndex = 7
        '
        'fn
        '
        Me.fn.Location = New System.Drawing.Point(128, 97)
        Me.fn.Name = "fn"
        Me.fn.Size = New System.Drawing.Size(200, 20)
        Me.fn.TabIndex = 6
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
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(128, 45)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(200, 20)
        Me.nom.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.botonGuardar)
        Me.GroupBox1.Controls.Add(Me.fi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ced)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ml)
        Me.GroupBox1.Controls.Add(Me.fn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 158)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
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
        'dx
        '
        Me.dx.AllowUserToAddRows = False
        Me.dx.AllowUserToDeleteRows = False
        Me.dx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dx.Location = New System.Drawing.Point(12, 34)
        Me.dx.Name = "dx"
        Me.dx.Size = New System.Drawing.Size(590, 209)
        Me.dx.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Buscar:"
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(58, 8)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(188, 20)
        Me.tf.TabIndex = 5
        '
        'FormC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 408)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tf)
        Me.Name = "FormC"
        Me.Text = "FormC"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents le As Label
    Friend WithEvents la As Label
    Friend WithEvents labelTrabajaActualmente As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents botonGuardar As Button
    Friend WithEvents fi As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ced As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ml As TextBox
    Friend WithEvents fn As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dx As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tf As TextBox
End Class
