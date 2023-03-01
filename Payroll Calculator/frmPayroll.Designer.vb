<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayroll))
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.btnTaxCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblFicaHead = New System.Windows.Forms.Label()
        Me.lblFederalHead = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblPayback = New System.Windows.Forms.Label()
        Me.lblStateHead = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblFederal = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.Image = CType(resources.GetObject("picPayroll.Image"), System.Drawing.Image)
        Me.picPayroll.Location = New System.Drawing.Point(0, 0)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(384, 231)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTaxCalc.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTaxCalc.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTaxCalc.Location = New System.Drawing.Point(133, 301)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(127, 33)
        Me.btnTaxCalc.TabIndex = 1
        Me.btnTaxCalc.Text = "Compute Taxes"
        Me.btnTaxCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(327, 301)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(127, 33)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(521, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.Location = New System.Drawing.Point(414, 25)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(323, 38)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "Payroll Calculator"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDesc.Location = New System.Drawing.Point(478, 108)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(179, 64)
        Me.lblDesc.TabIndex = 5
        Me.lblDesc.Text = "Paycheck" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(239, 258)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(204, 28)
        Me.lblPrompt.TabIndex = 6
        Me.lblPrompt.Text = "Enter Gross Pay:"
        '
        'lblFicaHead
        '
        Me.lblFicaHead.AutoSize = True
        Me.lblFicaHead.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFicaHead.Location = New System.Drawing.Point(133, 351)
        Me.lblFicaHead.Name = "lblFicaHead"
        Me.lblFicaHead.Size = New System.Drawing.Size(49, 18)
        Me.lblFicaHead.TabIndex = 7
        Me.lblFicaHead.Text = "FICA:"
        '
        'lblFederalHead
        '
        Me.lblFederalHead.AutoSize = True
        Me.lblFederalHead.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFederalHead.Location = New System.Drawing.Point(300, 351)
        Me.lblFederalHead.Name = "lblFederalHead"
        Me.lblFederalHead.Size = New System.Drawing.Size(101, 18)
        Me.lblFederalHead.TabIndex = 8
        Me.lblFederalHead.Text = "Federal Tax:"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNet.Location = New System.Drawing.Point(478, 390)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(62, 21)
        Me.lblNet.TabIndex = 9
        Me.lblNet.Text = "$X.XX"
        '
        'lblPayback
        '
        Me.lblPayback.AutoSize = True
        Me.lblPayback.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPayback.Location = New System.Drawing.Point(179, 389)
        Me.lblPayback.Name = "lblPayback"
        Me.lblPayback.Size = New System.Drawing.Size(205, 22)
        Me.lblPayback.TabIndex = 10
        Me.lblPayback.Text = "Net Payback Income:"
        '
        'lblStateHead
        '
        Me.lblStateHead.AutoSize = True
        Me.lblStateHead.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStateHead.Location = New System.Drawing.Point(521, 351)
        Me.lblStateHead.Name = "lblStateHead"
        Me.lblStateHead.Size = New System.Drawing.Size(84, 18)
        Me.lblStateHead.TabIndex = 11
        Me.lblStateHead.Text = "State Tax:"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(478, 258)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(98, 27)
        Me.txtIncome.TabIndex = 0
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFica.Location = New System.Drawing.Point(188, 351)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(53, 18)
        Me.lblFica.TabIndex = 13
        Me.lblFica.Text = "$X.XX"
        '
        'lblFederal
        '
        Me.lblFederal.AutoSize = True
        Me.lblFederal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFederal.Location = New System.Drawing.Point(407, 351)
        Me.lblFederal.Name = "lblFederal"
        Me.lblFederal.Size = New System.Drawing.Size(53, 18)
        Me.lblFederal.TabIndex = 14
        Me.lblFederal.Text = "$X.XX"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblState.Location = New System.Drawing.Point(611, 351)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(53, 18)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "$X.XX"
        '
        'frmPayroll
        '
        Me.AcceptButton = Me.btnTaxCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(780, 450)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFederal)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.lblStateHead)
        Me.Controls.Add(Me.lblPayback)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblFederalHead)
        Me.Controls.Add(Me.lblFicaHead)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxCalc)
        Me.Controls.Add(Me.picPayroll)
        Me.Name = "frmPayroll"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents btnTaxCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblFicaHead As Label
    Friend WithEvents lblFederalHead As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblPayback As Label
    Friend WithEvents lblStateHead As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblState As Label
End Class
