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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ftank = New System.Windows.Forms.TextBox()
        Me.B1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.mony = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.happyy = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hung = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cleany = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ftank
        '
        Me.ftank.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ftank.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ftank.Location = New System.Drawing.Point(325, 223)
        Me.ftank.Multiline = True
        Me.ftank.Name = "ftank"
        Me.ftank.Size = New System.Drawing.Size(699, 363)
        Me.ftank.TabIndex = 0
        Me.ftank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(31, 28)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(174, 39)
        Me.B1.TabIndex = 1
        Me.B1.Text = "start/restart"
        Me.B1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(325, 95)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(698, 134)
        Me.TextBox1.TabIndex = 2
        '
        'mony
        '
        Me.mony.AutoSize = True
        Me.mony.BackColor = System.Drawing.SystemColors.ControlDark
        Me.mony.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.mony.Location = New System.Drawing.Point(835, 28)
        Me.mony.Name = "mony"
        Me.mony.Size = New System.Drawing.Size(145, 48)
        Me.mony.TabIndex = 3
        Me.mony.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(868, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "money"
        '
        'happyy
        '
        Me.happyy.AutoSize = True
        Me.happyy.BackColor = System.Drawing.SystemColors.ControlDark
        Me.happyy.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.happyy.Location = New System.Drawing.Point(666, 28)
        Me.happyy.Name = "happyy"
        Me.happyy.Size = New System.Drawing.Size(145, 48)
        Me.happyy.TabIndex = 5
        Me.happyy.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(706, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "happiness"
        '
        'hung
        '
        Me.hung.AutoSize = True
        Me.hung.BackColor = System.Drawing.SystemColors.ControlDark
        Me.hung.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.hung.Location = New System.Drawing.Point(495, 28)
        Me.hung.Name = "hung"
        Me.hung.Size = New System.Drawing.Size(145, 48)
        Me.hung.TabIndex = 7
        Me.hung.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(531, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "hunger"
        '
        'cleany
        '
        Me.cleany.AutoSize = True
        Me.cleany.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cleany.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.cleany.Location = New System.Drawing.Point(317, 28)
        Me.cleany.Name = "cleany"
        Me.cleany.Size = New System.Drawing.Size(145, 48)
        Me.cleany.TabIndex = 9
        Me.cleany.Text = "Label1"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(349, 6)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(82, 17)
        Me.label.TabIndex = 10
        Me.label.Text = "cleanisness"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 88)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "feed " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-15 money" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+5 happiness" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 20 hunger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(39, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 81)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "clean tank" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-5 money" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+ 5 happiness" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+35 cleaniness"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(40, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(226, 81)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "play with fish " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-5 money" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+25 hapiness"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(42, 428)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(223, 78)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "upgrade your fish" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-30 money"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer5
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1032, 592)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.cleany)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hung)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.happyy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mony)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.ftank)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "fish simulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ftank As TextBox
    Friend WithEvents B1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents mony As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents happyy As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents hung As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cleany As Label
    Friend WithEvents label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer5 As Timer
End Class
