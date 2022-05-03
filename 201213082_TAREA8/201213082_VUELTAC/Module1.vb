Module Module1
    Public index = 0

    Public etapa(12) As Double
    Public equipo(12) As String
    Public recorrido(12) As Double
    Public tiempo(12) As Double
    Public nacionalidad(12) As String
    Public total(12) As Double

    Sub limppiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        index = 0
    End Sub

    Sub limpiar_Entradas()
        Form1.TxtEtapa.Text = 0
        Form1.TxtKm.Text = 0
        Form1.TxtTiempo.Text = 0
        Form1.CbxEquipo.SelectedItem = False
        Form1.CbxNacionalidad.SelectedItem = False

    End Sub

End Module
