Imports System.Data.SqlClient
Public Class FormCreazaContract
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=Spectacole;Integrated Security=True;MultipleActiveResultSets=True")


    'populare grid artist
    Private Sub PopulateA()
        Con.Open()
        Dim sql = "select* from Artist"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVA.DataSource = ds.Tables(0)
        Con.Close()

    End Sub



    'populare grid reprezentant
    Private Sub PopulateR()
        Con.Open()
        Dim sql = "select* from Reprezentant"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVR.DataSource = ds.Tables(0)
        Con.Close()

    End Sub


    'populare grid spectacol
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
        DGVS.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub FormCreazaContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateA()
        PopulateR()
        PopulateS()

    End Sub

    Dim Key1 = 0
    Dim Key2 = 0
    Dim Key3 = 0

    'arata id artist in label
    Private Sub DGVA_CellContentClik(sender As Object, e As DataGridViewCellEventArgs) Handles DGVA.CellContentClick
        Dim row As DataGridViewRow = DGVA.Rows(e.RowIndex)
        LabelIDArtist.Text = row.Cells(0).Value.ToString
        If LabelIDArtist.Text = "" Then
            Key1 = 0
        Else
            Key1 = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    'arata id reprezentant in label
    Private Sub DGVR_CellContentClik(sender As Object, e As DataGridViewCellEventArgs) Handles DGVR.CellContentClick
        Dim row As DataGridViewRow = DGVR.Rows(e.RowIndex)
        LabelIDRep.Text = row.Cells(0).Value.ToString
        If LabelIDRep.Text = "" Then
            Key2 = 0
        Else
            Key2 = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub


    'arata id spectacol in label
    Private Sub DGVS_CellContentClik(sender As Object, e As DataGridViewCellEventArgs) Handles DGVS.CellContentClick
        Dim row As DataGridViewRow = DGVS.Rows(e.RowIndex)
        LabelIDS.Text = row.Cells(0).Value.ToString
        If LabelIDS.Text = "" Then
            Key3 = 0
        Else
            Key3 = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub


    'buton cauta--- artist
    Private Sub ButtonCautaArtist_Click(sender As Object, e As EventArgs) Handles ButtonCautaArtist.Click
        TryCast(DGVA.DataSource, DataTable).DefaultView.RowFilter =
           String.Format("NumeScena like '%" & TextBoxCautaArtist.Text & "%'")
    End Sub


    'buton cauta--- reprezentant
    Private Sub ButtonCautaRep_Click(sender As Object, e As EventArgs) Handles ButtonCautaRep.Click
        If TextBoxCautaRepDenumirePJ.Text = "" Then
            TryCast(DGVR.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("NumePF like '%" & TextBoxCautaRepNumePF.Text & "%'")
        Else
            TryCast(DGVR.DataSource, DataTable).DefaultView.RowFilter =
               String.Format("DenumirePJ like '%" & TextBoxCautaRepDenumirePJ.Text & "%'")
        End If
    End Sub
    'buton cauta--- spectacol
    Private Sub ButtonCautaS_Click(sender As Object, e As EventArgs) Handles ButtonCautaS.Click
        If TextBoxDenSpectacolCauta.Text = "" Then
            TryCast(DGVS.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("DenumireSala like '%" & TextBoxDenSalaSp.Text & "%'")
        Else
            TryCast(DGVS.DataSource, DataTable).DefaultView.RowFilter =
               String.Format("DenumireSpectacol like '%" & TextBoxDenSpectacolCauta.Text & "%'")
        End If
    End Sub

    Private Sub Clear()
        TextBoxTarifArtistCrC.Clear()
        TextBoxCostOrgnCrC.Clear()
        TextBoxCautaArtist.Clear()
        TextBoxCautaRepDenumirePJ.Clear()
        TextBoxCautaRepNumePF.Clear()
        TextBoxDenSalaSp.Clear()
        TextBoxDenSpectacolCauta.Clear()
        LabelIDArtist.Text = ""
        LabelIDRep.Text = ""
        LabelIDS.Text = ""
    End Sub

    Private Sub ButtonRezeteazaContr_Click(sender As Object, e As EventArgs) Handles ButtonRezeteazaContr.Click
        Clear()
    End Sub


    'buton creaza contract
    Private Sub ButtonCreazaContr_Click(sender As Object, e As EventArgs) Handles ButtonCreazaContr.Click
        If TextBoxTarifArtistCrC.Text = "" Or LabelIDArtist.Text = "" Or LabelIDRep.Text = "" Or LabelIDS.Text = "" Or DateTimePickerDataCrC.Text = "" Then
            MsgBox("câmpurile nu au fost selectate sau completate")
        Else
            Con.Open()
            Dim query As String
            query = "insert into Contract values ('" & DateTimePickerDataCrC.Text & "'," & TextBoxTarifArtistCrC.Text & "," & LabelIDS.Text & "," & LabelIDArtist.Text & ", " & LabelIDRep.Text & "," & TextBoxCostOrgnCrC.Text & ")"
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query, Con)
            cmd1.ExecuteNonQuery()
            Con.Close()

            MsgBox("contractul a fost realizat cu succes")

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormContract.Show()
    End Sub

    Private Sub ButtonBiletePuS_Click(sender As Object, e As EventArgs) Handles ButtonBiletePuS.Click
        Me.Hide()
        FormBilete.Show()
    End Sub
End Class