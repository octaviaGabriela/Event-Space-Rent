Imports System.Data.SqlClient
Public Class FormColectareDateArtistSiReprezentant
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=Spectacole;Integrated Security=True;MultipleActiveResultSets=True")



    'Buton salveaza date artist
    Private Sub ButtonSalveazaDateArtist_Click(sender As Object, e As EventArgs) Handles ButtonSalveazaDateArtist.Click
        If ComboBoxTipArtist.SelectedIndex = -1 Or TextBoxNumedeScena.Text = "" Then
            MsgBox("un câmp al artistului nu a fost completat")
        Else
            Con.Open()

            Dim cmd As New SqlCommand("select IdArtist from Artist where NumeScena= '" & TextBoxNumedeScena.Text & "' ", Con)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then

                If dr.HasRows Then
                    MsgBox("datele artistului au mai fost salvate, puteți trece la pasul următor")
                End If

            Else

                Dim query As String
                query = "insert into Artist (TipArtist,NumeScena) values ('" & ComboBoxTipArtist.SelectedItem & "','" & TextBoxNumedeScena.Text & "')"
                Dim cmd1 As SqlCommand
                cmd1 = New SqlCommand(query, Con)
                cmd1.ExecuteNonQuery()

                MsgBox("datele artistului au fost salvate")
                Con.Close()
            End If


        End If


    End Sub

    'buton salveaza date pf
    Private Sub ButtonSalveazaDateReprezentant_Click(sender As Object, e As EventArgs) Handles ButtonSalveazaDateReprezentantPF.Click
        If TextBoxAdresaRep.Text = "" Or TextBoxTelRep.Text = "" Or TextBoxNrAutoriz.Text = "" Or TextBoxNumeRep.Text = "" Or TextBoxPrenumeRep.Text = "" Then
            MsgBox("un câmp al reprezentantului de tip PF nu a fost completat")
        Else
            Con.Open()

            Dim cmd As New SqlCommand("select IdReprezentant from Reprezentant where Telefon= '" & TextBoxTelRep.Text & "' ", Con)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then

                If dr.HasRows Then
                    MsgBox("datele acestui reprezentant au mai fost salvate, puteți trece la pasul următor")
                End If

            Else


                Dim query As String
                query = "insert into Reprezentant  values ('" & TextBoxAdresaRep.Text & "','" & TextBoxTelRep.Text & "'," & TextBoxNrAutoriz.Text & ",'" & TextBoxNumeRep.Text & "','" & TextBoxPrenumeRep.Text & "',null,null,null)"
                Dim cmd1 As SqlCommand
                cmd1 = New SqlCommand(query, Con)
                cmd1.ExecuteNonQuery()

                MsgBox("datele reprezentantului de tip PF au fost salvate")
                Con.Close()
            End If
        End If


    End Sub

    'buton salveaza date pj
    Private Sub ButtonSalveazaDateRepPJ_Click(sender As Object, e As EventArgs) Handles ButtonSalveazaDateRepPJ.Click
        If TextBoxAdresaRep.Text = "" Or TextBoxTelRep.Text = "" Or TextBoxCUIRep.Text = "" Or ComboBoxFormaOrganiz.SelectedIndex = -1 Or TextBoxDenumireRep.Text = "" Then
            MsgBox("un câmp al reprezentantului de tip PJ nu a fost completat")
        Else
            Con.Open()

            Dim cmd As New SqlCommand("select IdReprezentant from Reprezentant where Telefon= '" & TextBoxTelRep.Text & "' ", Con)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then

                If dr.HasRows Then
                    MsgBox("datele acestui reprezentant au mai fost salvate, puteți trece la pasul următor")
                End If

            Else


                Dim query As String
                query = "insert into Reprezentant  values ('" & TextBoxAdresaRep.Text & "','" & TextBoxTelRep.Text & "',null,null,null," & TextBoxCUIRep.Text & ",'" & ComboBoxFormaOrganiz.SelectedItem & "','" & TextBoxDenumireRep.Text & "')"
                Dim cmd1 As SqlCommand
                cmd1 = New SqlCommand(query, Con)
                cmd1.ExecuteNonQuery()

                MsgBox("datele reprezentantului de tip PJ au fost salvate")
                Con.Close()
            End If
        End If

    End Sub



    Private Sub ClearR()
        TextBoxAdresaRep.Clear()
        TextBoxTelRep.Clear()
        TextBoxNrAutoriz.Clear()
        TextBoxNumeRep.Clear()
        TextBoxPrenumeRep.Clear()
        TextBoxCUIRep.Clear()
        ComboBoxFormaOrganiz.SelectedIndex = -1
        TextBoxDenumireRep.Clear()
    End Sub

    'buton reseteaza Reprezentant
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearR()
    End Sub




    Private Sub ClearA()
        TextBoxNumedeScena.Clear()
        ComboBoxTipArtist.SelectedIndex = -1
    End Sub


    'buton reseteaza Artist
    Private Sub ButtonResetA_Click(sender As Object, e As EventArgs) Handles ButtonResetA.Click
        ClearA()
    End Sub

    Private Sub ButtonPuSCol_Click(sender As Object, e As EventArgs) Handles ButtonPuSCol.Click
        Me.Hide()
        FormPlanificareSpectacol.Show()

    End Sub

    Private Sub ButtonCCPuS_Click(sender As Object, e As EventArgs) Handles ButtonCCPuS.Click
        Me.Hide()
        FormCreazaContract.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormContract.Show()
    End Sub

    Private Sub ButtonBiletePuS_Click(sender As Object, e As EventArgs) Handles ButtonBiletePuS.Click
        Me.Hide()
        FormBilete.Show()
    End Sub
End Class





