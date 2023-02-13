<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dataGenerator))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxImage = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelNIM = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelDOB = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelProdi = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelAngkatan = New System.Windows.Forms.Label()
        Me.generateBtn = New System.Windows.Forms.Button()
        Me.CreatBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.createKTMBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.loadingPicture = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loadingPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Small", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(493, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GENERATE YOUR DATA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxImage
        '
        Me.PictureBoxImage.BackColor = System.Drawing.Color.White
        Me.PictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImage.Image = CType(resources.GetObject("PictureBoxImage.Image"), System.Drawing.Image)
        Me.PictureBoxImage.Location = New System.Drawing.Point(222, 120)
        Me.PictureBoxImage.Name = "PictureBoxImage"
        Me.PictureBoxImage.Size = New System.Drawing.Size(237, 316)
        Me.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImage.TabIndex = 2
        Me.PictureBoxImage.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.White
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpload.ForeColor = System.Drawing.Color.Black
        Me.btnUpload.Location = New System.Drawing.Point(222, 461)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(237, 51)
        Me.btnUpload.TabIndex = 3
        Me.btnUpload.Text = "UPLOAD IMAGE"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(578, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAMA            :"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.BackColor = System.Drawing.Color.Black
        Me.LabelNama.Font = New System.Drawing.Font("Segoe UI Variable Display Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNama.ForeColor = System.Drawing.Color.White
        Me.LabelNama.Location = New System.Drawing.Point(779, 120)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(0, 32)
        Me.LabelNama.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(578, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NIM                :"
        '
        'LabelNIM
        '
        Me.LabelNIM.AutoSize = True
        Me.LabelNIM.BackColor = System.Drawing.Color.Black
        Me.LabelNIM.Font = New System.Drawing.Font("Segoe UI Variable Display Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNIM.ForeColor = System.Drawing.Color.White
        Me.LabelNIM.Location = New System.Drawing.Point(777, 187)
        Me.LabelNIM.Name = "LabelNIM"
        Me.LabelNIM.Size = New System.Drawing.Size(0, 32)
        Me.LabelNIM.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(578, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 32)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tgl Lahir        :"
        '
        'LabelDOB
        '
        Me.LabelDOB.AutoSize = True
        Me.LabelDOB.BackColor = System.Drawing.Color.Black
        Me.LabelDOB.Font = New System.Drawing.Font("Segoe UI Variable Display Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelDOB.ForeColor = System.Drawing.Color.White
        Me.LabelDOB.Location = New System.Drawing.Point(777, 259)
        Me.LabelDOB.Name = "LabelDOB"
        Me.LabelDOB.Size = New System.Drawing.Size(0, 32)
        Me.LabelDOB.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(577, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 32)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Prodi              :"
        '
        'LabelProdi
        '
        Me.LabelProdi.AutoSize = True
        Me.LabelProdi.BackColor = System.Drawing.Color.Black
        Me.LabelProdi.Font = New System.Drawing.Font("Segoe UI Variable Display Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelProdi.ForeColor = System.Drawing.Color.White
        Me.LabelProdi.Location = New System.Drawing.Point(779, 334)
        Me.LabelProdi.Name = "LabelProdi"
        Me.LabelProdi.Size = New System.Drawing.Size(0, 32)
        Me.LabelProdi.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(576, 397)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 32)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Angkatan      :"
        '
        'LabelAngkatan
        '
        Me.LabelAngkatan.AutoSize = True
        Me.LabelAngkatan.BackColor = System.Drawing.Color.Black
        Me.LabelAngkatan.Font = New System.Drawing.Font("Segoe UI Variable Display Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelAngkatan.ForeColor = System.Drawing.Color.White
        Me.LabelAngkatan.Location = New System.Drawing.Point(779, 397)
        Me.LabelAngkatan.Name = "LabelAngkatan"
        Me.LabelAngkatan.Size = New System.Drawing.Size(0, 32)
        Me.LabelAngkatan.TabIndex = 13
        '
        'generateBtn
        '
        Me.generateBtn.BackColor = System.Drawing.Color.LightGreen
        Me.generateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.generateBtn.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.generateBtn.ForeColor = System.Drawing.Color.Black
        Me.generateBtn.Location = New System.Drawing.Point(810, 477)
        Me.generateBtn.Name = "generateBtn"
        Me.generateBtn.Size = New System.Drawing.Size(227, 51)
        Me.generateBtn.TabIndex = 14
        Me.generateBtn.Text = "GENERATE DATA"
        Me.generateBtn.UseVisualStyleBackColor = False
        '
        'CreatBtn
        '
        Me.CreatBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.CreatBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreatBtn.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreatBtn.ForeColor = System.Drawing.Color.White
        Me.CreatBtn.Location = New System.Drawing.Point(533, 477)
        Me.CreatBtn.Name = "CreatBtn"
        Me.CreatBtn.Size = New System.Drawing.Size(241, 51)
        Me.CreatBtn.TabIndex = 15
        Me.CreatBtn.Text = "CREATE NEW DATA"
        Me.CreatBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.PictureBox1.Location = New System.Drawing.Point(142, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1004, 632)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'createKTMBtn
        '
        Me.createKTMBtn.BackColor = System.Drawing.Color.White
        Me.createKTMBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createKTMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.createKTMBtn.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.createKTMBtn.ForeColor = System.Drawing.Color.Black
        Me.createKTMBtn.Location = New System.Drawing.Point(533, 569)
        Me.createKTMBtn.Name = "createKTMBtn"
        Me.createKTMBtn.Size = New System.Drawing.Size(504, 51)
        Me.createKTMBtn.TabIndex = 16
        Me.createKTMBtn.Text = "CREATE  KTM"
        Me.createKTMBtn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-1, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(438, 34)
        Me.ProgressBar1.TabIndex = 18
        Me.ProgressBar1.Visible = False
        '
        'loadingPicture
        '
        Me.loadingPicture.BackColor = System.Drawing.Color.Black
        Me.loadingPicture.Image = CType(resources.GetObject("loadingPicture.Image"), System.Drawing.Image)
        Me.loadingPicture.Location = New System.Drawing.Point(762, 199)
        Me.loadingPicture.Name = "loadingPicture"
        Me.loadingPicture.Size = New System.Drawing.Size(198, 167)
        Me.loadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loadingPicture.TabIndex = 17
        Me.loadingPicture.TabStop = False
        Me.loadingPicture.Visible = False
        '
        'dataGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1235, 696)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.loadingPicture)
        Me.Controls.Add(Me.createKTMBtn)
        Me.Controls.Add(Me.CreatBtn)
        Me.Controls.Add(Me.generateBtn)
        Me.Controls.Add(Me.LabelAngkatan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabelProdi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelDOB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelNIM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.PictureBoxImage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "dataGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dataGenerator"
        CType(Me.PictureBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loadingPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxImage As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelNIM As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelDOB As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelProdi As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelAngkatan As Label
    Friend WithEvents generateBtn As Button
    Friend WithEvents CreatBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents createKTMBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents loadingPicture As PictureBox
End Class
