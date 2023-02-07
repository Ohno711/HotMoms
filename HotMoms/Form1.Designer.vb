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
        Me.lsbList = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picTeach = New System.Windows.Forms.PictureBox()
        CType(Me.picTeach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsbList
        '
        Me.lsbList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbList.FormattingEnabled = True
        Me.lsbList.ItemHeight = 25
        Me.lsbList.Items.AddRange(New Object() {"Number 1", "Number 2", "Number 3", "Number 4", "Number 5"})
        Me.lsbList.Location = New System.Drawing.Point(118, 27)
        Me.lsbList.Name = "lsbList"
        Me.lsbList.Size = New System.Drawing.Size(104, 129)
        Me.lsbList.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(12, 159)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Top 5 Teachers at Metro"
        '
        'picTeach
        '
        Me.picTeach.Location = New System.Drawing.Point(12, 27)
        Me.picTeach.Name = "picTeach"
        Me.picTeach.Size = New System.Drawing.Size(100, 129)
        Me.picTeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeach.TabIndex = 1
        Me.picTeach.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 194)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picTeach)
        Me.Controls.Add(Me.lsbList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picTeach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsbList As ListBox
    Friend WithEvents picTeach As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
End Class
