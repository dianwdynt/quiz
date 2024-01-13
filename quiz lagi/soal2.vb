Public Class soal2
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        ' Mendapatkan input dari pengguna
        Dim nim As String = TextBox1.Text
        Dim nama As String = TextBox2.Text
        Dim kelas As String = TextBox3.Text
        Dim nilaiUTS As Double = TextBox4.Text
        Dim nilaiUAS As Double = TextBox5.Text
        Dim nilaiTugas As Double = TextBox6.Text

        If Not Double.TryParse(TextBox4.Text, nilaiUTS) Then
            MessageBox.Show("Masukkan nilai UTS yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Double.TryParse(TextBox5.Text, nilaiUAS) Then
            MessageBox.Show("Masukkan nilai UAS yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Double.TryParse(TextBox6.Text, nilaiTugas) Then
            MessageBox.Show("Masukkan nilai Tugas yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Menghitung nilai akhir
        Dim nilaiAkhir As Double = (nilaiUTS * 0.3) + (nilaiUAS * 0.5) + (nilaiTugas * 0.2)

        ' Menentukan hasil kelulusan
        Dim hasil As String
        If nilaiAkhir >= 60 Then
            hasil = "Lulus"
        Else
            hasil = "Tidak Lulus"
        End If

        ' Menampilkan hasil di ListView
        Dim item As New ListViewItem(hasil)
        item.SubItems.Add(nama)
        item.SubItems.Add(kelas)
        item.SubItems.Add(nilaiUTS.ToString())
        item.SubItems.Add(nilaiUAS.ToString())
        item.SubItems.Add(nilaiTugas.ToString())
        item.SubItems.Add(nilaiAkhir.ToString())
        item.SubItems.Add(hasil)

        ' Menambahkan kolom-kolom ke ListView jika belum ditambahkan
        If ListView1.Columns.Count = 0 Then
            ListView1.Columns.Add("NIM")
            ListView1.Columns.Add("NAMA")
            ListView1.Columns.Add("KELAS")
            ListView1.Columns.Add("NILAI UTS")
            ListView1.Columns.Add("NILAI UAS")
            ListView1.Columns.Add("NILAI Tugas")
            ListView1.Columns.Add("NILAI Akhir")
            ListView1.Columns.Add("HASIL")
        End If

        ListView1.Items.Add(item)
    End Sub
End Class