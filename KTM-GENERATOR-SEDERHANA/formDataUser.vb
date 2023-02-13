
Imports System.IO

Public Class formDataUser
    Private Sub formDataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengatur default dari comboBox
        ComboBoxProdi.SelectedIndex = 0
        ComboBoxAngkatan.SelectedIndex = 0
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        SimpanData()
    End Sub

    Private Function ValidasiInput() As Boolean
        ' validasi nama
        If TextBoxNama.Text.Trim() = "" Then
            MsgBox("Nama harus diisi!", MsgBoxStyle.Exclamation, "Peringatan")
            TextBoxNama.Focus()
            Return False
        End If

        'validasi NIM
        If Not IsNumeric(TextBoxNIM.Text) Then
            MsgBox("NIM harus diisi dengan Angka!", MsgBoxStyle.Exclamation, "Peringatan")
            TextBoxNIM.Focus()
            TextBoxNIM.Text = "" ' mereset nilai pada kotak teks NIM
            Return False
        End If

        ' validasi tanggal lahir
        If DateTimePickerDOB.Value > Date.Now Then
            MsgBox("Tanggal lahir tidak valid!", MsgBoxStyle.Exclamation, "Peringatan")
            DateTimePickerDOB.Focus()
            Return False
        End If

        ' validasi prodi
        If ComboBoxProdi.SelectedIndex = 0 Then
            MsgBox("Prodi harus dipilih!", MsgBoxStyle.Exclamation, "Peringatan")
            ComboBoxProdi.Focus()
            Return False
        End If

        ' validasi angkatan
        If ComboBoxAngkatan.SelectedIndex = 0 Then
            MsgBox("Angkatan harus dipilih!", MsgBoxStyle.Exclamation, "Peringatan")
            ComboBoxAngkatan.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub SimpanData()
        ' Membuat objek SaveFileDialog untuk menyimpan data teks
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "File Teks|*.txt"
        saveDialog.Title = "Simpan Data Teks"

        If ValidasiInput() Then
            ' Menampilkan dialog untuk memilih lokasi file penyimpanan
            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' Menyimpan data teks ke dalam file
                Dim data() As String = {
                "Nama: " & TextBoxNama.Text,
                "NIM: " & TextBoxNIM.Text,
                "Tanggal Lahir: " & DateTimePickerDOB.Value.ToString("dd MMMM yyyy"),
                "Prodi: " & ComboBoxProdi.SelectedItem.ToString(),
                "Angkatan: " & ComboBoxAngkatan.SelectedItem.ToString()
            }

                Using writer As New StreamWriter(saveDialog.FileName)
                    For i As Integer = 0 To 4
                        writer.WriteLine(data(i))
                    Next
                End Using

                ' Menampilkan notifikasi jika data berhasil disimpan
                MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Mereset semua kontrol menjadi nilai awal
                TextBoxNama.Text = ""
                TextBoxNIM.Text = ""
                ComboBoxProdi.SelectedIndex = 0
                ComboBoxAngkatan.SelectedIndex = 0
                DateTimePickerDOB.Value = DateTime.Now
            End If

            ' Menampilkan progress bar dan kembali ke WelcomeForm setelah data tersimpan
            LoadingImage.Visible = True
            dataTimer.Start()
        End If
    End Sub


    Private Sub dataTimer_Tick(sender As Object, e As EventArgs) Handles dataTimer.Tick
        If dataProgress.Value = dataProgress.Maximum Then
            LoadingImage.Visible = False
            dataTimer.Stop()
            Me.Hide()
            WelcomeForm.Show()
        Else
            dataProgress.PerformStep()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WelcomeForm.Show()
        Me.Hide()
    End Sub

End Class