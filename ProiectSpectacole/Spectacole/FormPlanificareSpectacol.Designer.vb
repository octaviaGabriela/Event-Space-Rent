<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlanificareSpectacol
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
        Me.ButtonBiletePuS = New System.Windows.Forms.Button()
        Me.ButtonPuSCol = New System.Windows.Forms.Button()
        Me.ButtonCCPuS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonRezeteazaPL = New System.Windows.Forms.Button()
        Me.ButtonCautaPL = New System.Windows.Forms.Button()
        Me.ButtonPlanificaSpectacol = New System.Windows.Forms.Button()
        Me.DataGridViewPL = New System.Windows.Forms.DataGridView()
        Me.DateTimePickerDataSpectacolPL = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelMinute = New System.Windows.Forms.Label()
        Me.TextBoxOraIPL = New System.Windows.Forms.TextBox()
        Me.TextBoxOraSPL = New System.Windows.Forms.TextBox()
        Me.TextBoxDenPS = New System.Windows.Forms.TextBox()
        Me.TextBoxDEnCautaPS = New System.Windows.Forms.TextBox()
        Me.TextBoxStatusSpectacolCautaPL = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonCalcDurata = New System.Windows.Forms.Button()
        Me.LabelDurataspectacolMinute = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBoxSala = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewPL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ButtonBiletePuS)
        Me.Panel1.Controls.Add(Me.ButtonPuSCol)
        Me.Panel1.Controls.Add(Me.ButtonCCPuS)
        Me.Panel1.Location = New System.Drawing.Point(2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 639)
        Me.Panel1.TabIndex = 1
        '
        'ButtonBiletePuS
        '
        Me.ButtonBiletePuS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonBiletePuS.Location = New System.Drawing.Point(35, 330)
        Me.ButtonBiletePuS.Name = "ButtonBiletePuS"
        Me.ButtonBiletePuS.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBiletePuS.TabIndex = 2
        Me.ButtonBiletePuS.Text = "Bilete"
        Me.ButtonBiletePuS.UseVisualStyleBackColor = False
        '
        'ButtonPuSCol
        '
        Me.ButtonPuSCol.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonPuSCol.Location = New System.Drawing.Point(12, 116)
        Me.ButtonPuSCol.Name = "ButtonPuSCol"
        Me.ButtonPuSCol.Size = New System.Drawing.Size(122, 38)
        Me.ButtonPuSCol.TabIndex = 1
        Me.ButtonPuSCol.Text = "Colectare date " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "artist și reprezentant"
        Me.ButtonPuSCol.UseVisualStyleBackColor = False
        '
        'ButtonCCPuS
        '
        Me.ButtonCCPuS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonCCPuS.Location = New System.Drawing.Point(21, 192)
        Me.ButtonCCPuS.Name = "ButtonCCPuS"
        Me.ButtonCCPuS.Size = New System.Drawing.Size(105, 23)
        Me.ButtonCCPuS.TabIndex = 3
        Me.ButtonCCPuS.Text = "Creare contract"
        Me.ButtonCCPuS.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Planificare spectacol"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Oră de sfârșit spectacol"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Oră de început spectacol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Dată spectacol"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Denumire spectacol"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(172, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Număr sală "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(172, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Durată spectacol"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(172, 430)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Caută după..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(172, 461)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Denumire sală"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(494, 466)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Status spectacol"
        '
        'ButtonRezeteazaPL
        '
        Me.ButtonRezeteazaPL.Location = New System.Drawing.Point(607, 377)
        Me.ButtonRezeteazaPL.Name = "ButtonRezeteazaPL"
        Me.ButtonRezeteazaPL.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRezeteazaPL.TabIndex = 16
        Me.ButtonRezeteazaPL.Text = "Resetează"
        Me.ButtonRezeteazaPL.UseVisualStyleBackColor = True
        '
        'ButtonCautaPL
        '
        Me.ButtonCautaPL.Location = New System.Drawing.Point(823, 465)
        Me.ButtonCautaPL.Name = "ButtonCautaPL"
        Me.ButtonCautaPL.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCautaPL.TabIndex = 17
        Me.ButtonCautaPL.Text = "Caută"
        Me.ButtonCautaPL.UseVisualStyleBackColor = True
        '
        'ButtonPlanificaSpectacol
        '
        Me.ButtonPlanificaSpectacol.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonPlanificaSpectacol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonPlanificaSpectacol.Location = New System.Drawing.Point(397, 377)
        Me.ButtonPlanificaSpectacol.Name = "ButtonPlanificaSpectacol"
        Me.ButtonPlanificaSpectacol.Size = New System.Drawing.Size(163, 23)
        Me.ButtonPlanificaSpectacol.TabIndex = 18
        Me.ButtonPlanificaSpectacol.Text = "Planifică spectacol"
        Me.ButtonPlanificaSpectacol.UseVisualStyleBackColor = False
        '
        'DataGridViewPL
        '
        Me.DataGridViewPL.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridViewPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPL.Location = New System.Drawing.Point(264, 522)
        Me.DataGridViewPL.Name = "DataGridViewPL"
        Me.DataGridViewPL.Size = New System.Drawing.Size(625, 103)
        Me.DataGridViewPL.TabIndex = 19
        '
        'DateTimePickerDataSpectacolPL
        '
        Me.DateTimePickerDataSpectacolPL.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerDataSpectacolPL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDataSpectacolPL.Location = New System.Drawing.Point(335, 121)
        Me.DateTimePickerDataSpectacolPL.Name = "DateTimePickerDataSpectacolPL"
        Me.DateTimePickerDataSpectacolPL.Size = New System.Drawing.Size(77, 20)
        Me.DateTimePickerDataSpectacolPL.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(290, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 16)
        Me.Label12.TabIndex = 21
        '
        'LabelMinute
        '
        Me.LabelMinute.AutoSize = True
        Me.LabelMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelMinute.Location = New System.Drawing.Point(332, 250)
        Me.LabelMinute.Name = "LabelMinute"
        Me.LabelMinute.Size = New System.Drawing.Size(43, 13)
        Me.LabelMinute.TabIndex = 22
        Me.LabelMinute.Text = "durată"
        '
        'TextBoxOraIPL
        '
        Me.TextBoxOraIPL.Location = New System.Drawing.Point(335, 165)
        Me.TextBoxOraIPL.Name = "TextBoxOraIPL"
        Me.TextBoxOraIPL.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxOraIPL.TabIndex = 24
        '
        'TextBoxOraSPL
        '
        Me.TextBoxOraSPL.Location = New System.Drawing.Point(335, 209)
        Me.TextBoxOraSPL.Name = "TextBoxOraSPL"
        Me.TextBoxOraSPL.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxOraSPL.TabIndex = 25
        '
        'TextBoxDenPS
        '
        Me.TextBoxDenPS.Location = New System.Drawing.Point(335, 73)
        Me.TextBoxDenPS.Name = "TextBoxDenPS"
        Me.TextBoxDenPS.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDenPS.TabIndex = 27
        '
        'TextBoxDEnCautaPS
        '
        Me.TextBoxDEnCautaPS.Location = New System.Drawing.Point(273, 460)
        Me.TextBoxDEnCautaPS.Name = "TextBoxDEnCautaPS"
        Me.TextBoxDEnCautaPS.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxDEnCautaPS.TabIndex = 28
        '
        'TextBoxStatusSpectacolCautaPL
        '
        Me.TextBoxStatusSpectacolCautaPL.Location = New System.Drawing.Point(607, 465)
        Me.TextBoxStatusSpectacolCautaPL.Name = "TextBoxStatusSpectacolCautaPL"
        Me.TextBoxStatusSpectacolCautaPL.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxStatusSpectacolCautaPL.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(530, 504)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 15)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Spectacole"
        '
        'ButtonCalcDurata
        '
        Me.ButtonCalcDurata.Location = New System.Drawing.Point(712, 245)
        Me.ButtonCalcDurata.Name = "ButtonCalcDurata"
        Me.ButtonCalcDurata.Size = New System.Drawing.Size(198, 23)
        Me.ButtonCalcDurata.TabIndex = 32
        Me.ButtonCalcDurata.Text = "Calculează durată spectacol în minute"
        Me.ButtonCalcDurata.UseVisualStyleBackColor = True
        '
        'LabelDurataspectacolMinute
        '
        Me.LabelDurataspectacolMinute.AutoSize = True
        Me.LabelDurataspectacolMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelDurataspectacolMinute.Location = New System.Drawing.Point(564, 250)
        Me.LabelDurataspectacolMinute.Name = "LabelDurataspectacolMinute"
        Me.LabelDurataspectacolMinute.Size = New System.Drawing.Size(44, 13)
        Me.LabelDurataspectacolMinute.TabIndex = 33
        Me.LabelDurataspectacolMinute.Text = "minute"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.Location = New System.Drawing.Point(614, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = " minute"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(394, 250)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "ore,minute,secunde"
        '
        'ComboBoxSala
        '
        Me.ComboBoxSala.FormattingEnabled = True
        Me.ComboBoxSala.Location = New System.Drawing.Point(335, 290)
        Me.ComboBoxSala.Name = "ComboBoxSala"
        Me.ComboBoxSala.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxSala.TabIndex = 36
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(21, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Vizualizare " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " contracte"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormPlanificareSpectacol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 637)
        Me.Controls.Add(Me.ComboBoxSala)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LabelDurataspectacolMinute)
        Me.Controls.Add(Me.ButtonCalcDurata)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBoxStatusSpectacolCautaPL)
        Me.Controls.Add(Me.TextBoxDEnCautaPS)
        Me.Controls.Add(Me.TextBoxDenPS)
        Me.Controls.Add(Me.TextBoxOraSPL)
        Me.Controls.Add(Me.TextBoxOraIPL)
        Me.Controls.Add(Me.LabelMinute)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DateTimePickerDataSpectacolPL)
        Me.Controls.Add(Me.DataGridViewPL)
        Me.Controls.Add(Me.ButtonPlanificaSpectacol)
        Me.Controls.Add(Me.ButtonCautaPL)
        Me.Controls.Add(Me.ButtonRezeteazaPL)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPlanificareSpectacol"
        Me.Text = "FormPlanificareSpectacol"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewPL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonBiletePuS As Button
    Friend WithEvents ButtonPuSCol As Button
    Friend WithEvents ButtonCCPuS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonRezeteazaPL As Button
    Friend WithEvents ButtonCautaPL As Button
    Friend WithEvents ButtonPlanificaSpectacol As Button
    Friend WithEvents DataGridViewPL As DataGridView
    Friend WithEvents DateTimePickerDataSpectacolPL As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelMinute As Label
    Friend WithEvents TextBoxOraIPL As TextBox
    Friend WithEvents TextBoxOraSPL As TextBox
    Friend WithEvents TextBoxDenPS As TextBox
    Friend WithEvents TextBoxDEnCautaPS As TextBox
    Friend WithEvents TextBoxStatusSpectacolCautaPL As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ButtonCalcDurata As Button
    Friend WithEvents LabelDurataspectacolMinute As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBoxSala As ComboBox
    Friend WithEvents Button2 As Button
End Class
