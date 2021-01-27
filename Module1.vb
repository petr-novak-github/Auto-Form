Module Module1

    Sub Main()



        Dim myForm As New Form1
        Dim ret As String

        ret = InputBox("Zadej, jaké město se objeví v textboxu na začátku")

        myForm.txtBoxMesto.Text = ret

        myForm.ShowDialog()



    End Sub

End Module
