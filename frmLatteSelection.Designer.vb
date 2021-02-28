<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLatteSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLatteSelection))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblLatteSelection = New System.Windows.Forms.Label()
        Me.picPumpkin = New System.Windows.Forms.PictureBox()
        Me.picMocha = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 65)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pumpkin Spice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblLatteSelection
        '
        Me.lblLatteSelection.AutoSize = True
        Me.lblLatteSelection.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLatteSelection.Location = New System.Drawing.Point(286, 28)
        Me.lblLatteSelection.Name = "lblLatteSelection"
        Me.lblLatteSelection.Size = New System.Drawing.Size(142, 25)
        Me.lblLatteSelection.TabIndex = 1
        Me.lblLatteSelection.Text = "LatteSelection"
        '
        'picPumpkin
        '
        Me.picPumpkin.Image = CType(resources.GetObject("picPumpkin.Image"), System.Drawing.Image)
        Me.picPumpkin.Location = New System.Drawing.Point(15, 112)
        Me.picPumpkin.Name = "picPumpkin"
        Me.picPumpkin.Size = New System.Drawing.Size(300, 250)
        Me.picPumpkin.TabIndex = 2
        Me.picPumpkin.TabStop = False
        Me.picPumpkin.Visible = False
        '
        'picMocha
        '
        Me.picMocha.Image = CType(resources.GetObject("picMocha.Image"), System.Drawing.Image)
        Me.picMocha.Location = New System.Drawing.Point(402, 112)
        Me.picMocha.Name = "picMocha"
        Me.picMocha.Size = New System.Drawing.Size(300, 250)
        Me.picMocha.TabIndex = 3
        Me.picMocha.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(78, 560)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 65)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Mocha"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmLatteSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 661)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.picMocha)
        Me.Controls.Add(Me.picPumpkin)
        Me.Controls.Add(Me.lblLatteSelection)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmLatteSelection"
        Me.Text = "frmLatteSelection"
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblLatteSelection As Label
    Friend WithEvents picPumpkin As PictureBox
    Friend WithEvents picMocha As PictureBox
    Friend WithEvents Button2 As Button
End Class
