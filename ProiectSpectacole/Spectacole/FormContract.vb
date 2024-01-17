
Imports System.Data.SqlClient
Public Class FormContract
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=Spectacole;Integrated Security=True;MultipleActiveResultSets=True")


    Private Sub PopulateS()
        Con.Open()
        Dim sql = "select IdSpectacol,DataSpectacol,DenumireSpectacol,DenumireSala,OraInceputSpectacol,OraSfarsitSpectacol,StatusSpectacol from Spectacol,Sala
                    where Sala.IdSala=Spectacol.IdSala"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVSVC.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Dim Key3 = 0
    'arata id spectacol in label
    Private Sub DGVSVC_CellContentClik(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSVC.CellContentClick
        Dim row As DataGridViewRow = DGVSVC.Rows(e.RowIndex)
        LabelIDSVC.Text = row.Cells(0).Value.ToString
        If LabelIDSVC.Text = "" Then
            Key3 = 0
        Else
            Key3 = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub


    Private Sub FormContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateS()
    End Sub

    Private Sub ButtonCautaSVC_Click(sender As Object, e As EventArgs) Handles ButtonCautaSVC.Click
        If TextBoxDenSpectacolCautaVC.Text = "" Then
            TryCast(DGVSVC.DataSource, DataTable).DefaultView.RowFilter =
    String.Format("StatusSpectacol like '%" & TextBoxStatusSPVC.Text & "%'")
        Else
            TryCast(DGVSVC.DataSource, DataTable).DefaultView.RowFilter =
               String.Format("DenumireSpectacol like '%" & TextBoxDenSpectacolCautaVC.Text & "%'")
        End If
    End Sub
    'buton arata contract
    Private Sub ButtonArataContract_Click(sender As Object, e As EventArgs) Handles ButtonArataContract.Click
        If LabelIDSVC.Text = "" Then
            MsgBox("unul dintre câmpurile pentu planificarea unui spectacol nu a fost completat")
        Else
            Con.Open()
            Dim query As String
            query = "Select* from Spectacol,Contract,Reprezentant,Artist where Spectacol.IdSpectacol=" & LabelIDSVC.Text & " 
                                                           and Spectacol.IdSpectacol=Contract.IdSpectacol
                                                           and Artist.IdArtist=Contract.IdArtist 
                                                           and Reprezentant.IdReprezentant=Contract.IdReprezentant"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                LabelDenSpect.Text = dr("DenumireSpectacol")
                LabelNrContr.Text = dr("NrContract")
                LabelDataContr.Text = dr("DataContract")
                LabelTarifArt.Text = dr("TarifArtist")
                LabelAdrRep.Text = dr("Adresa")
                LabelTelRep.Text = dr("Telefon")

                LabelNrAutorizRep.Text = dr("NrAutorizatiePF").ToString
                LabelNumeRep.Text = dr("NumePF").ToString
                LabelPrenumeRep.Text = dr("PrenumePF").ToString

                LabelCUIRep.Text = dr("CUIPJ").ToString
                FormaOrgRep.Text = dr("FormaOrganizationalaPJ").ToString
                LabelDenRep.Text = dr("DenumirePJ").ToString

                LabelTipArt.Text = dr("TipArtist")
                LabelNumeScenaArt.Text = dr("NumeScena")

            End If





            Con.Close()

        End If


    End Sub
    Private Sub Clear()
        LabelIDSVC.Text = ""
        LabelDenSpect.Text = "....."
        LabelNrContr.Text = "....."
        LabelDataContr.Text = "....."
        LabelTarifArt.Text = "....."
        LabelAdrRep.Text = "....."
        LabelTelRep.Text = "....."
        LabelNrAutorizRep.Text = "....."
        LabelNumeRep.Text = "....."
        LabelPrenumeRep.Text = "....."
        LabelCUIRep.Text = "....."
        FormaOrgRep.Text = "....."
        LabelDenRep.Text = "....."
        LabelTipArt.Text = "....."
        LabelNumeScenaArt.Text = "....."
    End Sub

    Private Sub ButtonRezeteazaVC_Click(sender As Object, e As EventArgs) Handles ButtonRezeteazaVC.Click
        Clear()
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

    Private Sub ButtonBiletePuS_Click(sender As Object, e As EventArgs) Handles ButtonBiletePuS.Click
        Me.Hide()
        FormBilete.Show()
    End Sub
End Class