<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbed = New System.Windows.Forms.TextBox()
        Me.RoomDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.My_Hotel_projectDataSet = New Hotel_Project.My_Hotel_projectDataSet()
        Me.txthalf = New System.Windows.Forms.TextBox()
        Me.txtfull = New System.Windows.Forms.TextBox()
        Me.txtroomNo = New System.Windows.Forms.TextBox()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.cmblocation = New System.Windows.Forms.ComboBox()
        Me.cmbroomtype = New System.Windows.Forms.ComboBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtroomtype = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceFullboardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceHalfboardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceBedAndBreakfastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbsearchby = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Room_DetailsTableAdapter = New Hotel_Project.My_Hotel_projectDataSetTableAdapters.Room_DetailsTableAdapter()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RoomDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.My_Hotel_projectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room Details"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(6, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 166)
        Me.Panel1.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(306, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Search"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(353, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(96, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(458, 21)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(550, 21)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "View All"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'closebtn
        '
        Me.closebtn.Location = New System.Drawing.Point(593, 513)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(75, 23)
        Me.closebtn.TabIndex = 8
        Me.closebtn.Text = "close"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(148, 21)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox7.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(72, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Search By:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(692, 247)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Room Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(273, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Room Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtbed)
        Me.GroupBox1.Controls.Add(Me.txthalf)
        Me.GroupBox1.Controls.Add(Me.txtfull)
        Me.GroupBox1.Controls.Add(Me.txtroomNo)
        Me.GroupBox1.Controls.Add(Me.cmbstatus)
        Me.GroupBox1.Controls.Add(Me.cmblocation)
        Me.GroupBox1.Controls.Add(Me.cmbroomtype)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtroomtype)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 146)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Details"
        '
        'txtbed
        '
        Me.txtbed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomDetailsBindingSource, "Price(Bed and Breakfast)", True))
        Me.txtbed.Location = New System.Drawing.Point(458, 98)
        Me.txtbed.Name = "txtbed"
        Me.txtbed.Size = New System.Drawing.Size(119, 20)
        Me.txtbed.TabIndex = 17
        '
        'RoomDetailsBindingSource
        '
        Me.RoomDetailsBindingSource.DataMember = "Room_Details"
        Me.RoomDetailsBindingSource.DataSource = Me.My_Hotel_projectDataSet
        '
        'My_Hotel_projectDataSet
        '
        Me.My_Hotel_projectDataSet.DataSetName = "My_Hotel_projectDataSet"
        Me.My_Hotel_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txthalf
        '
        Me.txthalf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomDetailsBindingSource, "Price(Halfboard)", True))
        Me.txthalf.Location = New System.Drawing.Point(458, 56)
        Me.txthalf.Name = "txthalf"
        Me.txthalf.Size = New System.Drawing.Size(119, 20)
        Me.txthalf.TabIndex = 16
        '
        'txtfull
        '
        Me.txtfull.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomDetailsBindingSource, "Price(Fullboard)", True))
        Me.txtfull.Location = New System.Drawing.Point(458, 13)
        Me.txtfull.Name = "txtfull"
        Me.txtfull.Size = New System.Drawing.Size(119, 20)
        Me.txtfull.TabIndex = 15
        '
        'txtroomNo
        '
        Me.txtroomNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomDetailsBindingSource, "Room_No", True))
        Me.txtroomNo.Location = New System.Drawing.Point(91, 20)
        Me.txtroomNo.Name = "txtroomNo"
        Me.txtroomNo.Size = New System.Drawing.Size(119, 20)
        Me.txtroomNo.TabIndex = 14
        '
        'cmbstatus
        '
        Me.cmbstatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomDetailsBindingSource, "Status", True))
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Location = New System.Drawing.Point(91, 101)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbstatus.TabIndex = 13
        '
        'cmblocation
        '
        Me.cmblocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomDetailsBindingSource, "Location", True))
        Me.cmblocation.FormattingEnabled = True
        Me.cmblocation.Location = New System.Drawing.Point(91, 73)
        Me.cmblocation.Name = "cmblocation"
        Me.cmblocation.Size = New System.Drawing.Size(121, 21)
        Me.cmblocation.TabIndex = 12
        '
        'cmbroomtype
        '
        Me.cmbroomtype.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomDetailsBindingSource, "Room_Type", True))
        Me.cmbroomtype.FormattingEnabled = True
        Me.cmbroomtype.Location = New System.Drawing.Point(91, 45)
        Me.cmbroomtype.Name = "cmbroomtype"
        Me.cmbroomtype.Size = New System.Drawing.Size(121, 21)
        Me.cmbroomtype.TabIndex = 11
        '
        'btnadd
        '
        Me.btnadd.BackgroundImage = CType(resources.GetObject("btnadd.BackgroundImage"), System.Drawing.Image)
        Me.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnadd.Location = New System.Drawing.Point(131, 231)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "Add new"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price(Bed and Breakfast)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Price(HalfBoard)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price(FullBoard)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Location"
        '
        'txtroomtype
        '
        Me.txtroomtype.AutoSize = True
        Me.txtroomtype.Location = New System.Drawing.Point(23, 48)
        Me.txtroomtype.Name = "txtroomtype"
        Me.txtroomtype.Size = New System.Drawing.Size(62, 13)
        Me.txtroomtype.TabIndex = 1
        Me.txtroomtype.Text = "Room Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Room No."
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.cmbsearchby)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.TextBox10)
        Me.GroupBox4.Controls.Add(Me.Button12)
        Me.GroupBox4.Controls.Add(Me.Button13)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 260)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(692, 247)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Room Details"
        '
        'DataGridView1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNoDataGridViewTextBoxColumn, Me.RoomTypeDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.PriceFullboardDataGridViewTextBoxColumn, Me.PriceHalfboardDataGridViewTextBoxColumn, Me.PriceBedAndBreakfastDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RoomDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(21, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(623, 181)
        Me.DataGridView1.TabIndex = 26
        '
        'RoomNoDataGridViewTextBoxColumn
        '
        Me.RoomNoDataGridViewTextBoxColumn.DataPropertyName = "Room_No"
        Me.RoomNoDataGridViewTextBoxColumn.HeaderText = "Room_No"
        Me.RoomNoDataGridViewTextBoxColumn.Name = "RoomNoDataGridViewTextBoxColumn"
        '
        'RoomTypeDataGridViewTextBoxColumn
        '
        Me.RoomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room_Type"
        Me.RoomTypeDataGridViewTextBoxColumn.HeaderText = "Room_Type"
        Me.RoomTypeDataGridViewTextBoxColumn.Name = "RoomTypeDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'PriceFullboardDataGridViewTextBoxColumn
        '
        Me.PriceFullboardDataGridViewTextBoxColumn.DataPropertyName = "Price(Fullboard)"
        Me.PriceFullboardDataGridViewTextBoxColumn.HeaderText = "Price(Fullboard)"
        Me.PriceFullboardDataGridViewTextBoxColumn.Name = "PriceFullboardDataGridViewTextBoxColumn"
        '
        'PriceHalfboardDataGridViewTextBoxColumn
        '
        Me.PriceHalfboardDataGridViewTextBoxColumn.DataPropertyName = "Price(Halfboard)"
        Me.PriceHalfboardDataGridViewTextBoxColumn.HeaderText = "Price(Halfboard)"
        Me.PriceHalfboardDataGridViewTextBoxColumn.Name = "PriceHalfboardDataGridViewTextBoxColumn"
        '
        'PriceBedAndBreakfastDataGridViewTextBoxColumn
        '
        Me.PriceBedAndBreakfastDataGridViewTextBoxColumn.DataPropertyName = "Price(Bed and Breakfast)"
        Me.PriceBedAndBreakfastDataGridViewTextBoxColumn.HeaderText = "Price(Bed and Breakfast)"
        Me.PriceBedAndBreakfastDataGridViewTextBoxColumn.Name = "PriceBedAndBreakfastDataGridViewTextBoxColumn"
        '
        'cmbsearchby
        '
        Me.cmbsearchby.FormattingEnabled = True
        Me.cmbsearchby.Location = New System.Drawing.Point(148, 21)
        Me.cmbsearchby.Name = "cmbsearchby"
        Me.cmbsearchby.Size = New System.Drawing.Size(121, 21)
        Me.cmbsearchby.TabIndex = 25
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(306, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Search"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(72, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Search By:"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(353, 23)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(96, 20)
        Me.TextBox10.TabIndex = 5
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(458, 21)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 6
        Me.Button12.Text = "Search"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(550, 21)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 7
        Me.Button13.Text = "View All"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Room_DetailsTableAdapter
        '
        Me.Room_DetailsTableAdapter.ClearBeforeFill = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(493, 513)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelbtn.TabIndex = 27
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(239, 231)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Update"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(372, 231)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Delete"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(493, 231)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Clear"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(725, 553)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Name = "Form3"
        Me.Text = "Room Details"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RoomDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.My_Hotel_projectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbed As System.Windows.Forms.TextBox
    Friend WithEvents txthalf As System.Windows.Forms.TextBox
    Friend WithEvents txtfull As System.Windows.Forms.TextBox
    Friend WithEvents txtroomNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmblocation As System.Windows.Forms.ComboBox
    Friend WithEvents cmbroomtype As System.Windows.Forms.ComboBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtroomtype As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbsearchby As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents My_Hotel_projectDataSet As Hotel_Project.My_Hotel_projectDataSet
    Friend WithEvents RoomDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Room_DetailsTableAdapter As Hotel_Project.My_Hotel_projectDataSetTableAdapters.Room_DetailsTableAdapter
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceFullboardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceHalfboardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceBedAndBreakfastDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cancelbtn As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
