<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class acctstate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acctstate))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btfind = New System.Windows.Forms.Button()
        Me.Txttoacct = New System.Windows.Forms.TextBox()
        Me.bffind = New System.Windows.Forms.Button()
        Me.Txtfrmacct = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbSrc = New System.Windows.Forms.RadioButton()
        Me.Rbfunc = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Rbwocl = New System.Windows.Forms.RadioButton()
        Me.Rbwcl = New System.Windows.Forms.RadioButton()
        Me.Bprint = New System.Windows.Forms.Button()
        Me.CMDClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btfind)
        Me.GroupBox1.Controls.Add(Me.Txttoacct)
        Me.GroupBox1.Controls.Add(Me.bffind)
        Me.GroupBox1.Controls.Add(Me.Txtfrmacct)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(314, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Number"
        '
        'btfind
        '
        Me.btfind.BackColor = System.Drawing.SystemColors.Control
        Me.btfind.Cursor = System.Windows.Forms.Cursors.Default
        Me.btfind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btfind.Image = CType(resources.GetObject("btfind.Image"), System.Drawing.Image)
        Me.btfind.Location = New System.Drawing.Point(274, 62)
        Me.btfind.Name = "btfind"
        Me.btfind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btfind.Size = New System.Drawing.Size(17, 20)
        Me.btfind.TabIndex = 29
        Me.btfind.TabStop = False
        Me.btfind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btfind.UseVisualStyleBackColor = False
        '
        'Txttoacct
        '
        Me.Txttoacct.Location = New System.Drawing.Point(83, 62)
        Me.Txttoacct.Margin = New System.Windows.Forms.Padding(4)
        Me.Txttoacct.Multiline = True
        Me.Txttoacct.Name = "Txttoacct"
        Me.Txttoacct.Size = New System.Drawing.Size(196, 20)
        Me.Txttoacct.TabIndex = 3
        '
        'bffind
        '
        Me.bffind.BackColor = System.Drawing.SystemColors.Control
        Me.bffind.Cursor = System.Windows.Forms.Cursors.Default
        Me.bffind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bffind.Image = CType(resources.GetObject("bffind.Image"), System.Drawing.Image)
        Me.bffind.Location = New System.Drawing.Point(274, 25)
        Me.bffind.Name = "bffind"
        Me.bffind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bffind.Size = New System.Drawing.Size(17, 20)
        Me.bffind.TabIndex = 27
        Me.bffind.TabStop = False
        Me.bffind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bffind.UseVisualStyleBackColor = False
        '
        'Txtfrmacct
        '
        Me.Txtfrmacct.Location = New System.Drawing.Point(83, 26)
        Me.Txtfrmacct.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtfrmacct.Multiline = True
        Me.Txtfrmacct.Name = "Txtfrmacct"
        Me.Txtfrmacct.Size = New System.Drawing.Size(196, 20)
        Me.Txtfrmacct.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 126)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(317, 89)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(82, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker2.TabIndex = 31
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(82, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbSrc)
        Me.GroupBox3.Controls.Add(Me.Rbfunc)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 227)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(317, 68)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Currency"
        '
        'RbSrc
        '
        Me.RbSrc.AutoSize = True
        Me.RbSrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSrc.Location = New System.Drawing.Point(185, 26)
        Me.RbSrc.Name = "RbSrc"
        Me.RbSrc.Size = New System.Drawing.Size(65, 17)
        Me.RbSrc.TabIndex = 1
        Me.RbSrc.TabStop = True
        Me.RbSrc.Text = "Source"
        Me.RbSrc.UseVisualStyleBackColor = True
        '
        'Rbfunc
        '
        Me.Rbfunc.AutoSize = True
        Me.Rbfunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbfunc.Location = New System.Drawing.Point(11, 26)
        Me.Rbfunc.Name = "Rbfunc"
        Me.Rbfunc.Size = New System.Drawing.Size(84, 17)
        Me.Rbfunc.TabIndex = 0
        Me.Rbfunc.TabStop = True
        Me.Rbfunc.Text = "Functional"
        Me.Rbfunc.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Rbwocl)
        Me.GroupBox4.Controls.Add(Me.Rbwcl)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 316)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(319, 59)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Closing Option"
        '
        'Rbwocl
        '
        Me.Rbwocl.AutoSize = True
        Me.Rbwocl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbwocl.Location = New System.Drawing.Point(173, 25)
        Me.Rbwocl.Name = "Rbwocl"
        Me.Rbwocl.Size = New System.Drawing.Size(137, 17)
        Me.Rbwocl.TabIndex = 2
        Me.Rbwocl.TabStop = True
        Me.Rbwocl.Text = "Without Closing Per"
        Me.Rbwocl.UseVisualStyleBackColor = True
        '
        'Rbwcl
        '
        Me.Rbwcl.AutoSize = True
        Me.Rbwcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbwcl.Location = New System.Drawing.Point(13, 25)
        Me.Rbwcl.Name = "Rbwcl"
        Me.Rbwcl.Size = New System.Drawing.Size(123, 17)
        Me.Rbwcl.TabIndex = 2
        Me.Rbwcl.TabStop = True
        Me.Rbwcl.Text = "With Closing  Per"
        Me.Rbwcl.UseVisualStyleBackColor = True
        '
        'Bprint
        '
        Me.Bprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bprint.Location = New System.Drawing.Point(25, 399)
        Me.Bprint.Margin = New System.Windows.Forms.Padding(4)
        Me.Bprint.Name = "Bprint"
        Me.Bprint.Size = New System.Drawing.Size(111, 32)
        Me.Bprint.TabIndex = 4
        Me.Bprint.Text = "Print"
        Me.Bprint.UseVisualStyleBackColor = True
        '
        'CMDClose
        '
        Me.CMDClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDClose.Location = New System.Drawing.Point(200, 398)
        Me.CMDClose.Margin = New System.Windows.Forms.Padding(4)
        Me.CMDClose.Name = "CMDClose"
        Me.CMDClose.Size = New System.Drawing.Size(109, 32)
        Me.CMDClose.TabIndex = 5
        Me.CMDClose.Text = "Exit"
        Me.CMDClose.UseVisualStyleBackColor = True
        '
        'acctstate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 434)
        Me.Controls.Add(Me.CMDClose)
        Me.Controls.Add(Me.Bprint)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "acctstate"
        Me.Text = "Account Statement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txttoacct As TextBox
    Friend WithEvents Txtfrmacct As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Bprint As Button
    Friend WithEvents CMDClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RbSrc As RadioButton
    Friend WithEvents Rbfunc As RadioButton
    Friend WithEvents Rbwocl As RadioButton
    Friend WithEvents Rbwcl As RadioButton
    Public WithEvents btfind As Button
    Public WithEvents bffind As Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
