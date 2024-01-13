﻿Public Class soal1
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim inputNumber As Integer

        If Integer.TryParse(TextBox1.Text, inputNumber) Then
            ' Menggunakan fungsi IsOdd untuk mengecek bilangan ganjil
            If IsOdd(inputNumber) Then
                Label1.Text = "Bilangan Ganjil"
            Else
                Label1.Text = "Bilangan Genap"
            End If
        Else
            Label1.Text = "Masukkan bilangan yang valid"
        End If
    End Sub

    ' Fungsi untuk mengecek apakah bilangan ganjil
    Function IsOdd(ByVal value As Integer) As Boolean
        Return value Mod 2 <> 0
    End Function
End Class