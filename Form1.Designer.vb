<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHumid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lastWaterLbl = New System.Windows.Forms.Label()
        Me.btnWater = New System.Windows.Forms.Button()
        Me.hBtn = New System.Windows.Forms.Button()
        Me.aBtn = New System.Windows.Forms.Button()
        Me.lBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(185, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Humidity :"
        '
        'lblHumid
        '
        Me.lblHumid.AutoSize = True
        Me.lblHumid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblHumid.Location = New System.Drawing.Point(346, 26)
        Me.lblHumid.Name = "lblHumid"
        Me.lblHumid.Size = New System.Drawing.Size(0, 17)
        Me.lblHumid.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(185, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Temperature :"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTemp.Location = New System.Drawing.Point(346, 66)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(0, 17)
        Me.lblTemp.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(146, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(163, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Last Watering Date :"
        '
        'lastWaterLbl
        '
        Me.lastWaterLbl.AutoSize = True
        Me.lastWaterLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lastWaterLbl.Location = New System.Drawing.Point(346, 356)
        Me.lastWaterLbl.Name = "lastWaterLbl"
        Me.lastWaterLbl.Size = New System.Drawing.Size(0, 17)
        Me.lastWaterLbl.TabIndex = 6
        '
        'btnWater
        '
        Me.btnWater.Location = New System.Drawing.Point(204, 409)
        Me.btnWater.Name = "btnWater"
        Me.btnWater.Size = New System.Drawing.Size(181, 46)
        Me.btnWater.TabIndex = 7
        Me.btnWater.Text = "WATER THE PLANT"
        Me.btnWater.UseVisualStyleBackColor = True
        '
        'hBtn
        '
        Me.hBtn.BackColor = System.Drawing.Color.Lime
        Me.hBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.hBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hBtn.Location = New System.Drawing.Point(320, 151)
        Me.hBtn.Name = "hBtn"
        Me.hBtn.Size = New System.Drawing.Size(123, 47)
        Me.hBtn.TabIndex = 8
        Me.hBtn.Text = "High"
        Me.hBtn.UseVisualStyleBackColor = False
        '
        'aBtn
        '
        Me.aBtn.BackColor = System.Drawing.Color.Yellow
        Me.aBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.aBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.aBtn.Location = New System.Drawing.Point(320, 205)
        Me.aBtn.Name = "aBtn"
        Me.aBtn.Size = New System.Drawing.Size(123, 47)
        Me.aBtn.TabIndex = 11
        Me.aBtn.Text = "Average"
        Me.aBtn.UseVisualStyleBackColor = False
        '
        'lBtn
        '
        Me.lBtn.BackColor = System.Drawing.Color.Red
        Me.lBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lBtn.Location = New System.Drawing.Point(320, 258)
        Me.lBtn.Name = "lBtn"
        Me.lBtn.Size = New System.Drawing.Size(123, 47)
        Me.lBtn.TabIndex = 12
        Me.lBtn.Text = "Low"
        Me.lBtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(316, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Soil Moisture Level"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 513)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lBtn)
        Me.Controls.Add(Me.aBtn)
        Me.Controls.Add(Me.hBtn)
        Me.Controls.Add(Me.btnWater)
        Me.Controls.Add(Me.lastWaterLbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHumid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Plant Watering System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblHumid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lastWaterLbl As Label
    Friend WithEvents btnWater As Button
    Friend WithEvents hBtn As Button
    Friend WithEvents aBtn As Button
    Friend WithEvents lBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
