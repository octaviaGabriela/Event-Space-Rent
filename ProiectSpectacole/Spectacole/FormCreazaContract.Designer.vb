<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreazaContract
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerDataCrC = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCostOrgnCrC = New System.Windows.Forms.TextBox()
        Me.TextBoxTarifArtistCrC = New System.Windows.Forms.TextBox()
        Me.DGVA = New System.Windows.Forms.DataGridView()
        Me.DGVR = New System.Windows.Forms.DataGridView()
        Me.DGVS = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxCautaArtist = New System.Windows.Forms.TextBox()
        Me.LabelIDArtist = New System.Windows.Forms.Label()
        Me.ButtonCautaArtist = New System.Windows.Forms.Button()
        Me.TextBoxCautaRepNumePF = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxCautaRepDenumirePJ = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonCautaRep = New System.Windows.Forms.Button()
        Me.LabelIDRep = New System.Windows.Forms.Label()
        Me.TextBoxDenSpectacolCauta = New System.Windows.Forms.TextBox()
        Me.TextBoxDenSalaSp = New System.Windows.Forms.TextBox()
        Me.ButtonCautaS = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabelIDS = New System.Windows.Forms.Label()
        Me.ButtonCreazaContr = New System.Windows.Forms.Button()
        Me.ButtonRezeteazaContr = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonBiletePuS = New System.Windows.Forms.Button()
        Me.ButtonPuSCol = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ButtonBiletePuS)
        Me.Panel1.Controls.Add(Me.ButtonPuSCol)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 764)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Crează contract"
        '
        'DateTimePickerDataCrC
        '
        Me.DateTimePickerDataCrC.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerDataCrC.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDataCrC.Location = New System.Drawing.Point(295, 66)
        Me.DateTimePickerDataCrC.Name = "DateTimePickerDataCrC"
        Me.DateTimePickerDataCrC.Size = New System.Drawing.Size(77, 20)
        Me.DateTimePickerDataCrC.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Dată contract"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Cost organizare"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Tarif artist"
        '
        'TextBoxCostOrgnCrC
        '
        Me.TextBoxCostOrgnCrC.Location = New System.Drawing.Point(295, 124)
        Me.TextBoxCostOrgnCrC.Name = "TextBoxCostOrgnCrC"
        Me.TextBoxCostOrgnCrC.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCostOrgnCrC.TabIndex = 28
        '
        'TextBoxTarifArtistCrC
        '
        Me.TextBoxTarifArtistCrC.Location = New System.Drawing.Point(295, 97)
        Me.TextBoxTarifArtistCrC.Name = "TextBoxTarifArtistCrC"
        Me.TextBoxTarifArtistCrC.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTarifArtistCrC.TabIndex = 29
        '
        'DGVA
        '
        Me.DGVA.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVA.Location = New System.Drawing.Point(174, 225)
        Me.DGVA.Name = "DGVA"
        Me.DGVA.Size = New System.Drawing.Size(379, 81)
        Me.DGVA.TabIndex = 32
        '
        'DGVR
        '
        Me.DGVR.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVR.Location = New System.Drawing.Point(174, 391)
        Me.DGVR.Name = "DGVR"
        Me.DGVR.Size = New System.Drawing.Size(625, 86)
        Me.DGVR.TabIndex = 34
        '
        'DGVS
        '
        Me.DGVS.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVS.Location = New System.Drawing.Point(174, 579)
        Me.DGVS.Name = "DGVS"
        Me.DGVS.Size = New System.Drawing.Size(625, 112)
        Me.DGVS.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(170, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Alege artist"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Alege reprezentant"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(173, 512)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Alege spectacol"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(171, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Caută artist după nume de scenă"
        '
        'TextBoxCautaArtist
        '
        Me.TextBoxCautaArtist.Location = New System.Drawing.Point(372, 199)
        Me.TextBoxCautaArtist.Name = "TextBoxCautaArtist"
        Me.TextBoxCautaArtist.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCautaArtist.TabIndex = 41
        '
        'LabelIDArtist
        '
        Me.LabelIDArtist.AutoSize = True
        Me.LabelIDArtist.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelIDArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelIDArtist.Location = New System.Drawing.Point(569, 256)
        Me.LabelIDArtist.Name = "LabelIDArtist"
        Me.LabelIDArtist.Size = New System.Drawing.Size(166, 16)
        Me.LabelIDArtist.TabIndex = 43
        Me.LabelIDArtist.Text = "Număr de identificare artist"
        '
        'ButtonCautaArtist
        '
        Me.ButtonCautaArtist.Location = New System.Drawing.Point(487, 197)
        Me.ButtonCautaArtist.Name = "ButtonCautaArtist"
        Me.ButtonCautaArtist.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCautaArtist.TabIndex = 44
        Me.ButtonCautaArtist.Text = "Caută"
        Me.ButtonCautaArtist.UseVisualStyleBackColor = True
        '
        'TextBoxCautaRepNumePF
        '
        Me.TextBoxCautaRepNumePF.Location = New System.Drawing.Point(404, 365)
        Me.TextBoxCautaRepNumePF.Name = "TextBoxCautaRepNumePF"
        Me.TextBoxCautaRepNumePF.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCautaRepNumePF.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(205, 365)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 16)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Caută reprezentant după nume "
        '
        'TextBoxCautaRepDenumirePJ
        '
        Me.TextBoxCautaRepDenumirePJ.Location = New System.Drawing.Point(778, 365)
        Me.TextBoxCautaRepDenumirePJ.Name = "TextBoxCautaRepDenumirePJ"
        Me.TextBoxCautaRepDenumirePJ.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCautaRepDenumirePJ.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(559, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(213, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Caută reprezentant după denumire"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.LightGray
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(174, 366)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 16)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "PF"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.LightGray
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(529, 366)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "PJ"
        '
        'ButtonCautaRep
        '
        Me.ButtonCautaRep.Location = New System.Drawing.Point(908, 362)
        Me.ButtonCautaRep.Name = "ButtonCautaRep"
        Me.ButtonCautaRep.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCautaRep.TabIndex = 51
        Me.ButtonCautaRep.Text = "Caută"
        Me.ButtonCautaRep.UseVisualStyleBackColor = True
        '
        'LabelIDRep
        '
        Me.LabelIDRep.AutoSize = True
        Me.LabelIDRep.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelIDRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelIDRep.Location = New System.Drawing.Point(817, 428)
        Me.LabelIDRep.Name = "LabelIDRep"
        Me.LabelIDRep.Size = New System.Drawing.Size(212, 16)
        Me.LabelIDRep.TabIndex = 52
        Me.LabelIDRep.Text = "Număr de identificare reprezentant"
        '
        'TextBoxDenSpectacolCauta
        '
        Me.TextBoxDenSpectacolCauta.Location = New System.Drawing.Point(568, 550)
        Me.TextBoxDenSpectacolCauta.Name = "TextBoxDenSpectacolCauta"
        Me.TextBoxDenSpectacolCauta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDenSpectacolCauta.TabIndex = 59
        '
        'TextBoxDenSalaSp
        '
        Me.TextBoxDenSalaSp.Location = New System.Drawing.Point(276, 550)
        Me.TextBoxDenSalaSp.Name = "TextBoxDenSalaSp"
        Me.TextBoxDenSalaSp.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxDenSalaSp.TabIndex = 57
        '
        'ButtonCautaS
        '
        Me.ButtonCautaS.Location = New System.Drawing.Point(724, 547)
        Me.ButtonCautaS.Name = "ButtonCautaS"
        Me.ButtonCautaS.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCautaS.TabIndex = 56
        Me.ButtonCautaS.Text = "Caută"
        Me.ButtonCautaS.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(430, 550)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 16)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Denumire spectacol"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.Location = New System.Drawing.Point(175, 550)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 16)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Număr sala"
        '
        'LabelIDS
        '
        Me.LabelIDS.AutoSize = True
        Me.LabelIDS.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelIDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelIDS.Location = New System.Drawing.Point(817, 624)
        Me.LabelIDS.Name = "LabelIDS"
        Me.LabelIDS.Size = New System.Drawing.Size(197, 16)
        Me.LabelIDS.TabIndex = 60
        Me.LabelIDS.Text = "Număr de identificare spectacol"
        '
        'ButtonCreazaContr
        '
        Me.ButtonCreazaContr.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonCreazaContr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonCreazaContr.Location = New System.Drawing.Point(416, 718)
        Me.ButtonCreazaContr.Name = "ButtonCreazaContr"
        Me.ButtonCreazaContr.Size = New System.Drawing.Size(163, 23)
        Me.ButtonCreazaContr.TabIndex = 62
        Me.ButtonCreazaContr.Text = "Crează contract"
        Me.ButtonCreazaContr.UseVisualStyleBackColor = False
        '
        'ButtonRezeteazaContr
        '
        Me.ButtonRezeteazaContr.Location = New System.Drawing.Point(714, 718)
        Me.ButtonRezeteazaContr.Name = "ButtonRezeteazaContr"
        Me.ButtonRezeteazaContr.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRezeteazaContr.TabIndex = 61
        Me.ButtonRezeteazaContr.Text = "Resetează"
        Me.ButtonRezeteazaContr.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(20, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 37)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Vizualizare " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " contracte"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ButtonBiletePuS
        '
        Me.ButtonBiletePuS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonBiletePuS.Location = New System.Drawing.Point(34, 319)
        Me.ButtonBiletePuS.Name = "ButtonBiletePuS"
        Me.ButtonBiletePuS.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBiletePuS.TabIndex = 7
        Me.ButtonBiletePuS.Text = "Bilete"
        Me.ButtonBiletePuS.UseVisualStyleBackColor = False
        '
        'ButtonPuSCol
        '
        Me.ButtonPuSCol.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonPuSCol.Location = New System.Drawing.Point(11, 105)
        Me.ButtonPuSCol.Name = "ButtonPuSCol"
        Me.ButtonPuSCol.Size = New System.Drawing.Size(122, 38)
        Me.ButtonPuSCol.TabIndex = 6
        Me.ButtonPuSCol.Text = "Colectare date " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "artist și reprezentant"
        Me.ButtonPuSCol.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(11, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Planifică un spectacol"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormCreazaContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 766)
        Me.Controls.Add(Me.ButtonCreazaContr)
        Me.Controls.Add(Me.ButtonRezeteazaContr)
        Me.Controls.Add(Me.LabelIDS)
        Me.Controls.Add(Me.TextBoxDenSpectacolCauta)
        Me.Controls.Add(Me.TextBoxDenSalaSp)
        Me.Controls.Add(Me.ButtonCautaS)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LabelIDRep)
        Me.Controls.Add(Me.ButtonCautaRep)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBoxCautaRepDenumirePJ)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBoxCautaRepNumePF)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonCautaArtist)
        Me.Controls.Add(Me.LabelIDArtist)
        Me.Controls.Add(Me.TextBoxCautaArtist)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGVS)
        Me.Controls.Add(Me.DGVR)
        Me.Controls.Add(Me.DGVA)
        Me.Controls.Add(Me.TextBoxTarifArtistCrC)
        Me.Controls.Add(Me.TextBoxCostOrgnCrC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerDataCrC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCreazaContract"
        Me.Text = "FormContract"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerDataCrC As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCostOrgnCrC As TextBox
    Friend WithEvents TextBoxTarifArtistCrC As TextBox
    Friend WithEvents DGVA As DataGridView
    Friend WithEvents DGVR As DataGridView
    Friend WithEvents DGVS As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxCautaArtist As TextBox
    Friend WithEvents LabelIDArtist As Label
    Friend WithEvents ButtonCautaArtist As Button
    Friend WithEvents TextBoxCautaRepNumePF As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxCautaRepDenumirePJ As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ButtonCautaRep As Button
    Friend WithEvents LabelIDRep As Label
    Friend WithEvents TextBoxDenSpectacolCauta As TextBox
    Friend WithEvents TextBoxDenSalaSp As TextBox
    Friend WithEvents ButtonCautaS As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LabelIDS As Label
    Friend WithEvents ButtonCreazaContr As Button
    Friend WithEvents ButtonRezeteazaContr As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonBiletePuS As Button
    Friend WithEvents ButtonPuSCol As Button
    Friend WithEvents Button1 As Button
End Class
