<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDataUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDataUser))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxNIM = New System.Windows.Forms.TextBox()
        Me.DateTimePickerDOB = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxProdi = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAngkatan = New System.Windows.Forms.ComboBox()
        Me.dataTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dataProgress = New System.Windows.Forms.ProgressBar()
        Me.LoadingImage = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PictureBox1.Location = New System.Drawing.Point(170, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(911, 587)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(503, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CREATE NEW DATA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Variable Small", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(315, 431)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(212, 37)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Angkatan       :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Variable Small", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(316, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(209, 37)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Prodi              :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Variable Small", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(317, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 37)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Tgl Lahir         :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Small", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(317, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 37)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "NIM                :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Small", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(317, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 37)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "NAMA            :"
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.LightGreen
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Segoe UI Variable Small", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.saveBtn.Location = New System.Drawing.Point(752, 516)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(232, 63)
        Me.saveBtn.TabIndex = 23
        Me.saveBtn.Text = "SIMPAN DATA"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Font = New System.Drawing.Font("Segoe UI Variable Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxNama.Location = New System.Drawing.Point(579, 162)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(405, 39)
        Me.TextBoxNama.TabIndex = 24
        '
        'TextBoxNIM
        '
        Me.TextBoxNIM.Font = New System.Drawing.Font("Segoe UI Variable Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxNIM.Location = New System.Drawing.Point(579, 227)
        Me.TextBoxNIM.Name = "TextBoxNIM"
        Me.TextBoxNIM.Size = New System.Drawing.Size(405, 39)
        Me.TextBoxNIM.TabIndex = 25
        '
        'DateTimePickerDOB
        '
        Me.DateTimePickerDOB.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerDOB.Location = New System.Drawing.Point(579, 294)
        Me.DateTimePickerDOB.Name = "DateTimePickerDOB"
        Me.DateTimePickerDOB.Size = New System.Drawing.Size(405, 37)
        Me.DateTimePickerDOB.TabIndex = 28
        '
        'ComboBoxProdi
        '
        Me.ComboBoxProdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProdi.Font = New System.Drawing.Font("Segoe UI Variable Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxProdi.FormattingEnabled = True
        Me.ComboBoxProdi.Items.AddRange(New Object() {"Pilih Prodi", "Sistem Informasi", "Informatika", "Manajemen", "Komunikasi"})
        Me.ComboBoxProdi.Location = New System.Drawing.Point(579, 361)
        Me.ComboBoxProdi.Name = "ComboBoxProdi"
        Me.ComboBoxProdi.Size = New System.Drawing.Size(405, 40)
        Me.ComboBoxProdi.TabIndex = 29
        '
        'ComboBoxAngkatan
        '
        Me.ComboBoxAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAngkatan.Font = New System.Drawing.Font("Segoe UI Variable Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxAngkatan.FormattingEnabled = True
        Me.ComboBoxAngkatan.Items.AddRange(New Object() {"Pilih Angkatan", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.ComboBoxAngkatan.Location = New System.Drawing.Point(579, 428)
        Me.ComboBoxAngkatan.Name = "ComboBoxAngkatan"
        Me.ComboBoxAngkatan.Size = New System.Drawing.Size(405, 40)
        Me.ComboBoxAngkatan.TabIndex = 30
        '
        'dataTimer
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Location = New System.Drawing.Point(992, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(15)
        Me.Button1.Size = New System.Drawing.Size(74, 65)
        Me.Button1.TabIndex = 33
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dataProgress
        '
        Me.dataProgress.Location = New System.Drawing.Point(413, 12)
        Me.dataProgress.Name = "dataProgress"
        Me.dataProgress.Size = New System.Drawing.Size(472, 25)
        Me.dataProgress.TabIndex = 31
        Me.dataProgress.Visible = False
        '
        'LoadingImage
        '
        Me.LoadingImage.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.LoadingImage.Image = CType(resources.GetObject("LoadingImage.Image"), System.Drawing.Image)
        Me.LoadingImage.Location = New System.Drawing.Point(559, 224)
        Me.LoadingImage.Name = "LoadingImage"
        Me.LoadingImage.Size = New System.Drawing.Size(193, 167)
        Me.LoadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LoadingImage.TabIndex = 32
        Me.LoadingImage.TabStop = False
        Me.LoadingImage.Visible = False
        '
        'formDataUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1254, 698)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LoadingImage)
        Me.Controls.Add(Me.dataProgress)
        Me.Controls.Add(Me.ComboBoxAngkatan)
        Me.Controls.Add(Me.ComboBoxProdi)
        Me.Controls.Add(Me.DateTimePickerDOB)
        Me.Controls.Add(Me.TextBoxNIM)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "formDataUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formDataUser"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxNIM As TextBox
    Friend WithEvents DateTimePickerDOB As DateTimePicker
    Friend WithEvents ComboBoxProdi As ComboBox
    Friend WithEvents ComboBoxAngkatan As ComboBox
    Friend WithEvents dataTimer As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents dataProgress As ProgressBar
    Friend WithEvents LoadingImage As PictureBox
End Class
