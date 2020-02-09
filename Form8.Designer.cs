namespace 商品库存管理系统
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.商品编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售价格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进货价格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品描述DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品类别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仓库编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品库存管理DataSet1 = new 商品库存管理系统.商品库存管理DataSet1();
            this.商品TableAdapter = new 商品库存管理系统.商品库存管理DataSet1TableAdapters.商品TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.volume = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.tomb = new System.Windows.Forms.TextBox();
            this.sort = new System.Windows.Forms.TextBox();
            this.describe = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.normal = new System.Windows.Forms.ComboBox();
            this.upper = new System.Windows.Forms.Button();
            this.cell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.randomme = new System.Windows.Forms.CheckBox();
            this.randomsupply = new System.Windows.Forms.ComboBox();
            this.randomupper = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品编号DataGridViewTextBoxColumn,
            this.商品名称DataGridViewTextBoxColumn,
            this.库存量DataGridViewTextBoxColumn,
            this.销售价格DataGridViewTextBoxColumn,
            this.进货价格DataGridViewTextBoxColumn,
            this.商品描述DataGridViewTextBoxColumn,
            this.商品类别DataGridViewTextBoxColumn,
            this.仓库编号DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 商品编号DataGridViewTextBoxColumn
            // 
            this.商品编号DataGridViewTextBoxColumn.DataPropertyName = "商品编号";
            this.商品编号DataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.商品编号DataGridViewTextBoxColumn.Name = "商品编号DataGridViewTextBoxColumn";
            // 
            // 商品名称DataGridViewTextBoxColumn
            // 
            this.商品名称DataGridViewTextBoxColumn.DataPropertyName = "商品名称";
            this.商品名称DataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.商品名称DataGridViewTextBoxColumn.Name = "商品名称DataGridViewTextBoxColumn";
            // 
            // 库存量DataGridViewTextBoxColumn
            // 
            this.库存量DataGridViewTextBoxColumn.DataPropertyName = "库存量";
            this.库存量DataGridViewTextBoxColumn.HeaderText = "库存量";
            this.库存量DataGridViewTextBoxColumn.Name = "库存量DataGridViewTextBoxColumn";
            // 
            // 销售价格DataGridViewTextBoxColumn
            // 
            this.销售价格DataGridViewTextBoxColumn.DataPropertyName = "销售价格";
            this.销售价格DataGridViewTextBoxColumn.HeaderText = "销售价格";
            this.销售价格DataGridViewTextBoxColumn.Name = "销售价格DataGridViewTextBoxColumn";
            // 
            // 进货价格DataGridViewTextBoxColumn
            // 
            this.进货价格DataGridViewTextBoxColumn.DataPropertyName = "进货价格";
            this.进货价格DataGridViewTextBoxColumn.HeaderText = "进货价格";
            this.进货价格DataGridViewTextBoxColumn.Name = "进货价格DataGridViewTextBoxColumn";
            // 
            // 商品描述DataGridViewTextBoxColumn
            // 
            this.商品描述DataGridViewTextBoxColumn.DataPropertyName = "商品描述";
            this.商品描述DataGridViewTextBoxColumn.HeaderText = "商品描述";
            this.商品描述DataGridViewTextBoxColumn.Name = "商品描述DataGridViewTextBoxColumn";
            // 
            // 商品类别DataGridViewTextBoxColumn
            // 
            this.商品类别DataGridViewTextBoxColumn.DataPropertyName = "商品类别";
            this.商品类别DataGridViewTextBoxColumn.HeaderText = "商品类别";
            this.商品类别DataGridViewTextBoxColumn.Name = "商品类别DataGridViewTextBoxColumn";
            // 
            // 仓库编号DataGridViewTextBoxColumn
            // 
            this.仓库编号DataGridViewTextBoxColumn.DataPropertyName = "仓库编号";
            this.仓库编号DataGridViewTextBoxColumn.HeaderText = "仓库编号";
            this.仓库编号DataGridViewTextBoxColumn.Name = "仓库编号DataGridViewTextBoxColumn";
            // 
            // 商品BindingSource
            // 
            this.商品BindingSource.DataMember = "商品";
            this.商品BindingSource.DataSource = this.商品库存管理DataSet1;
            // 
            // 商品库存管理DataSet1
            // 
            this.商品库存管理DataSet1.DataSetName = "商品库存管理DataSet1";
            this.商品库存管理DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品TableAdapter
            // 
            this.商品TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1081, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1081, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "售出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.number.Location = new System.Drawing.Point(146, 20);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(114, 30);
            this.number.TabIndex = 4;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(266, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(108, 30);
            this.name.TabIndex = 5;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // value
            // 
            this.value.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.value.Location = new System.Drawing.Point(613, 20);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(115, 30);
            this.value.TabIndex = 6;
            this.value.TextChanged += new System.EventHandler(this.value_TextChanged);
            // 
            // volume
            // 
            this.volume.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.volume.Location = new System.Drawing.Point(380, 20);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(111, 30);
            this.volume.TabIndex = 7;
            this.volume.TextChanged += new System.EventHandler(this.volume_TextChanged);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.price.Location = new System.Drawing.Point(497, 20);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(110, 30);
            this.price.TabIndex = 8;
            this.price.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tomb
            // 
            this.tomb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tomb.Location = new System.Drawing.Point(975, 20);
            this.tomb.Name = "tomb";
            this.tomb.Size = new System.Drawing.Size(100, 30);
            this.tomb.TabIndex = 9;
            this.tomb.TextChanged += new System.EventHandler(this.tomb_TextChanged);
            // 
            // sort
            // 
            this.sort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sort.Location = new System.Drawing.Point(859, 20);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(110, 30);
            this.sort.TabIndex = 10;
            this.sort.TextChanged += new System.EventHandler(this.sort_TextChanged);
            // 
            // describe
            // 
            this.describe.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.describe.Location = new System.Drawing.Point(734, 20);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(119, 30);
            this.describe.TabIndex = 11;
            this.describe.TextChanged += new System.EventHandler(this.describe_TextChanged);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(29, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "高级操作";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(29, 72);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 24);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "普通操作";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // normal
            // 
            this.normal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.normal.FormattingEnabled = true;
            this.normal.Items.AddRange(new object[] {
            "商品编号",
            "商品名称",
            "库存量",
            "销售价格",
            "进货价格",
            "商品描述",
            "商品类别",
            "仓库编号"});
            this.normal.Location = new System.Drawing.Point(146, 68);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(264, 28);
            this.normal.TabIndex = 17;
            this.normal.SelectedIndexChanged += new System.EventHandler(this.normal_SelectedIndexChanged);
            // 
            // upper
            // 
            this.upper.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.upper.Location = new System.Drawing.Point(613, 63);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(196, 40);
            this.upper.TabIndex = 18;
            this.upper.Text = "注入高级操作框";
            this.upper.UseVisualStyleBackColor = true;
            this.upper.Click += new System.EventHandler(this.upper_Click);
            // 
            // cell
            // 
            this.cell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell.Location = new System.Drawing.Point(416, 68);
            this.cell.Name = "cell";
            this.cell.Size = new System.Drawing.Size(191, 30);
            this.cell.TabIndex = 19;
            this.cell.TextChanged += new System.EventHandler(this.cell_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(815, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "售出需要商品编号";
            // 
            // randomme
            // 
            this.randomme.AutoSize = true;
            this.randomme.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.randomme.Location = new System.Drawing.Point(29, 120);
            this.randomme.Name = "randomme";
            this.randomme.Size = new System.Drawing.Size(111, 24);
            this.randomme.TabIndex = 21;
            this.randomme.Text = "模糊查找";
            this.randomme.UseVisualStyleBackColor = true;
            this.randomme.CheckedChanged += new System.EventHandler(this.random_CheckedChanged);
            // 
            // randomsupply
            // 
            this.randomsupply.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.randomsupply.FormattingEnabled = true;
            this.randomsupply.Items.AddRange(new object[] {
            "商品名称",
            "商品描述"});
            this.randomsupply.Location = new System.Drawing.Point(194, 118);
            this.randomsupply.Name = "randomsupply";
            this.randomsupply.Size = new System.Drawing.Size(264, 28);
            this.randomsupply.TabIndex = 22;
            this.randomsupply.SelectedIndexChanged += new System.EventHandler(this.randomsupply_SelectedIndexChanged);
            // 
            // randomupper
            // 
            this.randomupper.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.randomupper.Location = new System.Drawing.Point(464, 118);
            this.randomupper.Name = "randomupper";
            this.randomupper.Size = new System.Drawing.Size(191, 30);
            this.randomupper.TabIndex = 23;
            this.randomupper.TextChanged += new System.EventHandler(this.randomupper_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(741, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "输入名称或者描述        ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::商品库存管理系统.Properties.Resources.timg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.randomupper);
            this.Controls.Add(this.randomsupply);
            this.Controls.Add(this.randomme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cell);
            this.Controls.Add(this.upper);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.tomb);
            this.Controls.Add(this.price);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.value);
            this.Controls.Add(this.name);
            this.Controls.Add(this.number);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form8";
            this.Text = "销售工作单";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private 商品库存管理DataSet1 商品库存管理DataSet1;
        private System.Windows.Forms.BindingSource 商品BindingSource;
        private 商品库存管理DataSet1TableAdapters.商品TableAdapter 商品TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售价格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进货价格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品描述DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品类别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仓库编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox tomb;
        private System.Windows.Forms.TextBox sort;
        private System.Windows.Forms.TextBox describe;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox normal;
        private System.Windows.Forms.Button upper;
        private System.Windows.Forms.TextBox cell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox randomme;
        private System.Windows.Forms.ComboBox randomsupply;
        private System.Windows.Forms.TextBox randomupper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}