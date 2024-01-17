<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBilete
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
        Me.ButtonRezeteazaB = New System.Windows.Forms.Button()
        Me.LabelIDSB = New System.Windows.Forms.Label()
        Me.TextBoxDenSpectacolCautaB = New System.Windows.Forms.TextBox()
        Me.ButtonCautaSPB = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVSB = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelIDSALAB = New System.Windows.Forms.Label()
        Me.LabelNRContrB = New System.Windows.Forms.Label()
        Me.LabelNrZoneB = New System.Windows.Forms.Label()
        Me.ComboBoxZona = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelCostOrg = New System.Windows.Forms.Label()
        Me.LabelPretBilet = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonCalcCost = New System.Windows.Forms.Button()
        Me.ButtonCalcBilet = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxNrBilete = New System.Windows.Forms.TextBox()
        Me.ButtonActualizNrBilete = New System.Windows.Forms.Button()
        Me.ButtonAnuleazaSp = New System.Windows.Forms.Button()
        Me.ButtonCalcNrBileteVdSICapSala = New System.Windows.Forms.Button()
        Me.LabelDimensiuneSala = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelNrBileteVd = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ButtonZona = New System.Windows.Forms.Button()
        Me.ButtonCalcPretBiletStandard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonCCPuS = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonPuSCol = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVSB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ButtonCCPuS)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ButtonPuSCol)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 623)
        Me.Panel1.TabIndex = 2
        '
        'ButtonRezeteazaB
        '
        Me.ButtonRezeteazaB.Location = New System.Drawing.Point(821, 176)
        Me.ButtonRezeteazaB.Name = "ButtonRezeteazaB"
        Me.ButtonRezeteazaB.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRezeteazaB.TabIndex = 81
        Me.ButtonRezeteazaB.Text = "Resetează"
        Me.ButtonRezeteazaB.UseVisualStyleBackColor = True
        '
        'LabelIDSB
        '
        Me.LabelIDSB.AutoSize = True
        Me.LabelIDSB.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelIDSB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelIDSB.Location = New System.Drawing.Point(561, 130)
        Me.LabelIDSB.Name = "LabelIDSB"
        Me.LabelIDSB.Size = New System.Drawing.Size(197, 16)
        Me.LabelIDSB.TabIndex = 80
        Me.LabelIDSB.Text = "Număr de identificare spectacol"
        '
        'TextBoxDenSpectacolCautaB
        '
        Me.TextBoxDenSpectacolCautaB.Location = New System.Drawing.Point(292, 103)
        Me.TextBoxDenSpectacolCautaB.Name = "TextBoxDenSpectacolCautaB"
        Me.TextBoxDenSpectacolCautaB.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDenSpectacolCautaB.TabIndex = 79
        '
        'ButtonCautaSPB
        '
        Me.ButtonCautaSPB.Location = New System.Drawing.Point(431, 101)
        Me.ButtonCautaSPB.Name = "ButtonCautaSPB"
        Me.ButtonCautaSPB.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCautaSPB.TabIndex = 77
        Me.ButtonCautaSPB.Text = "Caută"
        Me.ButtonCautaSPB.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(158, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 16)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "Denumire spectacol"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(156, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Alege spectacol"
        '
        'DGVSB
        '
        Me.DGVSB.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVSB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSB.Location = New System.Drawing.Point(157, 130)
        Me.DGVSB.Name = "DGVSB"
        Me.DGVSB.Size = New System.Drawing.Size(361, 112)
        Me.DGVSB.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Bilete"
        '
        'LabelIDSALAB
        '
        Me.LabelIDSALAB.AutoSize = True
        Me.LabelIDSALAB.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelIDSALAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelIDSALAB.Location = New System.Drawing.Point(561, 163)
        Me.LabelIDSALAB.Name = "LabelIDSALAB"
        Me.LabelIDSALAB.Size = New System.Drawing.Size(164, 16)
        Me.LabelIDSALAB.TabIndex = 84
        Me.LabelIDSALAB.Text = "Număr de identificare sala"
        '
        'LabelNRContrB
        '
        Me.LabelNRContrB.AutoSize = True
        Me.LabelNRContrB.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelNRContrB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelNRContrB.Location = New System.Drawing.Point(561, 198)
        Me.LabelNRContrB.Name = "LabelNRContrB"
        Me.LabelNRContrB.Size = New System.Drawing.Size(185, 16)
        Me.LabelNRContrB.TabIndex = 85
        Me.LabelNRContrB.Text = "Număr de identificare contract"
        '
        'LabelNrZoneB
        '
        Me.LabelNrZoneB.AutoSize = True
        Me.LabelNrZoneB.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelNrZoneB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelNrZoneB.Location = New System.Drawing.Point(561, 226)
        Me.LabelNrZoneB.Name = "LabelNrZoneB"
        Me.LabelNrZoneB.Size = New System.Drawing.Size(99, 16)
        Me.LabelNrZoneB.TabIndex = 86
        Me.LabelNrZoneB.Text = "Număr de zone"
        '
        'ComboBoxZona
        '
        Me.ComboBoxZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxZona.FormattingEnabled = True
        Me.ComboBoxZona.Location = New System.Drawing.Point(267, 369)
        Me.ComboBoxZona.Name = "ComboBoxZona"
        Me.ComboBoxZona.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxZona.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Preț bilet"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(399, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 16)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Cost organizare"
        '
        'LabelCostOrg
        '
        Me.LabelCostOrg.AutoSize = True
        Me.LabelCostOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelCostOrg.Location = New System.Drawing.Point(507, 318)
        Me.LabelCostOrg.Name = "LabelCostOrg"
        Me.LabelCostOrg.Size = New System.Drawing.Size(29, 16)
        Me.LabelCostOrg.TabIndex = 91
        Me.LabelCostOrg.Text = "......."
        '
        'LabelPretBilet
        '
        Me.LabelPretBilet.AutoSize = True
        Me.LabelPretBilet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelPretBilet.Location = New System.Drawing.Point(570, 372)
        Me.LabelPretBilet.Name = "LabelPretBilet"
        Me.LabelPretBilet.Size = New System.Drawing.Size(29, 16)
        Me.LabelPretBilet.TabIndex = 93
        Me.LabelPretBilet.Text = "......."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(399, 372)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 16)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Preț bilet în funcție de zonă"
        '
        'ButtonCalcCost
        '
        Me.ButtonCalcCost.Location = New System.Drawing.Point(612, 310)
        Me.ButtonCalcCost.Name = "ButtonCalcCost"
        Me.ButtonCalcCost.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcCost.TabIndex = 94
        Me.ButtonCalcCost.Text = "Calculează"
        Me.ButtonCalcCost.UseVisualStyleBackColor = True
        '
        'ButtonCalcBilet
        '
        Me.ButtonCalcBilet.Location = New System.Drawing.Point(612, 369)
        Me.ButtonCalcBilet.Name = "ButtonCalcBilet"
        Me.ButtonCalcBilet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcBilet.TabIndex = 95
        Me.ButtonCalcBilet.Text = "Calculează"
        Me.ButtonCalcBilet.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.LightGray
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(157, 425)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Număr de bilete vândute"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(158, 466)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(213, 16)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Număr actualizat de bilete vândute"
        '
        'TextBoxNrBilete
        '
        Me.TextBoxNrBilete.Location = New System.Drawing.Point(377, 462)
        Me.TextBoxNrBilete.Name = "TextBoxNrBilete"
        Me.TextBoxNrBilete.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNrBilete.TabIndex = 98
        '
        'ButtonActualizNrBilete
        '
        Me.ButtonActualizNrBilete.BackColor = System.Drawing.Color.NavajoWhite
        Me.ButtonActualizNrBilete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonActualizNrBilete.Location = New System.Drawing.Point(515, 460)
        Me.ButtonActualizNrBilete.Name = "ButtonActualizNrBilete"
        Me.ButtonActualizNrBilete.Size = New System.Drawing.Size(231, 23)
        Me.ButtonActualizNrBilete.TabIndex = 99
        Me.ButtonActualizNrBilete.Text = "Actualizează număr de bilete vândute"
        Me.ButtonActualizNrBilete.UseVisualStyleBackColor = False
        '
        'ButtonAnuleazaSp
        '
        Me.ButtonAnuleazaSp.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonAnuleazaSp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonAnuleazaSp.Location = New System.Drawing.Point(515, 536)
        Me.ButtonAnuleazaSp.Name = "ButtonAnuleazaSp"
        Me.ButtonAnuleazaSp.Size = New System.Drawing.Size(171, 23)
        Me.ButtonAnuleazaSp.TabIndex = 105
        Me.ButtonAnuleazaSp.Text = "Anulează spectacol"
        Me.ButtonAnuleazaSp.UseVisualStyleBackColor = False
        '
        'ButtonCalcNrBileteVdSICapSala
        '
        Me.ButtonCalcNrBileteVdSICapSala.Location = New System.Drawing.Point(402, 536)
        Me.ButtonCalcNrBileteVdSICapSala.Name = "ButtonCalcNrBileteVdSICapSala"
        Me.ButtonCalcNrBileteVdSICapSala.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcNrBileteVdSICapSala.TabIndex = 104
        Me.ButtonCalcNrBileteVdSICapSala.Text = "Arată"
        Me.ButtonCalcNrBileteVdSICapSala.UseVisualStyleBackColor = True
        '
        'LabelDimensiuneSala
        '
        Me.LabelDimensiuneSala.AutoSize = True
        Me.LabelDimensiuneSala.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelDimensiuneSala.Location = New System.Drawing.Point(325, 543)
        Me.LabelDimensiuneSala.Name = "LabelDimensiuneSala"
        Me.LabelDimensiuneSala.Size = New System.Drawing.Size(29, 16)
        Me.LabelDimensiuneSala.TabIndex = 103
        Me.LabelDimensiuneSala.Text = "......."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.Location = New System.Drawing.Point(165, 543)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 16)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Capacitate sală"
        '
        'LabelNrBileteVd
        '
        Me.LabelNrBileteVd.AutoSize = True
        Me.LabelNrBileteVd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelNrBileteVd.Location = New System.Drawing.Point(325, 519)
        Me.LabelNrBileteVd.Name = "LabelNrBileteVd"
        Me.LabelNrBileteVd.Size = New System.Drawing.Size(29, 16)
        Me.LabelNrBileteVd.TabIndex = 101
        Me.LabelNrBileteVd.Text = "......."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.Location = New System.Drawing.Point(165, 519)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 16)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "Număr de bilete vândute"
        '
        'ButtonZona
        '
        Me.ButtonZona.Location = New System.Drawing.Point(164, 369)
        Me.ButtonZona.Name = "ButtonZona"
        Me.ButtonZona.Size = New System.Drawing.Size(75, 23)
        Me.ButtonZona.TabIndex = 106
        Me.ButtonZona.Text = "Arată zone"
        Me.ButtonZona.UseVisualStyleBackColor = True
        '
        'ButtonCalcPretBiletStandard
        '
        Me.ButtonCalcPretBiletStandard.Location = New System.Drawing.Point(612, 339)
        Me.ButtonCalcPretBiletStandard.Name = "ButtonCalcPretBiletStandard"
        Me.ButtonCalcPretBiletStandard.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcPretBiletStandard.TabIndex = 109
        Me.ButtonCalcPretBiletStandard.Text = "Calculează"
        Me.ButtonCalcPretBiletStandard.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(521, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "......."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Preț bilet standard"
        '
        'ButtonCCPuS
        '
        Me.ButtonCCPuS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonCCPuS.Location = New System.Drawing.Point(13, 245)
        Me.ButtonCCPuS.Name = "ButtonCCPuS"
        Me.ButtonCCPuS.Size = New System.Drawing.Size(122, 23)
        Me.ButtonCCPuS.TabIndex = 19
        Me.ButtonCCPuS.Text = "Creare contract"
        Me.ButtonCCPuS.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(13, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Planifică un spectacol"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonPuSCol
        '
        Me.ButtonPuSCol.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonPuSCol.Location = New System.Drawing.Point(13, 102)
        Me.ButtonPuSCol.Name = "ButtonPuSCol"
        Me.ButtonPuSCol.Size = New System.Drawing.Size(122, 38)
        Me.ButtonPuSCol.TabIndex = 16
        Me.ButtonPuSCol.Text = "Colectare date " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "artist și reprezentant"
        Me.ButtonPuSCol.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(13, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 37)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Vizualizare " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " contracte"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormBilete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(946, 622)
        Me.Controls.Add(Me.ButtonCalcPretBiletStandard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonZona)
        Me.Controls.Add(Me.ButtonAnuleazaSp)
        Me.Controls.Add(Me.ButtonCalcNrBileteVdSICapSala)
        Me.Controls.Add(Me.LabelDimensiuneSala)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LabelNrBileteVd)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ButtonActualizNrBilete)
        Me.Controls.Add(Me.TextBoxNrBilete)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ButtonCalcBilet)
        Me.Controls.Add(Me.ButtonCalcCost)
        Me.Controls.Add(Me.LabelPretBilet)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabelCostOrg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxZona)
        Me.Controls.Add(Me.LabelNrZoneB)
        Me.Controls.Add(Me.LabelNRContrB)
        Me.Controls.Add(Me.LabelIDSALAB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRezeteazaB)
        Me.Controls.Add(Me.LabelIDSB)
        Me.Controls.Add(Me.TextBoxDenSpectacolCautaB)
        Me.Controls.Add(Me.ButtonCautaSPB)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGVSB)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBilete"
        Me.Text = "FormBilete"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVSB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonRezeteazaB As Button
    Friend WithEvents LabelIDSB As Label
    Friend WithEvents TextBoxDenSpectacolCautaB As TextBox
    Friend WithEvents ButtonCautaSPB As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DGVSB As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelIDSALAB As Label
    Friend WithEvents LabelNRContrB As Label
    Friend WithEvents LabelNrZoneB As Label
    Friend WithEvents ComboBoxZona As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelCostOrg As Label
    Friend WithEvents LabelPretBilet As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonCalcCost As Button
    Friend WithEvents ButtonCalcBilet As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxNrBilete As TextBox
    Friend WithEvents ButtonActualizNrBilete As Button
    Friend WithEvents ButtonAnuleazaSp As Button
    Friend WithEvents ButtonCalcNrBileteVdSICapSala As Button
    Friend WithEvents LabelDimensiuneSala As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LabelNrBileteVd As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ButtonZona As Button
    Friend WithEvents ButtonCalcPretBiletStandard As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonCCPuS As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonPuSCol As Button
    Friend WithEvents Button2 As Button
End Class
