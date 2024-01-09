<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sale
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sale))
        Me.dgvsale = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSTOMER_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DATECREATEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jar_Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOTAL_ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total_Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnedit = New System.Windows.Forms.DataGridViewButtonColumn
        Me.btndel = New System.Windows.Forms.DataGridViewButtonColumn
        Me.TblsaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New AquaDrops.DataSet2
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btncn = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TblsaleTableAdapter = New AquaDrops.DataSet2TableAdapters.tblsaleTableAdapter
        Me.DataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvsale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvsale
        '
        Me.dgvsale.AllowUserToAddRows = False
        Me.dgvsale.AllowUserToDeleteRows = False
        Me.dgvsale.AllowUserToOrderColumns = True
        Me.dgvsale.AutoGenerateColumns = False
        Me.dgvsale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvsale.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvsale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.dgvsale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsale.ColumnHeadersHeight = 50
        Me.dgvsale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CUSTOMER_NAME, Me.DATECREATEDDataGridViewTextBoxColumn, Me.TYPEDataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn, Me.Jar_Type, Me.TOTAL_ITEM, Me.Price, Me.Total_Amount, Me.btnedit, Me.btndel})
        Me.dgvsale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvsale.DataSource = Me.TblsaleBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsale.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvsale.GridColor = System.Drawing.Color.White
        Me.dgvsale.Location = New System.Drawing.Point(27, 171)
        Me.dgvsale.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvsale.MultiSelect = False
        Me.dgvsale.Name = "dgvsale"
        Me.dgvsale.ReadOnly = True
        Me.dgvsale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsale.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvsale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsale.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvsale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsale.Size = New System.Drawing.Size(1156, 481)
        Me.dgvsale.TabIndex = 19
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'CUSTOMER_NAME
        '
        Me.CUSTOMER_NAME.DataPropertyName = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.HeaderText = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.Name = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.ReadOnly = True
        Me.CUSTOMER_NAME.Width = 158
        '
        'DATECREATEDDataGridViewTextBoxColumn
        '
        Me.DATECREATEDDataGridViewTextBoxColumn.DataPropertyName = "DATECREATED"
        Me.DATECREATEDDataGridViewTextBoxColumn.FillWeight = 45.59615!
        Me.DATECREATEDDataGridViewTextBoxColumn.HeaderText = "DATECREATED"
        Me.DATECREATEDDataGridViewTextBoxColumn.Name = "DATECREATEDDataGridViewTextBoxColumn"
        Me.DATECREATEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DATECREATEDDataGridViewTextBoxColumn.Width = 71
        '
        'TYPEDataGridViewTextBoxColumn
        '
        Me.TYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn.FillWeight = 45.59615!
        Me.TYPEDataGridViewTextBoxColumn.HeaderText = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn.Name = "TYPEDataGridViewTextBoxColumn"
        Me.TYPEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TYPEDataGridViewTextBoxColumn.Width = 72
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.FillWeight = 45.59615!
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        Me.STATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.STATUSDataGridViewTextBoxColumn.Width = 72
        '
        'Jar_Type
        '
        Me.Jar_Type.DataPropertyName = "Jar_Type"
        Me.Jar_Type.HeaderText = "Jar_Type"
        Me.Jar_Type.Name = "Jar_Type"
        Me.Jar_Type.ReadOnly = True
        Me.Jar_Type.Width = 157
        '
        'TOTAL_ITEM
        '
        Me.TOTAL_ITEM.DataPropertyName = "TOTAL_ITEM"
        Me.TOTAL_ITEM.HeaderText = "TOTAL_ITEM"
        Me.TOTAL_ITEM.Name = "TOTAL_ITEM"
        Me.TOTAL_ITEM.ReadOnly = True
        Me.TOTAL_ITEM.Width = 158
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 157
        '
        'Total_Amount
        '
        Me.Total_Amount.DataPropertyName = "Total_Amount"
        Me.Total_Amount.HeaderText = "Total_Amount"
        Me.Total_Amount.Name = "Total_Amount"
        Me.Total_Amount.ReadOnly = True
        Me.Total_Amount.Width = 50
        '
        'btnedit
        '
        Me.btnedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.btnedit.DefaultCellStyle = DataGridViewCellStyle2
        Me.btnedit.FillWeight = 204.1618!
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnedit.HeaderText = "ACTION"
        Me.btnedit.Name = "btnedit"
        Me.btnedit.ReadOnly = True
        Me.btnedit.Text = "EDIT"
        Me.btnedit.ToolTipText = "Edit selected row"
        Me.btnedit.UseColumnTextForButtonValue = True
        Me.btnedit.Width = 62
        '
        'btndel
        '
        Me.btndel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.btndel.DefaultCellStyle = DataGridViewCellStyle3
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndel.HeaderText = "ACTION"
        Me.btndel.Name = "btndel"
        Me.btndel.ReadOnly = True
        Me.btndel.Text = "DELETE"
        Me.btndel.UseColumnTextForButtonValue = True
        Me.btndel.Width = 62
        '
        'TblsaleBindingSource
        '
        Me.TblsaleBindingSource.DataMember = "tblsale"
        Me.TblsaleBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btncn)
        Me.Panel1.Controls.Add(Me.dgvsale)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1198, 678)
        Me.Panel1.TabIndex = 20
        '
        'btncn
        '
        Me.btncn.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncn.BackgroundImage = CType(resources.GetObject("btncn.BackgroundImage"), System.Drawing.Image)
        Me.btncn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btncn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncn.FlatAppearance.BorderSize = 2
        Me.btncn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncn.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncn.ForeColor = System.Drawing.Color.White
        Me.btncn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncn.Location = New System.Drawing.Point(993, 98)
        Me.btncn.Name = "btncn"
        Me.btncn.Size = New System.Drawing.Size(190, 65)
        Me.btncn.TabIndex = 20
        Me.btncn.Text = "Create New"
        Me.btncn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncn.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(6, 77)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1177, 12)
        Me.Panel5.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1151, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 39)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(109, 124)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 30)
        Me.TextBox1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(6, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(60, 53)
        Me.Panel2.TabIndex = 0
        '
        'TblsaleTableAdapter
        '
        Me.TblsaleTableAdapter.ClearBeforeFill = True
        '
        'DataSet2BindingSource
        '
        Me.DataSet2BindingSource.DataSource = Me.DataSet2
        Me.DataSet2BindingSource.Position = 0
        '
        'Sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 678)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvsale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet2 As AquaDrops.DataSet2
    Friend WithEvents TblsaleTableAdapter As AquaDrops.DataSet2TableAdapters.tblsaleTableAdapter
    Friend WithEvents dgvsale As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblsaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALITEMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btncn As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATECREATEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jar_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnedit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btndel As System.Windows.Forms.DataGridViewButtonColumn
End Class
