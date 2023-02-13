Public Class WelcomeForm

    Private Sub createData_Click(sender As Object, e As EventArgs) Handles createData.Click
        ProgressBar1.Value = 0
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadingPicture.Visible = True
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            loadingPicture.Visible = False
            formDataUser.Show()
            Me.Hide()

        Else
            ProgressBar1.PerformStep()
        End If

    End Sub

    Private Sub generateBtn_Click(sender As Object, e As EventArgs) Handles generateBtn.Click
        ProgressBar1.Value = 0
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        loadingPicture.Visible = True
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer2.Stop()
            loadingPicture.Visible = False
            dataGenerator.Show()
            Me.Hide()

        Else
            ProgressBar1.PerformStep()
        End If
    End Sub
End Class