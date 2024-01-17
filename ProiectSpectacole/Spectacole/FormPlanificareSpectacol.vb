Imports System.Data.SqlClient
Public Class FormPlanificareSpectacol
    Dim Con As New SqlConnection("Data Source=DESKTOP-A4RFJNL\SQLSERVEROCT;Initial Catalog=Spectacole;Integrated Security=True;MultipleActiveResultSets=True")

    'populare grid
    Private Sub Populate()
        Con.Open()
        Dim sql = "select DataSpectacol,DenumireSpectacol,DenumireSala,OraInceputSpectacol,OraSfarsitSpectacol,StatusSpectacol from Spectacol,Sala
                    where Sala.IdSala=Spectacol.IdSala"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridViewPL.DataSource = ds.Tables(0)
        Con.Close()
        Clear()

    End Sub



    Private Sub FormPlanificareSpectacol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        FillSala()
    End Sub


    'criterii de cautare pt buton cauta
    Private Sub ButtonCautaPL_Click(sender As Object, e As EventArgs) Handles ButtonCautaPL.Click
        If TextBoxStatusSpectacolCautaPL.Text = "" Then
            TryCast(DataGridViewPL.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("DenumireSala like '%" & TextBoxDEnCautaPS.Text & "%'")
        Else
            TryCast(DataGridViewPL.DataSource, DataTable).DefaultView.RowFilter =
            String.Format("StatusSpectacol like '%" & TextBoxStatusSpectacolCautaPL.Text & "%'")
        End If
    End Sub


    Private Sub Clear()
        TextBoxDenPS.Clear()
        TextBoxOraIPL.Clear()
        TextBoxOraSPL.Clear()
        LabelMinute.Text = ""
        TextBoxDEnCautaPS.Clear()
        TextBoxStatusSpectacolCautaPL.Clear()
        ComboBoxSala.SelectedIndex = -1
        LabelDurataspectacolMinute.Text = ""

    End Sub
    'buton reseteaza
    Private Sub ButtonRezeteazaPL_Click(sender As Object, e As EventArgs) Handles ButtonRezeteazaPL.Click
        Clear()
    End Sub



    'buton planifica spectacol
    Private Sub buttonplanificaspectacol_click(sender As Object, e As EventArgs) Handles ButtonPlanificaSpectacol.Click
        If TextBoxDenPS.Text = "" Or TextBoxOraIPL.Text = "" Or TextBoxOraSPL.Text = "" Or ComboBoxSala.SelectedIndex = -1 Or DateTimePickerDataSpectacolPL.CustomFormat = "" Then
            MsgBox("unul dintre câmpurile pentu planificarea unui spectacol nu a fost completat")
        Else
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            'verificare suprapunere spectacol
            Dim cmd As New SqlCommand("select IdSpectacol from Spectacol where DataSpectacol= '" & DateTimePickerDataSpectacolPL.Text & "'  
                                                                               and IdSala=" & ComboBoxSala.SelectedValue & "
                                                                              and(( '" & TextBoxOraIPL.Text & "'< OraInceputSpectacol and OraInceputSpectacol<'" & TextBoxOraSPL.Text & "' )
                                                                               or( '" & TextBoxOraIPL.Text & "'< OraSfarsitSpectacol and OraSfarsitSpectacol <'" & TextBoxOraSPL.Text & "' )
                                                                               or( '" & TextBoxOraIPL.Text & "'> OraInceputSpectacol and '" & TextBoxOraSPL.Text & "'< OraSfarsitSpectacol )
                                                                               or ('" & TextBoxOraIPL.Text & "'= OraInceputSpectacol and '" & TextBoxOraSPL.Text & "'= OraSfarsitSpectacol))", Con)

            Dim dr As SqlDataReader
            dr = cmd.executereader
            if dr.read then

                if dr.hasrows then
                    msgbox("suprapunere spectacole, găsiți altă variantă pentru planificarea spectacolului")
                end if

            else


                Dim query As String
            query = "insert into Spectacol values ('" & TextBoxDenPS.Text & "','" & DateTimePickerDataSpectacolPL.Text & "','" & TextBoxOraIPL.Text & "','" & TextBoxOraSPL.Text & "','Confirmat'," & ComboBoxSala.SelectedValue & ")"
            Dim cmd1 As SqlCommand
                cmd1 = New SqlCommand(query, Con)
                cmd1.ExecuteNonQuery()

            MsgBox("spectacolul a fost planificat")
            Con.Close()
            End If
        End If
    End Sub

    Private Sub ButtonCalcDurata_Click(sender As Object, e As EventArgs) Handles ButtonCalcDurata.Click
        Dim oraI As DateTime
        Dim oraS As DateTime
        Dim SoraI As String = Trim(TextBoxOraIPL.Text)
        Dim SoraS As String = Trim(TextBoxOraSPL.Text)
        If DateTime.TryParse(SoraI, oraI) AndAlso DateTime.TryParse(SoraS, oraS) Then
            Dim TS As TimeSpan = oraS - oraI
            Dim ora As Integer = TS.Hours
            Dim min As Integer = TS.Minutes
            Dim sec As Integer = TS.Seconds
            Dim diferenta As String = ((ora.ToString("00") & ":") + (min.ToString("00") & ":") + (sec.ToString("00")))



            LabelMinute.Text = diferenta
        End If

        Dim TS1 As TimeSpan
        If TimeSpan.TryParse(LabelMinute.Text, TS1) Then
            LabelDurataspectacolMinute.Text = TS1.TotalMinutes

        End If
    End Sub
    'combobox sala
    Private Sub FillSala()
        Con.Open()
        Dim cmd As New SqlCommand("select IdSala from Sala", Con)
        Dim ad As New SqlDataAdapter(cmd)
        Dim tbl1 As New DataTable()
        ad.Fill(tbl1)
        ComboBoxSala.DataSource = tbl1
        ComboBoxSala.DisplayMember = "IdSala"
        ComboBoxSala.ValueMember = "IdSala"
        Con.Close()
    End Sub

    Private Sub ButtonPuSCol_Click(sender As Object, e As EventArgs) Handles ButtonPuSCol.Click
        Me.Hide()
        FormColectareDateArtistSiReprezentant.Show()

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