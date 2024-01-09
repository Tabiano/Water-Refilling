<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesreport
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salesreport))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbtype = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtpend = New System.Windows.Forms.DateTimePicker
        Me.dtpstart = New System.Windows.Forms.DateTimePicker
        Me.dgvsale = New System.Windows.Forms.DataGridView
        Me.DATECREATEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSTOMER_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jar_Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total_Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblsaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New AquaDrops.DataSet2
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TblsaleTableAdapter = New AquaDrops.DataSet2TableAdapters.tblsaleTableAdapter
        Me.DataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.dgvsale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.cbtype)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.dtpend)
        Me.Panel1.Controls.Add(Me.dtpstart)
        Me.Panel1.Controls.Add(Me.dgvsale)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1197, 663)
        Me.Panel1.TabIndex = 21
        '
        'cbtype
        '
        Me.cbtype.AllowDrop = True
        Me.cbtype.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Items.AddRange(New Object() {"All", "Walk-in", "For Delivery"})
        Me.cbtype.Location = New System.Drawing.Point(27, 119)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(103, 28)
        Me.cbtype.TabIndex = 23
        Me.cbtype.Text = "Type"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(415, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 30)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpend
        '
        Me.dtpend.CustomFormat = "yyyy-MM-dd"
        Me.dtpend.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpend.Location = New System.Drawing.Point(278, 121)
        Me.dtpend.Name = "dtpend"
        Me.dtpend.Size = New System.Drawing.Size(98, 26)
        Me.dtpend.TabIndex = 21
        '
        'dtpstart
        '
        Me.dtpstart.CustomFormat = "yyyy-MM-dd"
        Me.dtpstart.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpstart.Location = New System.Drawing.Point(151, 121)
        Me.dtpstart.Name = "dtpstart"
        Me.dtpstart.Size = New System.Drawing.Size(99, 26)
        Me.dtpstart.TabIndex = 20
        Me.dtpstart.Value = New Date(2023, 11, 20, 16, 54, 16, 0)
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
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvsale.ColumnHeadersHeight = 50
        Me.dgvsale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DATECREATEDDataGridViewTextBoxColumn, Me.CUSTOMER_NAME, Me.TYPEDataGridViewTextBoxColumn, Me.Jar_Type, Me.QTY, Me.Price, Me.Total_Amount})
        Me.dgvsale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvsale.DataSource = Me.TblsaleBindingSource
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsale.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvsale.GridColor = System.Drawing.Color.White
        Me.dgvsale.Location = New System.Drawing.Point(27, 171)
        Me.dgvsale.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvsale.MultiSelect = False
        Me.dgvsale.Name = "dgvsale"
        Me.dgvsale.ReadOnly = True
        Me.dgvsale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsale.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvsale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsale.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvsale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsale.Size = New System.Drawing.Size(1156, 481)
        Me.dgvsale.TabIndex = 19
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
        'CUSTOMER_NAME
        '
        Me.CUSTOMER_NAME.DataPropertyName = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.HeaderText = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.Name = "CUSTOMER_NAME"
        Me.CUSTOMER_NAME.ReadOnly = True
        Me.CUSTOMER_NAME.Width = 158
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
        'Jar_Type
        '
        Me.Jar_Type.DataPropertyName = "Jar_Type"
        Me.Jar_Type.HeaderText = "Jar_Type"
        Me.Jar_Type.Name = "Jar_Type"
        Me.Jar_Type.ReadOnly = True
        Me.Jar_Type.Width = 157
        '
        'QTY
        '
        Me.QTY.DataPropertyName = "QTY"
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.ReadOnly = True
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
        Me.Total_Amount.Width = 90
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
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(6, 77)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1176, 12)
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales Report"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(6, 8)
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1007, 117)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 30)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'salesreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 663)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "salesreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "salesreport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvsale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvsale As System.Windows.Forms.DataGridView
    Friend WithEvents TblsaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As AquaDrops.DataSet2
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TblsaleTableAdapter As AquaDrops.DataSet2TableAdapters.tblsaleTableAdapter
    Friend WithEvents DataSet2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpend As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpstart As System.Windows.Forms.DateTimePicker
    Friend WithEvents DATECREATEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jar_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
