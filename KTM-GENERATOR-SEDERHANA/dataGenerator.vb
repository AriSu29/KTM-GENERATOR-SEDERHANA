Imports System.IO

Public Class dataGenerator

    Dim isSuccess As Boolean = False

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ImageCaller()
    End Sub

    Private Sub CreatBtn_Click(sender As Object, e As EventArgs) Handles CreatBtn.Click
        formFieldEraser()
        Me.Hide()
    End Sub

    Private Sub generateBtn_Click(sender As Object, e As EventArgs) Handles generateBtn.Click
        fileCaller()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadingCompleteTimer1()
    End Sub

    Private Sub createKTMBtn_Click(sender As Object, e As EventArgs) Handles createKTMBtn.Click
        KTMGenerator()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        loadingCompleteTimer2()
    End Sub

    Private Function generateData()
        Dim eidForm As New EIDMHS()
        eidForm.imgPicture.Image = PictureBoxImage.Image
        eidForm.labelNama.Text = LabelNama.Text
        eidForm.labelNim.Text = LabelNIM.Text
        eidForm.LabelDOB.Text = LabelDOB.Text
        eidForm.LabelProdi.Text = LabelProdi.Text
        eidForm.LabelAngkatan.Text = LabelAngkatan.Text
        eidForm.Show()
        Me.Hide()
    End Function

    Private Function ImageCaller()
        ' UPLOAD IMAGE HANDLER
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        openFileDialog1.Title = "Pilih Gambar"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Menetapkan gambar terpilih ke PictureBox
            PictureBoxImage.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Function

    Private Function loadingCompleteTimer1()
        ProgressBar1.Value += 10
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()
            loadingPicture.Visible = False
            ProgressBar1.Value = 0
            labelVisibilityTrue()
            MessageBox.Show("Data berhasil dibuka!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function

    Private Function loadingCompleteTimer2()
        ProgressBar1.Value += 10

        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer2.Stop()
            loadingPicture.Visible = False
            ProgressBar1.Value = 0
            generateData()

        End If
    End Function

    Private Function fileCaller()
        'UPLOAD FILE HANDLER
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "File Teks|*.txt"
        openDialog.Title = "Buka Data Teks"

        ' Menampilkan dialog untuk memilih file yang akan dibuka
        If openDialog.ShowDialog() = DialogResult.OK Then

            ' Membaca data teks dari file
            Dim lines() As String = File.ReadAllLines(openDialog.FileName)

            If lines.Length >= 5 Then
                ' Pastikan file memiliki setidaknya 5 baris
                Timer1.Start()
                loadingPicture.Visible = True
                labelVisibilityFalse()
                ' Array untuk menyimpan label-label di form
                Dim labels() As Label = {LabelNama, LabelNIM, LabelDOB, LabelProdi, LabelAngkatan}

                ' Mengisi label dengan data dari file menggunakan perulangan
                For i As Integer = 0 To 4
                    labels(i).Text = lines(i).Substring(lines(i).IndexOf(":") + 1)
                Next
                isSuccess = True
            Else
                MessageBox.Show("File tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Function

    Private Function labelVisibilityFalse()
        LabelNama.Visible = False
        LabelNIM.Visible = False
        LabelDOB.Visible = False
        LabelProdi.Visible = False
        LabelAngkatan.Visible = False
    End Function

    Private Function labelVisibilityTrue()
        LabelNama.Visible = True
        LabelNIM.Visible = True
        LabelDOB.Visible = True
        LabelProdi.Visible = True
        LabelAngkatan.Visible = True
    End Function

    Private Function formFieldEraser()
        formDataUser.Show()
        PictureBoxImage.Image = PictureBoxImage.Image
        LabelNama.Text = ""
        LabelNIM.Text = ""
        LabelDOB.Text = ""
        LabelProdi.Text = ""
        LabelAngkatan.Text = ""
    End Function

    Private Function KTMGenerator()
        ' Menampilkan form EIDMHS dan mengirimkan data mahasiswa
        If Not isSuccess Then
            MessageBox.Show("Silahkan Generate Data Terlebih Dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Timer2.Start()
            loadingPicture.Visible = True
        End If
    End Function

End Class