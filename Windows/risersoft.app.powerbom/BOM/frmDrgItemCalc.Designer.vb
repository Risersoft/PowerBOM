Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmDrgItemCalc
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textReference = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.CtlUpLoad1 = New risersoft.[shared].win.ctlUpLoad()
        Me.CtlUpLoad4 = New risersoft.[shared].win.ctlUpLoad()
        Me.CtlUpLoad3 = New risersoft.[shared].win.ctlUpLoad()
        Me.CtlUpLoad2 = New risersoft.[shared].win.ctlUpLoad()
        Me.CtlUpLoad5 = New risersoft.[shared].win.ctlUpLoad()
        Me.CtlUpLoad6 = New risersoft.[shared].win.ctlUpLoad()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.textReference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 370)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(649, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(361, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(457, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Location = New System.Drawing.Point(553, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.textReference)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 118)
        Me.Panel1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(40, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Reference"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textReference
        '
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.FontData.SizeInPoints = 9.0!
        Me.textReference.Appearance = Appearance4
        Me.textReference.AutoSize = False
        Me.textReference.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.textReference.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2003
        Me.textReference.Location = New System.Drawing.Point(144, 35)
        Me.textReference.Multiline = True
        Me.textReference.Name = "textReference"
        Me.textReference.ReadOnly = True
        Me.textReference.Size = New System.Drawing.Size(464, 48)
        Me.textReference.TabIndex = 3
        Me.textReference.Text = "UltraTextEditor3"
        '
        'CtlUpLoad1
        '
        Me.CtlUpLoad1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad1.Location = New System.Drawing.Point(0, 118)
        Me.CtlUpLoad1.Name = "CtlUpLoad1"
        Me.CtlUpLoad1.Size = New System.Drawing.Size(649, 40)
        Me.CtlUpLoad1.TabIndex = 4
        Me.CtlUpLoad1.Tag = "1"
        '
        'CtlUpLoad4
        '
        Me.CtlUpLoad4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad4.Location = New System.Drawing.Point(0, 238)
        Me.CtlUpLoad4.Name = "CtlUpLoad4"
        Me.CtlUpLoad4.Size = New System.Drawing.Size(649, 40)
        Me.CtlUpLoad4.TabIndex = 7
        Me.CtlUpLoad4.Tag = "4"
        '
        'CtlUpLoad3
        '
        Me.CtlUpLoad3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad3.Location = New System.Drawing.Point(0, 198)
        Me.CtlUpLoad3.Name = "CtlUpLoad3"
        Me.CtlUpLoad3.Size = New System.Drawing.Size(649, 40)
        Me.CtlUpLoad3.TabIndex = 6
        Me.CtlUpLoad3.Tag = "3"
        '
        'CtlUpLoad2
        '
        Me.CtlUpLoad2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad2.Location = New System.Drawing.Point(0, 158)
        Me.CtlUpLoad2.Name = "CtlUpLoad2"
        Me.CtlUpLoad2.Size = New System.Drawing.Size(649, 40)
        Me.CtlUpLoad2.TabIndex = 5
        Me.CtlUpLoad2.Tag = "2"
        '
        'CtlUpLoad5
        '
        Me.CtlUpLoad5.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad5.Location = New System.Drawing.Point(0, 278)
        Me.CtlUpLoad5.Name = "CtlUpLoad5"
        Me.CtlUpLoad5.Size = New System.Drawing.Size(649, 40)
        Me.CtlUpLoad5.TabIndex = 8
        Me.CtlUpLoad5.Tag = "5"
        '
        'CtlUpLoad6
        '
        Me.CtlUpLoad6.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad6.Location = New System.Drawing.Point(0, 318)
        Me.CtlUpLoad6.Name = "CtlUpLoad6"
        Me.CtlUpLoad6.Size = New System.Drawing.Size(649, 40)
        Me.CtlUpLoad6.TabIndex = 9
        Me.CtlUpLoad6.Tag = "6"
        '
        'frmDrgItemCalc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Drawing Item BOM"
        Me.ClientSize = New System.Drawing.Size(649, 418)
        Me.Controls.Add(Me.CtlUpLoad6)
        Me.Controls.Add(Me.CtlUpLoad5)
        Me.Controls.Add(Me.CtlUpLoad4)
        Me.Controls.Add(Me.CtlUpLoad3)
        Me.Controls.Add(Me.CtlUpLoad2)
        Me.Controls.Add(Me.CtlUpLoad1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmDrgItemCalc"
        Me.Text = "Drawing Item BOM"
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.textReference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents textReference As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents CtlUpLoad1 As ctlUpLoad
    Friend WithEvents CtlUpLoad4 As ctlUpLoad
    Friend WithEvents CtlUpLoad3 As ctlUpLoad
    Friend WithEvents CtlUpLoad2 As ctlUpLoad
    Friend WithEvents CtlUpLoad5 As risersoft.shared.win.ctlUpLoad
    Friend WithEvents CtlUpLoad6 As risersoft.shared.win.ctlUpLoad

#End Region
End Class

