


Public Class Form1


    Private Sub LoadPeno(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Interval = 1000
        Me.Timer1.Start()
        Me.ProgressBar1.Maximum = 5 * 1000
        lblHodnotaOdpoctu.Text = 5
        Me.Timer2.Interval = 1000
        Me.Timer2.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.ProgressBar1.Value += Me.Timer1.Interval
        Me.lblHodnotaOdpoctu.Text -= (Me.Timer1.Interval / 1000).ToString
        If Me.ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Timer1.Stop()

        End If


        'ToolStripStatusLabel2.Text = Now.ToString("HH:mm:ss")
        'ToolStripStatusLabel4.Text = Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub OtevřítToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiOtevrit.Click

        With openDial
            .Title = "Zvolte soubor"
            .Filter = "Vsechno (*.*)|*.*|Dokumenty (*.doc)|*.doc"
            .FilterIndex = 2
            .FileName = "C:\kurs\"
        End With

        Dim tlac As Windows.Forms.DialogResult
        tlac = openDial.ShowDialog()

        If (tlac.Equals(DialogResult.OK)) Then
            txTextZeSouboru.Text = My.Computer.FileSystem.ReadAllText(openDial.FileName)
        End If


    End Sub

    Private Sub UložitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiUlozit.Click
        With saveDial
            .Title = "Zadej nazev souboru a bud vyber priponu z nabidky nebo ji napis za tecku"
            .Filter = "Vsechno (*.*)|*.*| Textaky (*.txt)|*.txt| Solutiony (*.sln)|*.sln"
            .FilterIndex = 1
            .FileName = "c:\kurs\"
        End With

        Dim dialogResultPeno As Windows.Forms.DialogResult
        dialogResultPeno = saveDial.ShowDialog

        If dialogResultPeno.Equals(DialogResult.OK) Then
            FileOpen(1, saveDial.FileName, OpenMode.Output)
            Write(1, txTextZeSouboru.Text)
            FileClose(1)
        End If
    End Sub

    Private Sub KonecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KonecToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub NápovědaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiFAQ.Click
        MsgBox("Toto je napoveda ..")
    End Sub



    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ss2Sytost.Text = (TrackBar1.Value * 10).ToString + " %"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKonecProgramu.Click
        Me.Close()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        tssl3.Text = Now.ToString("HH:mm")
    End Sub


    Public Sub vypisvyberu()
        Dim a1 As String
        Dim a2 As String
        Dim a3 As String
        Dim a4 As String
        Dim a5 As String
        Dim a6 As String
        Dim a7 As String
        Dim a8 As String


        If rbFabia.Checked Then a1 = "fabia" Else a1 = ""
        If rbOctavia.Checked Then a2 = "octavia" Else a2 = ""
        If rbYeti.Checked Then a3 = "yeti" Else a3 = ""
        If rbRoomster.Checked Then a4 = "roomster" Else a4 = ""

        If chbSvetlomety.Checked Then a5 = " světlomety" Else a5 = ""
        If chbStresniNosic.Checked Then a6 = " střešní nosič" Else a6 = ""

        a7 = " " + NumericUpDown1.Value.ToString + " ks "
        a8 = " barva " + cmbBarvy.Text




        lblVypis.Text = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8
    End Sub

    Private Sub rbFabia_CheckedChanged(sender As Object, e As EventArgs) Handles rbFabia.CheckedChanged
        vypisvyberu()
    End Sub

    Private Sub rbOctavia_CheckedChanged(sender As Object, e As EventArgs) Handles rbOctavia.CheckedChanged
        vypisvyberu()
    End Sub

    Private Sub rbYeti_CheckedChanged(sender As Object, e As EventArgs) Handles rbYeti.CheckedChanged
        vypisvyberu()
    End Sub

    Private Sub rbRoomster_CheckedChanged(sender As Object, e As EventArgs) Handles rbRoomster.CheckedChanged
        vypisvyberu()
    End Sub

    Private Sub chbSvetlomety_CheckedChanged(sender As Object, e As EventArgs) Handles chbSvetlomety.CheckedChanged
        vypisvyberu()
    End Sub

    Private Sub chbStresniNosic_CheckedChanged(sender As Object, e As EventArgs) Handles chbStresniNosic.CheckedChanged
        vypisvyberu()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        vypisvyberu()
    End Sub

    Private Sub cmbBarvy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBarvy.SelectedIndexChanged
        vypisvyberu()
    End Sub
End Class

