<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbxNacionalidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTiempo = New System.Windows.Forms.TextBox()
        Me.TxtKm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxEquipo = New System.Windows.Forms.ComboBox()
        Me.TxtEtapa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BttGuardar = New System.Windows.Forms.Button()
        Me.BttMostrar = New System.Windows.Forms.Button()
        Me.BttConsultar = New System.Windows.Forms.Button()
        Me.BttActualizar = New System.Windows.Forms.Button()
        Me.BttOrdenar = New System.Windows.Forms.Button()
        Me.BttLvector = New System.Windows.Forms.Button()
        Me.BttLentrada = New System.Windows.Forms.Button()
        Me.BttSalir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtconsulta = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.CbxNacionalidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtTiempo)
        Me.GroupBox1.Controls.Add(Me.TxtKm)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CbxEquipo)
        Me.GroupBox1.Controls.Add(Me.TxtEtapa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1048, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del corredor"
        '
        'CbxNacionalidad
        '
        Me.CbxNacionalidad.FormattingEnabled = True
        Me.CbxNacionalidad.Items.AddRange(New Object() {"Guatemalteco", "Extranjero"})
        Me.CbxNacionalidad.Location = New System.Drawing.Point(792, 79)
        Me.CbxNacionalidad.Name = "CbxNacionalidad"
        Me.CbxNacionalidad.Size = New System.Drawing.Size(233, 28)
        Me.CbxNacionalidad.TabIndex = 9
        Me.CbxNacionalidad.Text = "Seleccione una"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(792, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nacionalidad"
        '
        'TxtTiempo
        '
        Me.TxtTiempo.Location = New System.Drawing.Point(496, 79)
        Me.TxtTiempo.Name = "TxtTiempo"
        Me.TxtTiempo.Size = New System.Drawing.Size(246, 27)
        Me.TxtTiempo.TabIndex = 7
        '
        'TxtKm
        '
        Me.TxtKm.Location = New System.Drawing.Point(496, 39)
        Me.TxtKm.Name = "TxtKm"
        Me.TxtKm.Size = New System.Drawing.Size(246, 27)
        Me.TxtKm.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(355, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tiempo (min)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Km recorridos"
        '
        'CbxEquipo
        '
        Me.CbxEquipo.FormattingEnabled = True
        Me.CbxEquipo.Items.AddRange(New Object() {"Sky", "Movistar", "Pro Cycling", "Pro team"})
        Me.CbxEquipo.Location = New System.Drawing.Point(116, 88)
        Me.CbxEquipo.Name = "CbxEquipo"
        Me.CbxEquipo.Size = New System.Drawing.Size(209, 28)
        Me.CbxEquipo.TabIndex = 3
        Me.CbxEquipo.Text = "Seleccione un equipo"
        '
        'TxtEtapa
        '
        Me.TxtEtapa.Location = New System.Drawing.Point(116, 43)
        Me.TxtEtapa.Name = "TxtEtapa"
        Me.TxtEtapa.Size = New System.Drawing.Size(208, 27)
        Me.TxtEtapa.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. de etapa"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(805, 188)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. de etapa"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Equipo"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Km recorridos"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tiempo (min)"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nacionalidad"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Tiempo total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'BttGuardar
        '
        Me.BttGuardar.BackColor = System.Drawing.SystemColors.Info
        Me.BttGuardar.Location = New System.Drawing.Point(37, 411)
        Me.BttGuardar.Name = "BttGuardar"
        Me.BttGuardar.Size = New System.Drawing.Size(94, 29)
        Me.BttGuardar.TabIndex = 2
        Me.BttGuardar.Text = "Guardar"
        Me.BttGuardar.UseVisualStyleBackColor = False
        '
        'BttMostrar
        '
        Me.BttMostrar.BackColor = System.Drawing.SystemColors.Info
        Me.BttMostrar.Location = New System.Drawing.Point(227, 411)
        Me.BttMostrar.Name = "BttMostrar"
        Me.BttMostrar.Size = New System.Drawing.Size(94, 29)
        Me.BttMostrar.TabIndex = 3
        Me.BttMostrar.Text = "Mostrar"
        Me.BttMostrar.UseVisualStyleBackColor = False
        '
        'BttConsultar
        '
        Me.BttConsultar.BackColor = System.Drawing.SystemColors.Info
        Me.BttConsultar.Location = New System.Drawing.Point(734, 411)
        Me.BttConsultar.Name = "BttConsultar"
        Me.BttConsultar.Size = New System.Drawing.Size(94, 29)
        Me.BttConsultar.TabIndex = 4
        Me.BttConsultar.Text = "Consultar"
        Me.BttConsultar.UseVisualStyleBackColor = False
        '
        'BttActualizar
        '
        Me.BttActualizar.BackColor = System.Drawing.SystemColors.Info
        Me.BttActualizar.Location = New System.Drawing.Point(397, 411)
        Me.BttActualizar.Name = "BttActualizar"
        Me.BttActualizar.Size = New System.Drawing.Size(94, 29)
        Me.BttActualizar.TabIndex = 5
        Me.BttActualizar.Text = "Actualizar"
        Me.BttActualizar.UseVisualStyleBackColor = False
        '
        'BttOrdenar
        '
        Me.BttOrdenar.BackColor = System.Drawing.SystemColors.Info
        Me.BttOrdenar.Location = New System.Drawing.Point(892, 207)
        Me.BttOrdenar.Name = "BttOrdenar"
        Me.BttOrdenar.Size = New System.Drawing.Size(156, 29)
        Me.BttOrdenar.TabIndex = 6
        Me.BttOrdenar.Text = "Ordenar Ascendente"
        Me.BttOrdenar.UseVisualStyleBackColor = False
        '
        'BttLvector
        '
        Me.BttLvector.BackColor = System.Drawing.SystemColors.Info
        Me.BttLvector.Location = New System.Drawing.Point(892, 253)
        Me.BttLvector.Name = "BttLvector"
        Me.BttLvector.Size = New System.Drawing.Size(156, 29)
        Me.BttLvector.TabIndex = 7
        Me.BttLvector.Text = "Limpiar Vectores"
        Me.BttLvector.UseVisualStyleBackColor = False
        '
        'BttLentrada
        '
        Me.BttLentrada.BackColor = System.Drawing.SystemColors.Info
        Me.BttLentrada.Location = New System.Drawing.Point(892, 299)
        Me.BttLentrada.Name = "BttLentrada"
        Me.BttLentrada.Size = New System.Drawing.Size(156, 29)
        Me.BttLentrada.TabIndex = 8
        Me.BttLentrada.Text = "Limpiar Entradas"
        Me.BttLentrada.UseVisualStyleBackColor = False
        '
        'BttSalir
        '
        Me.BttSalir.BackColor = System.Drawing.SystemColors.Info
        Me.BttSalir.Location = New System.Drawing.Point(556, 411)
        Me.BttSalir.Name = "BttSalir"
        Me.BttSalir.Size = New System.Drawing.Size(94, 29)
        Me.BttSalir.TabIndex = 9
        Me.BttSalir.Text = "Salir"
        Me.BttSalir.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(879, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ingrese No. etapa"
        '
        'Txtconsulta
        '
        Me.Txtconsulta.Location = New System.Drawing.Point(879, 413)
        Me.Txtconsulta.Name = "Txtconsulta"
        Me.Txtconsulta.Size = New System.Drawing.Size(125, 27)
        Me.Txtconsulta.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1093, 479)
        Me.Controls.Add(Me.Txtconsulta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BttSalir)
        Me.Controls.Add(Me.BttLentrada)
        Me.Controls.Add(Me.BttLvector)
        Me.Controls.Add(Me.BttOrdenar)
        Me.Controls.Add(Me.BttActualizar)
        Me.Controls.Add(Me.BttConsultar)
        Me.Controls.Add(Me.BttMostrar)
        Me.Controls.Add(Me.BttGuardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbxNacionalidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTiempo As TextBox
    Friend WithEvents TxtKm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbxEquipo As ComboBox
    Friend WithEvents TxtEtapa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BttGuardar As Button
    Friend WithEvents BttMostrar As Button
    Friend WithEvents BttConsultar As Button
    Friend WithEvents BttActualizar As Button
    Friend WithEvents BttOrdenar As Button
    Friend WithEvents BttLvector As Button
    Friend WithEvents BttLentrada As Button
    Friend WithEvents BttSalir As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtconsulta As TextBox
End Class
