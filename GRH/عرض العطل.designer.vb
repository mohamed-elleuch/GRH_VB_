<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class عرض_العطل
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(عرض_العطل))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.موظفينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.العطلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.السيرةالمهنيةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.نوعالعطلةDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.الترقيمالاداريDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.السنةDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.تاريخالانقطاععنالعملDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.تاريخالنهايةDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.تاريخالاستئنافDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.رقمالتسجيلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.فترةالتغيبDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.العطلةBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New GRH.DataSet2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sortir = New System.Windows.Forms.Button()
        Me.Lblcal = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.العطلةTableAdapter = New GRH.DataSet2TableAdapters.العطلةTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.العطلةBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 53)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Blue
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Century", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.موظفينToolStripMenuItem, Me.العطلToolStripMenuItem, Me.السيرةالمهنيةToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 56)
        Me.MenuStrip1.TabIndex = 67
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'موظفينToolStripMenuItem
        '
        Me.موظفينToolStripMenuItem.AutoSize = False
        Me.موظفينToolStripMenuItem.BackgroundImage = CType(resources.GetObject("موظفينToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.موظفينToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.موظفينToolStripMenuItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.موظفينToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.موظفينToolStripMenuItem.Image = CType(resources.GetObject("موظفينToolStripMenuItem.Image"), System.Drawing.Image)
        Me.موظفينToolStripMenuItem.Name = "موظفينToolStripMenuItem"
        Me.موظفينToolStripMenuItem.Size = New System.Drawing.Size(100, 50)
        Me.موظفينToolStripMenuItem.Text = "موظفين"
        '
        'العطلToolStripMenuItem
        '
        Me.العطلToolStripMenuItem.AutoSize = False
        Me.العطلToolStripMenuItem.BackgroundImage = CType(resources.GetObject("العطلToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.العطلToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.العطلToolStripMenuItem.CheckOnClick = True
        Me.العطلToolStripMenuItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.العطلToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.العطلToolStripMenuItem.Image = CType(resources.GetObject("العطلToolStripMenuItem.Image"), System.Drawing.Image)
        Me.العطلToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.العطلToolStripMenuItem.Name = "العطلToolStripMenuItem"
        Me.العطلToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.العطلToolStripMenuItem.Size = New System.Drawing.Size(100, 50)
        Me.العطلToolStripMenuItem.Text = "العطل"
        '
        'السيرةالمهنيةToolStripMenuItem
        '
        Me.السيرةالمهنيةToolStripMenuItem.AutoSize = False
        Me.السيرةالمهنيةToolStripMenuItem.BackgroundImage = CType(resources.GetObject("السيرةالمهنيةToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.السيرةالمهنيةToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.السيرةالمهنيةToolStripMenuItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.السيرةالمهنيةToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.السيرةالمهنيةToolStripMenuItem.Image = CType(resources.GetObject("السيرةالمهنيةToolStripMenuItem.Image"), System.Drawing.Image)
        Me.السيرةالمهنيةToolStripMenuItem.Name = "السيرةالمهنيةToolStripMenuItem"
        Me.السيرةالمهنيةToolStripMenuItem.Size = New System.Drawing.Size(150, 50)
        Me.السيرةالمهنيةToolStripMenuItem.Text = "السيرة المهنية"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.AutoSize = False
        Me.ToolStripMenuItem2.BackgroundImage = CType(resources.GetObject("ToolStripMenuItem2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(150, 50)
        Me.ToolStripMenuItem2.Text = "الساعات الإضافية"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("ToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(100, 50)
        Me.ToolStripMenuItem1.Text = "الإحصائيات"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 481)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 30)
        Me.Panel2.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.Blue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripProgressBar1, Me.ToolStripSplitButton2, Me.ToolStripProgressBar2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 2)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 28)
        Me.StatusStrip1.TabIndex = 127
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.AutoSize = False
        Me.ToolStripSplitButton1.BackgroundImage = CType(resources.GetObject("ToolStripSplitButton1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(50, 26)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.AutoSize = False
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.AutoSize = False
        Me.ToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(50, 26)
        Me.ToolStripSplitButton2.Text = "ToolStripSplitButton2"
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(200, 22)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 53)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.sortir)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Lblcal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 428)
        Me.SplitContainer1.SplitterDistance = 425
        Me.SplitContainer1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.نوعالعطلةDataGridViewTextBoxColumn, Me.الترقيمالاداريDataGridViewTextBoxColumn, Me.السنةDataGridViewTextBoxColumn, Me.تاريخالانقطاععنالعملDataGridViewTextBoxColumn, Me.تاريخالنهايةDataGridViewTextBoxColumn, Me.تاريخالاستئنافDataGridViewTextBoxColumn, Me.رقمالتسجيلDataGridViewTextBoxColumn, Me.فترةالتغيبDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.العطلةBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(406, 230)
        Me.DataGridView1.TabIndex = 0
        '
        'نوعالعطلةDataGridViewTextBoxColumn
        '
        Me.نوعالعطلةDataGridViewTextBoxColumn.DataPropertyName = "نوع العطلة"
        Me.نوعالعطلةDataGridViewTextBoxColumn.HeaderText = "نوع العطلة"
        Me.نوعالعطلةDataGridViewTextBoxColumn.Name = "نوعالعطلةDataGridViewTextBoxColumn"
        '
        'الترقيمالاداريDataGridViewTextBoxColumn
        '
        Me.الترقيمالاداريDataGridViewTextBoxColumn.DataPropertyName = "الترقيم الاداري"
        Me.الترقيمالاداريDataGridViewTextBoxColumn.HeaderText = "الترقيم الاداري"
        Me.الترقيمالاداريDataGridViewTextBoxColumn.Name = "الترقيمالاداريDataGridViewTextBoxColumn"
        '
        'السنةDataGridViewTextBoxColumn
        '
        Me.السنةDataGridViewTextBoxColumn.DataPropertyName = "السنة"
        Me.السنةDataGridViewTextBoxColumn.HeaderText = "السنة"
        Me.السنةDataGridViewTextBoxColumn.Name = "السنةDataGridViewTextBoxColumn"
        '
        'تاريخالانقطاععنالعملDataGridViewTextBoxColumn
        '
        Me.تاريخالانقطاععنالعملDataGridViewTextBoxColumn.DataPropertyName = "تاريخ الانقطاع عن العمل"
        Me.تاريخالانقطاععنالعملDataGridViewTextBoxColumn.HeaderText = "تاريخ الانقطاع عن العمل"
        Me.تاريخالانقطاععنالعملDataGridViewTextBoxColumn.Name = "تاريخالانقطاععنالعملDataGridViewTextBoxColumn"
        '
        'تاريخالنهايةDataGridViewTextBoxColumn
        '
        Me.تاريخالنهايةDataGridViewTextBoxColumn.DataPropertyName = "تاريخ النهاية"
        Me.تاريخالنهايةDataGridViewTextBoxColumn.HeaderText = "تاريخ النهاية"
        Me.تاريخالنهايةDataGridViewTextBoxColumn.Name = "تاريخالنهايةDataGridViewTextBoxColumn"
        '
        'تاريخالاستئنافDataGridViewTextBoxColumn
        '
        Me.تاريخالاستئنافDataGridViewTextBoxColumn.DataPropertyName = "تاريخ الاستئناف"
        Me.تاريخالاستئنافDataGridViewTextBoxColumn.HeaderText = "تاريخ الاستئناف"
        Me.تاريخالاستئنافDataGridViewTextBoxColumn.Name = "تاريخالاستئنافDataGridViewTextBoxColumn"
        '
        'رقمالتسجيلDataGridViewTextBoxColumn
        '
        Me.رقمالتسجيلDataGridViewTextBoxColumn.DataPropertyName = "رقم التسجيل"
        Me.رقمالتسجيلDataGridViewTextBoxColumn.HeaderText = "رقم التسجيل"
        Me.رقمالتسجيلDataGridViewTextBoxColumn.Name = "رقمالتسجيلDataGridViewTextBoxColumn"
        '
        'فترةالتغيبDataGridViewTextBoxColumn
        '
        Me.فترةالتغيبDataGridViewTextBoxColumn.DataPropertyName = "فترة التغيب"
        Me.فترةالتغيبDataGridViewTextBoxColumn.HeaderText = "فترة التغيب"
        Me.فترةالتغيبDataGridViewTextBoxColumn.Name = "فترةالتغيبDataGridViewTextBoxColumn"
        '
        'العطلةBindingSource
        '
        Me.العطلةBindingSource.DataMember = "العطلة"
        Me.العطلةBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(437, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = ": حسب المصلحة"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(437, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = ": الترقيم الإداري"
        '
        'sortir
        '
        Me.sortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.sortir.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortir.Location = New System.Drawing.Point(284, 337)
        Me.sortir.Name = "sortir"
        Me.sortir.Size = New System.Drawing.Size(94, 36)
        Me.sortir.TabIndex = 39
        Me.sortir.Text = "خروج"
        Me.sortir.UseVisualStyleBackColor = True
        '
        'Lblcal
        '
        Me.Lblcal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblcal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lblcal.Location = New System.Drawing.Point(49, 398)
        Me.Lblcal.Name = "Lblcal"
        Me.Lblcal.Size = New System.Drawing.Size(230, 23)
        Me.Lblcal.TabIndex = 38
        Me.Lblcal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"عطلة سنوية", "عطلة مرضية", "عطلة الأمومة", "عطلة إستثنائية", "ترخيص بالخروج"})
        Me.ComboBox1.Location = New System.Drawing.Point(294, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(294, 68)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 22)
        Me.TextBox2.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'العطلةTableAdapter
        '
        Me.العطلةTableAdapter.ClearBeforeFill = True
        '
        'عرض_العطل
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 511)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "عرض_العطل"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "عرض_العطل"
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.العطلةBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents sortir As System.Windows.Forms.Button
    Friend WithEvents Lblcal As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripProgressBar2 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents موظفينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents العطلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents السيرةالمهنيةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet2 As GRH.DataSet2
    Friend WithEvents العطلةBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents العطلةTableAdapter As GRH.DataSet2TableAdapters.العطلةTableAdapter
    Friend WithEvents نوعالعطلةDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents الترقيمالاداريDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents السنةDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاريخالانقطاععنالعملDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاريخالنهايةDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاريخالاستئنافDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents رقمالتسجيلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فترةالتغيبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
