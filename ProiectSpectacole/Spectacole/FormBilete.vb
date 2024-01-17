Imports System.Data.SqlClient
Public Class FormBilete
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=Spectacole;Integrated Security=True;MultipleActiveResultSets=True")

    'populare grid spectacol
    Private Sub PopulateS()
        Con.Open()
        Dim sql = "select Spectacol.IdSpectacol,DenumireSpectacol,Sala.IdSala,NrContract,NrZone
                                                      from Spectacol
                                                      join Contract
                                                      on Spectacol.IdSpectacol=Contract.IdSpectacol
                                                      join Sala
                                                      on Sala.IdSala=Spectacol.IdSala"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVSB.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub FormBilete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateS()


    End Sub


    'buton cauta spectacol dupa denumire

    Private Sub ButtonCautaSPB_Click(sender As Object, e As EventArgs) Handles ButtonCautaSPB.Click
        TryCast(DGVSB.DataSource, DataTable).DefaultView.RowFilter =
              String.Format("DenumireSpectacol like '%" & TextBoxDenSpectacolCautaB.Text & "%'")
    End Sub


    Dim Key3 = 0
    'arata  in label uri
    Private Sub DGVSB_CellContentClik(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSB.CellContentClick
        Dim row As DataGridViewRow = DGVSB.Rows(e.RowIndex)
        LabelIDSB.Text = row.Cells(0).Value.ToString
        LabelIDSALAB.Text = row.Cells(2).Value.ToString
        LabelNRContrB.Text = row.Cells(3).Value.ToString
        LabelNrZoneB.Text = row.Cells(4).Value.ToString
        If LabelIDSB.Text = "" Then
            Key3 = 0
        Else
            Key3 = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Clear()
        LabelIDSB.Text = ""
        LabelIDSALAB.Text = ""
        LabelNRContrB.Text = ""
        LabelNrZoneB.Text = ""
    End Sub


    'buton reseteaza
    Private Sub ButtonRezeteazaB_Click(sender As Object, e As EventArgs) Handles ButtonRezeteazaB.Click
        Clear()
    End Sub


    'comboBox si buton pt zone
    Private Sub ButtonZona_Click(sender As Object, e As EventArgs) Handles ButtonZona.Click
        If LabelNrZoneB.Text = "" Then
            MsgBox("nu a fost selectat nici un spectacol")
        Else
            Con.Open()
            Dim cmd As New SqlCommand("select NumeZona from AdaosZona where IdAdaosZona<=" & LabelNrZoneB.Text & "", Con)
            Dim ad As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            ad.Fill(table)
            ComboBoxZona.DataSource = table
            ComboBoxZona.DisplayMember = "NumeZona"
            ComboBoxZona.ValueMember = "NumeZona"
            Con.Close()
        End If
    End Sub

    'buton calc cost organizare
    Private Sub ButtonCalcCost_Click(sender As Object, e As EventArgs) Handles ButtonCalcCost.Click

        If LabelNrZoneB.Text = "......." Then
            MsgBox("nu a fost selectat nici un spectacol")

        Else
            Con.Open()
            Dim query As String
            query = "select SUM(CostOrganizare+TarifArtist ) as [Suma] from Contract where NrContract=" & LabelNRContrB.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                LabelCostOrg.Text = dr("Suma")


            End If
            Con.Close()

        End If
    End Sub
    'buton calc pret bilet standard
    Private Sub ButtonCalcPretBiletStandard_Click(sender As Object, e As EventArgs) Handles ButtonCalcPretBiletStandard.Click
        If LabelCostOrg.Text = "......." Then
            MsgBox("nu a fost calculat costul organizare")

        Else
            Con.Open()
            Dim query As String
            query = "select Dimensiune from Sala where IdSala=" & LabelIDSALAB.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                Label2.Text = LabelCostOrg.Text / dr("Dimensiune")


            End If
            Con.Close()

        End If
    End Sub
    'buton calc pret bilet in functie de zona
    Private Sub ButtonCalcBilet_Click(sender As Object, e As EventArgs) Handles ButtonCalcBilet.Click
        If Label2.Text = "......." Then
            MsgBox("nu a fost calculat prețul biletului standard")

        Else

            Con.Open()
            Dim query As String
            query = "select Exponent from AdaosZona where NumeZona='" & ComboBoxZona.SelectedValue & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                LabelPretBilet.Text = Label2.Text * dr("Exponent")


            End If
            Con.Close()

        End If

    End Sub
    'buton actualizeaza nr bilete vandute
    Private Sub ButtonActualizNrBilete_Click(sender As Object, e As EventArgs) Handles ButtonActualizNrBilete.Click
        If LabelIDSB.Text = "" Then
            MsgBox("nu a fost selectat nici un spectacol")
        Else
            Con.Open()
            Dim query As String
            query = "update Spectacol set NrBileteVandute=" & TextBoxNrBilete.Text & " where IdSpectacol=" & LabelIDSB.Text & ""
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query, Con)
            cmd1.ExecuteNonQuery()

            MsgBox("numărul biletelor vândute a fost actualizat")
            Con.Close()
        End If
    End Sub

    'buton arata
    Private Sub ButtonCalcNrBileteVdSICapSala_Click(sender As Object, e As EventArgs) Handles ButtonCalcNrBileteVdSICapSala.Click
        If LabelIDSB.Text = "" Then
            MsgBox("nu a fost selectat nici un spectacol")
        Else



            Con.Open()
            Dim query As String
            query = "select NrBileteVandute,Dimensiune from Spectacol, Sala where IdSpectacol=" & LabelIDSB.Text & " and Spectacol.IdSala=Sala.IdSala"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                LabelNrBileteVd.Text = dr("NrBileteVandute")
                LabelDimensiuneSala.Text = dr("Dimensiune")
            End If
            Con.Close()
        End If

    End Sub
    'buton anuleaza spectacol
    Private Sub ButtonAnuleazaSp_Click(sender As Object, e As EventArgs) Handles ButtonAnuleazaSp.Click
        If LabelIDSB.Text = "" Then
            MsgBox("nu a fost selectat nici un spectacol")
        Else
            Con.Open()
            Dim query As String
            query = "update Spectacol set StatusSpectacol='Anulat' where IdSpectacol=" & LabelIDSB.Text & ""
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query, Con)
            cmd1.ExecuteNonQuery()

            MsgBox("spectacolul a fost anulat")
            Con.Close()
        End If
    End Sub

    Private Sub ButtonPuSCol_Click(sender As Object, e As EventArgs) Handles ButtonPuSCol.Click
        Me.Hide()
        FormColectareDateArtistSiReprezentant.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
End Class