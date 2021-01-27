<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txTextZeSouboru = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SouborToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOtevrit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUlozit = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFAQ = New System.Windows.Forms.ToolStripMenuItem()
        Me.openDial = New System.Windows.Forms.OpenFileDialog()
        Me.saveDial = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss2Sytost = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHodnotaOdpoctu = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVypis = New System.Windows.Forms.Button()
        Me.lblVypis = New System.Windows.Forms.Label()
        Me.rbRoomster = New System.Windows.Forms.RadioButton()
        Me.rbFabia = New System.Windows.Forms.RadioButton()
        Me.rbOctavia = New System.Windows.Forms.RadioButton()
        Me.rbYeti = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbSvetlomety = New System.Windows.Forms.CheckBox()
        Me.chbStresniNosic = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbBarvy = New System.Windows.Forms.ComboBox()
        Me.txtBoxMesto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnKonecProgramu = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txTextZeSouboru
        '
        Me.txTextZeSouboru.Location = New System.Drawing.Point(510, 207)
        Me.txTextZeSouboru.Multiline = True
        Me.txTextZeSouboru.Name = "txTextZeSouboru"
        Me.txTextZeSouboru.Size = New System.Drawing.Size(237, 197)
        Me.txTextZeSouboru.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SouborToolStripMenuItem, Me.tsmiFAQ})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SouborToolStripMenuItem
        '
        Me.SouborToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOtevrit, Me.tsmiUlozit, Me.KonecToolStripMenuItem})
        Me.SouborToolStripMenuItem.Name = "SouborToolStripMenuItem"
        Me.SouborToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SouborToolStripMenuItem.Text = "Soubor"
        '
        'tsmiOtevrit
        '
        Me.tsmiOtevrit.Name = "tsmiOtevrit"
        Me.tsmiOtevrit.Size = New System.Drawing.Size(110, 22)
        Me.tsmiOtevrit.Text = "Otevřít"
        '
        'tsmiUlozit
        '
        Me.tsmiUlozit.Name = "tsmiUlozit"
        Me.tsmiUlozit.Size = New System.Drawing.Size(110, 22)
        Me.tsmiUlozit.Text = "Uložit"
        '
        'KonecToolStripMenuItem
        '
        Me.KonecToolStripMenuItem.Name = "KonecToolStripMenuItem"
        Me.KonecToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.KonecToolStripMenuItem.Text = "Konec"
        '
        'tsmiFAQ
        '
        Me.tsmiFAQ.Name = "tsmiFAQ"
        Me.tsmiFAQ.Size = New System.Drawing.Size(41, 20)
        Me.tsmiFAQ.Text = "FAQ"
        '
        'openDial
        '
        Me.openDial.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ss2Sytost, Me.tssl3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(67, 17)
        Me.ToolStripStatusLabel1.Text = "STATUSBAR"
        '
        'ss2Sytost
        '
        Me.ss2Sytost.Name = "ss2Sytost"
        Me.ss2Sytost.Size = New System.Drawing.Size(32, 17)
        Me.ss2Sytost.Text = "50 %"
        '
        'tssl3
        '
        Me.tssl3.Name = "tssl3"
        Me.tssl3.Size = New System.Drawing.Size(42, 17)
        Me.tssl3.Text = "mm:ss"
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(32, 301)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(202, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(21, 368)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(196, 45)
        Me.TrackBar1.TabIndex = 4
        Me.TrackBar1.Value = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "stránka se načítá - čekejte ("
        '
        'lblHodnotaOdpoctu
        '
        Me.lblHodnotaOdpoctu.AutoSize = True
        Me.lblHodnotaOdpoctu.Location = New System.Drawing.Point(169, 338)
        Me.lblHodnotaOdpoctu.Name = "lblHodnotaOdpoctu"
        Me.lblHodnotaOdpoctu.Size = New System.Drawing.Size(13, 13)
        Me.lblHodnotaOdpoctu.TabIndex = 7
        Me.lblHodnotaOdpoctu.Text = "5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "v % sytost barvy"
        '
        'btnVypis
        '
        Me.btnVypis.BackgroundImage = CType(resources.GetObject("btnVypis.BackgroundImage"), System.Drawing.Image)
        Me.btnVypis.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVypis.Location = New System.Drawing.Point(36, 40)
        Me.btnVypis.Name = "btnVypis"
        Me.btnVypis.Size = New System.Drawing.Size(80, 45)
        Me.btnVypis.TabIndex = 9
        Me.btnVypis.Text = "Vypiš text do textboxu"
        Me.ToolTip1.SetToolTip(Me.btnVypis, "Vypise text ze souboru")
        Me.btnVypis.UseVisualStyleBackColor = True
        '
        'lblVypis
        '
        Me.lblVypis.AutoSize = True
        Me.lblVypis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblVypis.Location = New System.Drawing.Point(39, 101)
        Me.lblVypis.Name = "lblVypis"
        Me.lblVypis.Size = New System.Drawing.Size(177, 13)
        Me.lblVypis.TabIndex = 10
        Me.lblVypis.Text = "fabia světlomety střešní nosič"
        '
        'rbRoomster
        '
        Me.rbRoomster.AutoSize = True
        Me.rbRoomster.Location = New System.Drawing.Point(44, 125)
        Me.rbRoomster.Name = "rbRoomster"
        Me.rbRoomster.Size = New System.Drawing.Size(65, 17)
        Me.rbRoomster.TabIndex = 14
        Me.rbRoomster.TabStop = True
        Me.rbRoomster.Text = "roomster"
        Me.rbRoomster.UseVisualStyleBackColor = True
        '
        'rbFabia
        '
        Me.rbFabia.AutoSize = True
        Me.rbFabia.Location = New System.Drawing.Point(40, 33)
        Me.rbFabia.Name = "rbFabia"
        Me.rbFabia.Size = New System.Drawing.Size(48, 17)
        Me.rbFabia.TabIndex = 11
        Me.rbFabia.TabStop = True
        Me.rbFabia.Text = "fabia"
        Me.rbFabia.UseVisualStyleBackColor = True
        '
        'rbOctavia
        '
        Me.rbOctavia.AutoSize = True
        Me.rbOctavia.Location = New System.Drawing.Point(41, 63)
        Me.rbOctavia.Name = "rbOctavia"
        Me.rbOctavia.Size = New System.Drawing.Size(60, 17)
        Me.rbOctavia.TabIndex = 12
        Me.rbOctavia.TabStop = True
        Me.rbOctavia.Text = "octavia"
        Me.rbOctavia.UseVisualStyleBackColor = True
        '
        'rbYeti
        '
        Me.rbYeti.AutoSize = True
        Me.rbYeti.Location = New System.Drawing.Point(44, 96)
        Me.rbYeti.Name = "rbYeti"
        Me.rbYeti.Size = New System.Drawing.Size(41, 17)
        Me.rbYeti.TabIndex = 13
        Me.rbYeti.TabStop = True
        Me.rbYeti.Text = "yeti"
        Me.rbYeti.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRoomster)
        Me.GroupBox1.Controls.Add(Me.rbYeti)
        Me.GroupBox1.Controls.Add(Me.rbOctavia)
        Me.GroupBox1.Controls.Add(Me.rbFabia)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 149)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vyberte typ auta"
        '
        'chbSvetlomety
        '
        Me.chbSvetlomety.AutoSize = True
        Me.chbSvetlomety.Location = New System.Drawing.Point(267, 152)
        Me.chbSvetlomety.Name = "chbSvetlomety"
        Me.chbSvetlomety.Size = New System.Drawing.Size(76, 17)
        Me.chbSvetlomety.TabIndex = 16
        Me.chbSvetlomety.Text = "světlomety"
        Me.chbSvetlomety.UseVisualStyleBackColor = True
        '
        'chbStresniNosic
        '
        Me.chbStresniNosic.AutoSize = True
        Me.chbStresniNosic.Location = New System.Drawing.Point(267, 192)
        Me.chbStresniNosic.Name = "chbStresniNosic"
        Me.chbStresniNosic.Size = New System.Drawing.Size(87, 17)
        Me.chbStresniNosic.TabIndex = 17
        Me.chbStresniNosic.Text = "střešní nosič"
        Me.chbStresniNosic.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(267, 225)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(69, 20)
        Me.NumericUpDown1.TabIndex = 18
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Kolik kusů ? (max 3)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(504, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Barva auta:"
        '
        'cmbBarvy
        '
        Me.cmbBarvy.FormattingEnabled = True
        Me.cmbBarvy.Items.AddRange(New Object() {"růžová", "fialová", "tyrkisová"})
        Me.cmbBarvy.Location = New System.Drawing.Point(505, 146)
        Me.cmbBarvy.Name = "cmbBarvy"
        Me.cmbBarvy.Size = New System.Drawing.Size(175, 21)
        Me.cmbBarvy.TabIndex = 21
        Me.cmbBarvy.Text = "růžová"
        '
        'txtBoxMesto
        '
        Me.txtBoxMesto.Location = New System.Drawing.Point(364, 53)
        Me.txtBoxMesto.Name = "txtBoxMesto"
        Me.txtBoxMesto.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxMesto.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(470, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "+"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(489, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(84, 20)
        Me.TextBox2.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(579, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(598, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "město, PSČ"
        '
        'btnKonecProgramu
        '
        Me.btnKonecProgramu.Location = New System.Drawing.Point(635, 91)
        Me.btnKonecProgramu.Name = "btnKonecProgramu"
        Me.btnKonecProgramu.Size = New System.Drawing.Size(112, 32)
        Me.btnKonecProgramu.TabIndex = 27
        Me.btnKonecProgramu.Text = "konec PROGRAMU"
        Me.btnKonecProgramu.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(390, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "město"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(508, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "PSČ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "s)"
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AcceptButton = Me.btnKonecProgramu
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnKonecProgramu)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBoxMesto)
        Me.Controls.Add(Me.cmbBarvy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.chbStresniNosic)
        Me.Controls.Add(Me.chbSvetlomety)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblVypis)
        Me.Controls.Add(Me.btnVypis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblHodnotaOdpoctu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txTextZeSouboru)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txTextZeSouboru As Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents SouborToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiOtevrit As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiUlozit As Windows.Forms.ToolStripMenuItem
    Friend WithEvents KonecToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiFAQ As Windows.Forms.ToolStripMenuItem
    Friend WithEvents openDial As Windows.Forms.OpenFileDialog
    Friend WithEvents saveDial As Windows.Forms.SaveFileDialog
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss2Sytost As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssl3 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As Windows.Forms.ProgressBar
    Friend WithEvents TrackBar1 As Windows.Forms.TrackBar
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents lblHodnotaOdpoctu As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents btnVypis As Windows.Forms.Button
    Friend WithEvents lblVypis As Windows.Forms.Label
    Friend WithEvents rbRoomster As Windows.Forms.RadioButton
    Friend WithEvents rbFabia As Windows.Forms.RadioButton
    Friend WithEvents rbOctavia As Windows.Forms.RadioButton
    Friend WithEvents rbYeti As Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents chbSvetlomety As Windows.Forms.CheckBox
    Friend WithEvents chbStresniNosic As Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents cmbBarvy As Windows.Forms.ComboBox
    Friend WithEvents txtBoxMesto As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents btnKonecProgramu As Windows.Forms.Button
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Timer2 As Windows.Forms.Timer
End Class
