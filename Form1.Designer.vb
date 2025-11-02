<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form
    Private txtDesc As System.Windows.Forms.TextBox
    Private txtTpi As System.Windows.Forms.TextBox
    Private txtStarts As System.Windows.Forms.TextBox
    Private txtAngle As System.Windows.Forms.TextBox
    Private txtHighPD As System.Windows.Forms.TextBox
    Private txtLowPD As System.Windows.Forms.TextBox
    Private txtWire As System.Windows.Forms.TextBox
    Private lblMaxResult As System.Windows.Forms.Label
    Private lblMinResult As System.Windows.Forms.Label
    Private btnCalculate As System.Windows.Forms.Button
    Private btnPrint As System.Windows.Forms.Button
    Private LabelDescription As System.Windows.Forms.Label
    Private LabelTpi As System.Windows.Forms.Label
    Private LabelStarts As System.Windows.Forms.Label
    Private LabelAngle As System.Windows.Forms.Label
    Private LabelHighPD As System.Windows.Forms.Label
    Private LabelLowPD As System.Windows.Forms.Label
    Private LabelWire As System.Windows.Forms.Label
    Private LabelBest As System.Windows.Forms.Label
    Private LabelMax As System.Windows.Forms.Label
    Private LabelMin As System.Windows.Forms.Label
    Private PrintDocument1 As System.Drawing.Printing.PrintDocument
    Private PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Private ToolTip1 As System.Windows.Forms.ToolTip


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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtTpi = New System.Windows.Forms.TextBox()
        Me.txtStarts = New System.Windows.Forms.TextBox()
        Me.txtAngle = New System.Windows.Forms.TextBox()
        Me.txtHighPD = New System.Windows.Forms.TextBox()
        Me.txtLowPD = New System.Windows.Forms.TextBox()
        Me.txtWire = New System.Windows.Forms.TextBox()
        Me.lblMaxResult = New System.Windows.Forms.Label()
        Me.lblMinResult = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelTpi = New System.Windows.Forms.Label()
        Me.LabelStarts = New System.Windows.Forms.Label()
        Me.LabelAngle = New System.Windows.Forms.Label()
        Me.LabelHighPD = New System.Windows.Forms.Label()
        Me.LabelLowPD = New System.Windows.Forms.Label()
        Me.LabelWire = New System.Windows.Forms.Label()
        Me.LabelBest = New System.Windows.Forms.Label()
        Me.LabelMax = New System.Windows.Forms.Label()
        Me.LabelMin = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtBest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(391, 28)
        Me.txtDesc.MaxLength = 200
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(160, 34)
        Me.txtDesc.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtDesc, "Enter the description of the thread (e.g. 1 3/8-16 UN-2A). Used for printing.")
        '
        'txtTpi
        '
        Me.txtTpi.Location = New System.Drawing.Point(391, 68)
        Me.txtTpi.MaxLength = 6
        Me.txtTpi.Name = "txtTpi"
        Me.txtTpi.Size = New System.Drawing.Size(120, 34)
        Me.txtTpi.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtTpi, "Enter the number that designates the number of threads per inch (TPI).")
        '
        'txtStarts
        '
        Me.txtStarts.Location = New System.Drawing.Point(391, 108)
        Me.txtStarts.MaxLength = 3
        Me.txtStarts.Name = "txtStarts"
        Me.txtStarts.Size = New System.Drawing.Size(120, 34)
        Me.txtStarts.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtStarts, "Most threads have only one start. For multi-start threads enter number of starts." &
        "")
        '
        'txtAngle
        '
        Me.txtAngle.Location = New System.Drawing.Point(391, 148)
        Me.txtAngle.MaxLength = 3
        Me.txtAngle.Name = "txtAngle"
        Me.txtAngle.Size = New System.Drawing.Size(120, 34)
        Me.txtAngle.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtAngle, "Included angle: 60° (American), 55° (Whitworth), 29° (Acme).")
        '
        'txtHighPD
        '
        Me.txtHighPD.Location = New System.Drawing.Point(391, 188)
        Me.txtHighPD.MaxLength = 20
        Me.txtHighPD.Name = "txtHighPD"
        Me.txtHighPD.Size = New System.Drawing.Size(160, 34)
        Me.txtHighPD.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtHighPD, "The maximum pitch diameter must be known to determine the Over-Wire measurement.")
        '
        'txtLowPD
        '
        Me.txtLowPD.Location = New System.Drawing.Point(391, 228)
        Me.txtLowPD.MaxLength = 20
        Me.txtLowPD.Name = "txtLowPD"
        Me.txtLowPD.Size = New System.Drawing.Size(160, 34)
        Me.txtLowPD.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtLowPD, "The minimum pitch diameter must be known to determine the Over-Wire measurement.")
        '
        'txtWire
        '
        Me.txtWire.Location = New System.Drawing.Point(391, 268)
        Me.txtWire.MaxLength = 20
        Me.txtWire.Name = "txtWire"
        Me.txtWire.Size = New System.Drawing.Size(160, 34)
        Me.txtWire.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtWire, "Wire used to measure the thread. Leave blank to use best wire calculated.")
        '
        'lblMaxResult
        '
        Me.lblMaxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxResult.Location = New System.Drawing.Point(391, 364)
        Me.lblMaxResult.Name = "lblMaxResult"
        Me.lblMaxResult.Size = New System.Drawing.Size(160, 33)
        Me.lblMaxResult.TabIndex = 8
        '
        'lblMinResult
        '
        Me.lblMinResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMinResult.Location = New System.Drawing.Point(391, 404)
        Me.lblMinResult.Name = "lblMinResult"
        Me.lblMinResult.Size = New System.Drawing.Size(160, 33)
        Me.lblMinResult.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(40, 466)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(160, 46)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate OWD"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(214, 466)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(160, 46)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Location = New System.Drawing.Point(17, 28)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(334, 28)
        Me.LabelDescription.TabIndex = 20
        Me.LabelDescription.Text = "Enter the general thread description :"
        Me.ToolTip1.SetToolTip(Me.LabelDescription, "Enter the description of the thread (e.g. 1 3/8-16 UN-2A). Used for printing.")
        '
        'LabelTpi
        '
        Me.LabelTpi.AutoSize = True
        Me.LabelTpi.Location = New System.Drawing.Point(149, 68)
        Me.LabelTpi.Name = "LabelTpi"
        Me.LabelTpi.Size = New System.Drawing.Size(202, 28)
        Me.LabelTpi.TabIndex = 21
        Me.LabelTpi.Text = "Threads per inch (TPI):"
        Me.ToolTip1.SetToolTip(Me.LabelTpi, "Enter the number that designates the number of threads per inch (TPI).")
        '
        'LabelStarts
        '
        Me.LabelStarts.AutoSize = True
        Me.LabelStarts.Location = New System.Drawing.Point(126, 108)
        Me.LabelStarts.Name = "LabelStarts"
        Me.LabelStarts.Size = New System.Drawing.Size(225, 28)
        Me.LabelStarts.TabIndex = 22
        Me.LabelStarts.Text = "Number of thread starts:"
        Me.ToolTip1.SetToolTip(Me.LabelStarts, "Most threads have only one start. For multi-start threads enter number of starts." &
        "")
        '
        'LabelAngle
        '
        Me.LabelAngle.AutoSize = True
        Me.LabelAngle.Location = New System.Drawing.Point(71, 148)
        Me.LabelAngle.Name = "LabelAngle"
        Me.LabelAngle.Size = New System.Drawing.Size(280, 28)
        Me.LabelAngle.TabIndex = 23
        Me.LabelAngle.Text = "Included angle of thread (deg):"
        Me.ToolTip1.SetToolTip(Me.LabelAngle, "Included angle: 60° (American), 55° (Whitworth), 29° (Acme).")
        '
        'LabelHighPD
        '
        Me.LabelHighPD.AutoSize = True
        Me.LabelHighPD.Location = New System.Drawing.Point(119, 188)
        Me.LabelHighPD.Name = "LabelHighPD"
        Me.LabelHighPD.Size = New System.Drawing.Size(232, 28)
        Me.LabelHighPD.TabIndex = 24
        Me.LabelHighPD.Text = "High pitch diameter (PD):"
        Me.ToolTip1.SetToolTip(Me.LabelHighPD, "The maximum pitch diameter must be known to determine the Over-Wire measurement.")
        '
        'LabelLowPD
        '
        Me.LabelLowPD.AutoSize = True
        Me.LabelLowPD.Location = New System.Drawing.Point(126, 228)
        Me.LabelLowPD.Name = "LabelLowPD"
        Me.LabelLowPD.Size = New System.Drawing.Size(225, 28)
        Me.LabelLowPD.TabIndex = 25
        Me.LabelLowPD.Text = "Low pitch diameter (PD):"
        Me.ToolTip1.SetToolTip(Me.LabelLowPD, "The minimum pitch diameter must be known to determine the Over-Wire measurement.")
        '
        'LabelWire
        '
        Me.LabelWire.AutoSize = True
        Me.LabelWire.Location = New System.Drawing.Point(14, 268)
        Me.LabelWire.Name = "LabelWire"
        Me.LabelWire.Size = New System.Drawing.Size(337, 28)
        Me.LabelWire.TabIndex = 26
        Me.LabelWire.Text = "Wire size used to measure the thread:"
        Me.ToolTip1.SetToolTip(Me.LabelWire, "Wire used to measure the thread. Leave blank to use best wire calculated.")
        '
        'LabelBest
        '
        Me.LabelBest.AutoSize = True
        Me.LabelBest.Location = New System.Drawing.Point(38, 324)
        Me.LabelBest.Name = "LabelBest"
        Me.LabelBest.Size = New System.Drawing.Size(313, 28)
        Me.LabelBest.TabIndex = 27
        Me.LabelBest.Text = "The best wire size for this thread is:"
        '
        'LabelMax
        '
        Me.LabelMax.AutoSize = True
        Me.LabelMax.Location = New System.Drawing.Point(37, 364)
        Me.LabelMax.Name = "LabelMax"
        Me.LabelMax.Size = New System.Drawing.Size(314, 28)
        Me.LabelMax.TabIndex = 28
        Me.LabelMax.Text = "The max over wire measurement is:"
        '
        'LabelMin
        '
        Me.LabelMin.AutoSize = True
        Me.LabelMin.Location = New System.Drawing.Point(40, 404)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(311, 28)
        Me.LabelMin.TabIndex = 29
        Me.LabelMin.Text = "The min over wire measurement is:"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.UseAntiAlias = True
        Me.PrintPreviewDialog1.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        '
        'txtBest
        '
        Me.txtBest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBest.Location = New System.Drawing.Point(391, 323)
        Me.txtBest.Name = "txtBest"
        Me.txtBest.Size = New System.Drawing.Size(160, 33)
        Me.txtBest.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 560)
        Me.Controls.Add(Me.LabelMin)
        Me.Controls.Add(Me.LabelMax)
        Me.Controls.Add(Me.LabelBest)
        Me.Controls.Add(Me.LabelWire)
        Me.Controls.Add(Me.LabelLowPD)
        Me.Controls.Add(Me.LabelHighPD)
        Me.Controls.Add(Me.LabelAngle)
        Me.Controls.Add(Me.LabelStarts)
        Me.Controls.Add(Me.LabelTpi)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMinResult)
        Me.Controls.Add(Me.txtBest)
        Me.Controls.Add(Me.lblMaxResult)
        Me.Controls.Add(Me.txtWire)
        Me.Controls.Add(Me.txtLowPD)
        Me.Controls.Add(Me.txtHighPD)
        Me.Controls.Add(Me.txtAngle)
        Me.Controls.Add(Me.txtStarts)
        Me.Controls.Add(Me.txtTpi)
        Me.Controls.Add(Me.txtDesc)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Over Wire Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtBest As Label
End Class
