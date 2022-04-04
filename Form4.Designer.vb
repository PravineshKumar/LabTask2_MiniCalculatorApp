<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtsum = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(295, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MINI CALCULATOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(348, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ANSWER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnum2)
        Me.GroupBox1.Controls.Add(Me.txtnum1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("STXihei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(165, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 134)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Number "
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(183, 82)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(150, 32)
        Me.txtnum2.TabIndex = 3
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(183, 31)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(150, 32)
        Me.txtnum1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("STXihei", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(48, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Number 2 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("STXihei", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(48, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Number 1 :"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightYellow
        Me.btnAdd.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(165, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 34)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.LightYellow
        Me.btnSub.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSub.Location = New System.Drawing.Point(295, 277)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(88, 34)
        Me.btnSub.TabIndex = 4
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'btnMult
        '
        Me.btnMult.BackColor = System.Drawing.Color.LightYellow
        Me.btnMult.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMult.Location = New System.Drawing.Point(420, 277)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(88, 34)
        Me.btnMult.TabIndex = 5
        Me.btnMult.Text = "x "
        Me.btnMult.UseVisualStyleBackColor = False
        '
        'btnDiv
        '
        Me.btnDiv.BackColor = System.Drawing.Color.LightYellow
        Me.btnDiv.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDiv.Location = New System.Drawing.Point(544, 277)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(88, 34)
        Me.btnDiv.TabIndex = 6
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(165, 487)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 34)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(520, 487)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 34)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtsum
        '
        Me.txtsum.Location = New System.Drawing.Point(165, 393)
        Me.txtsum.Name = "txtsum"
        Me.txtsum.Size = New System.Drawing.Size(467, 31)
        Me.txtsum.TabIndex = 10
        Me.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(811, 545)
        Me.Controls.Add(Me.txtsum)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtsum As TextBox
End Class
