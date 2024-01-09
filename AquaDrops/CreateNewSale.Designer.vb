<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateNewSale))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcn = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbtype = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TbljartypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AquaDrops.DataSet1
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnadd = New System.Windows.Forms.Button
        Me.lbldt = New System.Windows.Forms.Label
        Me.lblstatus = New System.Windows.Forms.Label
        Me.cbstatus = New System.Windows.Forms.ComboBox
        Me.TbljartypeTableAdapter = New AquaDrops.DataSet1TableAdapters.tbljartypeTableAdapter
        Me.btncancel = New System.Windows.Forms.Button
        Me.cbjartype = New System.Windows.Forms.ComboBox
        Me.txtqty = New System.Windows.Forms.NumericUpDown
        Me.btnupdate = New System.Windows.Forms.Button
        Me.txtid = New System.Windows.Forms.Label
        Me.txthash = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.TbljartypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-8, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 86)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create New Sale"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(20, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(70, 68)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name:"
        '
        'txtcn
        '
        Me.txtcn.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcn.Location = New System.Drawing.Point(43, 154)
        Me.txtcn.Name = "txtcn"
        Me.txtcn.Size = New System.Drawing.Size(384, 30)
        Me.txtcn.TabIndex = 3
        Me.txtcn.Text = "Guest"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type:"
        '
        'cbtype
        '
        Me.cbtype.AllowDrop = True
        Me.cbtype.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Items.AddRange(New Object() {"Walk-in", "For Delivery"})
        Me.cbtype.Location = New System.Drawing.Point(43, 389)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(384, 32)
        Me.cbtype.TabIndex = 4
        Me.cbtype.Text = "Walk-in"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jar Type:"
        '
        'TbljartypeBindingSource
        '
        Me.TbljartypeBindingSource.DataMember = "tbljartype"
        Me.TbljartypeBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Quantity:"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.SpringGreen
        Me.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnadd.FlatAppearance.BorderSize = 2
        Me.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(297, 546)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(130, 42)
        Me.btnadd.TabIndex = 11
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lbldt
        '
        Me.lbldt.AutoSize = True
        Me.lbldt.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.Location = New System.Drawing.Point(275, 101)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(75, 19)
        Me.lbldt.TabIndex = 13
        Me.lbldt.Text = "00-00-00"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(39, 451)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(78, 24)
        Me.lblstatus.TabIndex = 2
        Me.lblstatus.Text = "Status:"
        '
        'cbstatus
        '
        Me.cbstatus.BackColor = System.Drawing.Color.White
        Me.cbstatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbstatus.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Items.AddRange(New Object() {"Unpaid", "Paid"})
        Me.cbstatus.Location = New System.Drawing.Point(43, 478)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(384, 32)
        Me.cbstatus.TabIndex = 4
        Me.cbstatus.Text = "Unpaid"
        '
        'TbljartypeTableAdapter
        '
        Me.TbljartypeTableAdapter.ClearBeforeFill = True
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Tomato
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btncancel.FlatAppearance.BorderSize = 2
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(191, 546)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(96, 42)
        Me.btncancel.TabIndex = 29
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'cbjartype
        '
        Me.cbjartype.BackColor = System.Drawing.Color.White
        Me.cbjartype.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbjartype.DataSource = Me.TbljartypeBindingSource
        Me.cbjartype.DisplayMember = "NAME"
        Me.cbjartype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjartype.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjartype.FormattingEnabled = True
        Me.cbjartype.Location = New System.Drawing.Point(43, 228)
        Me.cbjartype.Name = "cbjartype"
        Me.cbjartype.Size = New System.Drawing.Size(384, 32)
        Me.cbjartype.TabIndex = 30
        Me.cbjartype.ValueMember = "NAME"
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(43, 307)
        Me.txtqty.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtqty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(384, 30)
        Me.txtqty.TabIndex = 31
        Me.txtqty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnupdate.FlatAppearance.BorderSize = 2
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(43, 546)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(142, 42)
        Me.btnupdate.TabIndex = 32
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.AutoSize = True
        Me.txtid.Location = New System.Drawing.Point(16, 93)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(19, 13)
        Me.txtid.TabIndex = 33
        Me.txtid.Text = "00"
        '
        'txthash
        '
        Me.txthash.AutoSize = True
        Me.txthash.Location = New System.Drawing.Point(6, 93)
        Me.txthash.Name = "txthash"
        Me.txthash.Size = New System.Drawing.Size(14, 13)
        Me.txthash.TabIndex = 34
        Me.txthash.Text = "#"
        '
        'CreateNewSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(444, 605)
        Me.ControlBox = False
        Me.Controls.Add(Me.txthash)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.cbjartype)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.lbldt)
        Me.Controls.Add(Me.cbstatus)
        Me.Controls.Add(Me.cbtype)
        Me.Controls.Add(Me.txtcn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateNewSale"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TbljartypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lbldt As System.Windows.Forms.Label
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents cbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As AquaDrops.DataSet1
    Friend WithEvents TbljartypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbljartypeTableAdapter As AquaDrops.DataSet1TableAdapters.tbljartypeTableAdapter
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents cbjartype As System.Windows.Forms.ComboBox
    Friend WithEvents txtqty As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.Label
    Friend WithEvents txthash As System.Windows.Forms.Label
End Class
