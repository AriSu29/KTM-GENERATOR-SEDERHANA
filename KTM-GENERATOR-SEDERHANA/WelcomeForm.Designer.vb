<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.createData = New System.Windows.Forms.Button()
        Me.generateBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.loadingPicture = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loadingPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(205, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(855, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'createData
        '
        Me.createData.BackColor = System.Drawing.Color.PaleGreen
        Me.createData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createData.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.createData.Location = New System.Drawing.Point(276, 460)
        Me.createData.Name = "createData"
        Me.createData.Size = New System.Drawing.Size(215, 65)
        Me.createData.TabIndex = 1
        Me.createData.Text = "CREATE DATA"
        Me.createData.UseMnemonic = False
        Me.createData.UseVisualStyleBackColor = False
        '
        'generateBtn
        '
        Me.generateBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.generateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generateBtn.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.generateBtn.Location = New System.Drawing.Point(786, 460)
        Me.generateBtn.Name = "generateBtn"
        Me.generateBtn.Size = New System.Drawing.Size(219, 65)
        Me.generateBtn.TabIndex = 2
        Me.generateBtn.Text = "GENERATE DATA"
        Me.generateBtn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(379, 23)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(493, 34)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'loadingPicture
        '
        Me.loadingPicture.BackColor = System.Drawing.Color.Transparent
        Me.loadingPicture.Image = CType(resources.GetObject("loadingPicture.Image"), System.Drawing.Image)
        Me.loadingPicture.Location = New System.Drawing.Point(542, 326)
        Me.loadingPicture.Name = "loadingPicture"
        Me.loadingPicture.Size = New System.Drawing.Size(198, 167)
        Me.loadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loadingPicture.TabIndex = 4
        Me.loadingPicture.TabStop = False
        Me.loadingPicture.Visible = False
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1233, 734)
        Me.Controls.Add(Me.loadingPicture)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.generateBtn)
        Me.Controls.Add(Me.createData)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "WelcomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WelcomeForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loadingPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents createData As Button
    Friend WithEvents generateBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents loadingPicture As PictureBox
End Class
