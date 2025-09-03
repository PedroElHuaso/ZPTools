<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Panel3 = New Panel()
        lstEvents = New ListBox()
        Panel2 = New Panel()
        SplitContainer1 = New SplitContainer()
        Label1 = New Label()
        clbEvents = New CheckedListBox()
        Label2 = New Label()
        btnBrowse = New Button()
        txtPath = New TextBox()
        txtProcessName = New TextBox()
        Label3 = New Label()
        txtFilter = New TextBox()
        btnStart = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1179, 803)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lstEvents)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 165)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1179, 638)
        Panel3.TabIndex = 11
        ' 
        ' lstEvents
        ' 
        lstEvents.Dock = DockStyle.Fill
        lstEvents.FormattingEnabled = True
        lstEvents.Location = New Point(0, 0)
        lstEvents.Name = "lstEvents"
        lstEvents.Size = New Size(1179, 638)
        lstEvents.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(SplitContainer1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1179, 165)
        Panel2.TabIndex = 10
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Top
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(clbEvents)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(btnBrowse)
        SplitContainer1.Panel1.Controls.Add(txtPath)
        SplitContainer1.Panel1.Controls.Add(txtProcessName)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(txtFilter)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(btnStart)
        SplitContainer1.Size = New Size(1179, 157)
        SplitContainer1.SplitterDistance = 1003
        SplitContainer1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(18, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 5
        Label1.Text = "percorso"
        ' 
        ' clbEvents
        ' 
        clbEvents.BackColor = SystemColors.Info
        clbEvents.FormattingEnabled = True
        clbEvents.Location = New Point(653, 9)
        clbEvents.Name = "clbEvents"
        clbEvents.Size = New Size(161, 136)
        clbEvents.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(18, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 6
        Label2.Text = "filtro files"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.RosyBrown
        btnBrowse.Font = New Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(480, 12)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(152, 46)
        btnBrowse.TabIndex = 7
        btnBrowse.Text = "Cartella"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(91, 31)
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(372, 27)
        txtPath.TabIndex = 0
        ' 
        ' txtProcessName
        ' 
        txtProcessName.Location = New Point(91, 117)
        txtProcessName.Name = "txtProcessName"
        txtProcessName.Size = New Size(372, 27)
        txtProcessName.TabIndex = 8
        txtProcessName.Text = "solo il nome senza .exe (viene aggiunto dopo)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(13, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 20)
        Label3.TabIndex = 9
        Label3.Text = "processo"
        ' 
        ' txtFilter
        ' 
        txtFilter.Location = New Point(91, 73)
        txtFilter.Name = "txtFilter"
        txtFilter.Size = New Size(372, 27)
        txtFilter.TabIndex = 1
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.RosyBrown
        btnStart.Dock = DockStyle.Fill
        btnStart.Location = New Point(0, 0)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(172, 157)
        btnStart.TabIndex = 3
        btnStart.Text = "Avvio/Ferma"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        ClientSize = New Size(1179, 803)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CercaMenu"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstEvents As ListBox
    Friend WithEvents btnStart As Button
    Friend WithEvents clbEvents As CheckedListBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProcessName As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer

End Class
