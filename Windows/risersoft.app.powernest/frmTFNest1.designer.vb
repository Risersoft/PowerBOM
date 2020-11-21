Imports Infragistics.Win.UltraWinGrid
Imports risersoft.shared.win

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFNest1
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        myView.SetGrid(Me.UltraGrid1)
        Me.initForm()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_SheetQty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_SheetLength = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_SheetWidth = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dt_RevDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_RevNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_SheetQty2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_SheetLength2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_SheetWidth2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_SheetQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SheetLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SheetWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_RevDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RevNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SheetQty2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SheetLength2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SheetWidth2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraGrid1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(860, 525)
        Me.Panel2.TabIndex = 16
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(599, 525)
        Me.UltraGrid1.TabIndex = 150
        Me.UltraGrid1.Text = "Delivery Schedule"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_SheetQty2)
        Me.Panel1.Controls.Add(Me.txt_SheetLength2)
        Me.Panel1.Controls.Add(Me.txt_SheetWidth2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_SheetQty)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_SheetLength)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_SheetWidth)
        Me.Panel1.Controls.Add(Me.dt_RevDate)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txt_RevNum)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_Remark)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(599, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 525)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(193, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Qty"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_SheetQty
        '
        Me.txt_SheetQty.Location = New System.Drawing.Point(196, 75)
        Me.txt_SheetQty.Name = "txt_SheetQty"
        Me.txt_SheetQty.Size = New System.Drawing.Size(32, 21)
        Me.txt_SheetQty.TabIndex = 174
        Me.txt_SheetQty.Text = "UltraTextEditor1"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(122, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "Length"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_SheetLength
        '
        Me.txt_SheetLength.Location = New System.Drawing.Point(125, 75)
        Me.txt_SheetLength.Name = "txt_SheetLength"
        Me.txt_SheetLength.Size = New System.Drawing.Size(65, 21)
        Me.txt_SheetLength.TabIndex = 172
        Me.txt_SheetLength.Text = "UltraTextEditor1"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(49, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "Width"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_SheetWidth
        '
        Me.txt_SheetWidth.Location = New System.Drawing.Point(49, 75)
        Me.txt_SheetWidth.Name = "txt_SheetWidth"
        Me.txt_SheetWidth.Size = New System.Drawing.Size(67, 21)
        Me.txt_SheetWidth.TabIndex = 170
        Me.txt_SheetWidth.Text = "UltraTextEditor1"
        '
        'dt_RevDate
        '
        Me.dt_RevDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_RevDate.Location = New System.Drawing.Point(99, 243)
        Me.dt_RevDate.Name = "dt_RevDate"
        Me.dt_RevDate.NullText = "Not Defined"
        Me.dt_RevDate.Size = New System.Drawing.Size(156, 21)
        Me.dt_RevDate.TabIndex = 169
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(15, 246)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 16)
        Me.Label20.TabIndex = 168
        Me.Label20.Text = "Revision Date"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_RevNum
        '
        Me.txt_RevNum.Location = New System.Drawing.Point(99, 216)
        Me.txt_RevNum.Name = "txt_RevNum"
        Me.txt_RevNum.Size = New System.Drawing.Size(156, 21)
        Me.txt_RevNum.TabIndex = 167
        Me.txt_RevNum.Text = "UltraTextEditor8"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(19, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 166
        Me.Label10.Text = "Revision No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Remarks"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(15, 296)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(240, 80)
        Me.txt_Remark.TabIndex = 160
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(15, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(15, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 16)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_SheetQty2
        '
        Me.txt_SheetQty2.Location = New System.Drawing.Point(196, 102)
        Me.txt_SheetQty2.Name = "txt_SheetQty2"
        Me.txt_SheetQty2.Size = New System.Drawing.Size(32, 21)
        Me.txt_SheetQty2.TabIndex = 179
        Me.txt_SheetQty2.Text = "UltraTextEditor1"
        '
        'txt_SheetLength2
        '
        Me.txt_SheetLength2.Location = New System.Drawing.Point(125, 102)
        Me.txt_SheetLength2.Name = "txt_SheetLength2"
        Me.txt_SheetLength2.Size = New System.Drawing.Size(65, 21)
        Me.txt_SheetLength2.TabIndex = 178
        Me.txt_SheetLength2.Text = "UltraTextEditor1"
        '
        'txt_SheetWidth2
        '
        Me.txt_SheetWidth2.Location = New System.Drawing.Point(49, 102)
        Me.txt_SheetWidth2.Name = "txt_SheetWidth2"
        Me.txt_SheetWidth2.Size = New System.Drawing.Size(67, 21)
        Me.txt_SheetWidth2.TabIndex = 177
        Me.txt_SheetWidth2.Text = "UltraTextEditor1"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(34, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "Sheet Sizes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmTFNest1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Standard Drawing Reference"
        Me.ClientSize = New System.Drawing.Size(860, 525)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmTFNest1"
        Me.Text = "Standard Drawing Reference"
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_SheetQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SheetLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SheetWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_RevDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RevNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SheetQty2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SheetLength2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SheetWidth2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_RevDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_RevNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_SheetQty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_SheetLength As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_SheetWidth As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_SheetQty2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SheetLength2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SheetWidth2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label

#End Region
End Class

