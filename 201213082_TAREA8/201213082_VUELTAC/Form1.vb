Public Class Form1
    Private Sub BttSalir_Click(sender As Object, e As EventArgs) Handles BttSalir.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            end
        End If
    End Sub

    Private Sub BttActualizar_Click(sender As Object, e As EventArgs) Handles BttActualizar.Click
        etapa(index) = TxtEtapa.Text
        equipo(index) = CbxEquipo.SelectedItem
        recorrido(index) = TxtKm.Text
        tiempo(index) = TxtTiempo.Text
        nacionalidad(index) = CbxNacionalidad.SelectedItem

        If TxtTiempo.Text > 120 Then
            total(index) = tiempo(index) + 30
        End If

        If TxtTiempo.Text > 140 Then
            total(index) = tiempo(index) + 40
        End If

        If TxtTiempo.Text > 160 Then
            total(index) = tiempo(index) + 50
        End If
        If TxtTiempo.Text < 85 And CbxEquipo.SelectedItem = "Movistar" Then
            total(index) = TxtTiempo.Text - 15
        End If
        If TxtTiempo.Text < 85 And CbxEquipo.SelectedItem = "Pro team" Then
            total(index) = TxtTiempo.Text - 10
        End If
    End Sub

    Private Sub BttLvector_Click(sender As Object, e As EventArgs) Handles BttLvector.Click
        limppiar_vectores()
    End Sub

    Private Sub BttLentrada_Click(sender As Object, e As EventArgs) Handles BttLentrada.Click
        limpiar_Entradas()
    End Sub

    Private Sub BttGuardar_Click(sender As Object, e As EventArgs) Handles BttGuardar.Click
        If index < 11 Then
            etapa(index) = TxtEtapa.Text
            equipo(index) = CbxEquipo.SelectedItem
            recorrido(index) = TxtKm.Text
            tiempo(index) = TxtTiempo.Text
            nacionalidad(index) = CbxNacionalidad.SelectedItem

            If TxtTiempo.Text > 120 Then
                total(index) = tiempo(index) + 30
            End If

            If TxtTiempo.Text > 140 Then
                total(index) = tiempo(index) + 40
            End If

            If TxtTiempo.Text > 160 Then
                total(index) = tiempo(index) + 50
            End If
            If TxtTiempo.Text < 85 And CbxEquipo.SelectedItem = "Movistar" Then
                total(index) = TxtTiempo.Text - 15
            End If
            If TxtTiempo.Text < 85 And CbxEquipo.SelectedItem = "Pro team" Then
                total(index) = TxtTiempo.Text - 10
            End If

            DataGridView1.Rows.Add(etapa(index), equipo(index), recorrido(index), tiempo(index), nacionalidad(index), total(index))
                index = 0 + 1
            End If
    End Sub

    Private Sub BttConsultar_Click(sender As Object, e As EventArgs) Handles BttConsultar.Click
        Dim existe As Boolean = False
        index = 0
        While (index <= 2) And Not (existe)
            If (etapa(index) = Val(TxtEtapa.Text)) Then
                existe = True
            Else
                index = index + 1
            End If
        End While
        If (existe) Then
            MsgBox("Registro encontrado exitosamente")
            TxtEtapa.Text = etapa(index)
            TxtKm.Text = recorrido(index)
            TxtTiempo.Text = tiempo(index)
            CbxEquipo.SelectedItem = equipo(index)
            CbxNacionalidad.SelectedItem = nacionalidad(index)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(etapa(index), equipo(index), recorrido(index), tiempo(index), nacionalidad(index), total(index))
        Else
            MsgBox("Número de etapa no encontado")
            Txtconsulta.Focus()
        End If
    End Sub

    Private Sub BttMostrar_Click(sender As Object, e As EventArgs) Handles BttMostrar.Click

        DataGridView1.Rows.Add(etapa(index), equipo(index), recorrido(index), tiempo(index), nacionalidad(index), total(index))
        index = 0 + 1

    End Sub
End Class
