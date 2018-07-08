<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statistique
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
        Me.GestionRHDataSet = New GRH.GestionRHDataSet()
        Me.العطلةBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.العطلةTableAdapter = New GRH.GestionRHDataSetTableAdapters.العطلةTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GestionRHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.العطلةBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GestionRHDataSet
        '
        Me.GestionRHDataSet.DataSetName = "GestionRHDataSet"
        Me.GestionRHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'العطلةBindingSource
        '
        Me.العطلةBindingSource.DataMember = "العطلة"
        Me.العطلةBindingSource.DataSource = Me.GestionRHDataSet
        '
        'العطلةTableAdapter
        '
        Me.العطلةTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STATISTIQUE DE CONGES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Entrer année de congé pour afficher statistique de tous les employés "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(408, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(296, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(722, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Afficher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'statistique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(877, 574)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "statistique"
        Me.Text = "statistique"
        CType(Me.GestionRHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.العطلةBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents العطلةBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GestionRHDataSet As GRH.GestionRHDataSet
    Friend WithEvents العطلةTableAdapter As GRH.GestionRHDataSetTableAdapters.العطلةTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
