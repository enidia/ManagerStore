namespace 商品库存管理系统
{
    partial class Form12
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.商品库存管理DataSet6 = new 商品库存管理系统.商品库存管理DataSet6();
            this.商品BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品TableAdapter = new 商品库存管理系统.商品库存管理DataSet6TableAdapters.商品TableAdapter();
            this.商品库存管理DataSet7 = new 商品库存管理系统.商品库存管理DataSet7();
            this.商品BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.商品TableAdapter1 = new 商品库存管理系统.商品库存管理DataSet7TableAdapters.商品TableAdapter();
            this.商品类别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.平均销售价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品库存管理DataSet8 = new 商品库存管理系统.商品库存管理DataSet8();
            this.商品BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.商品TableAdapter2 = new 商品库存管理系统.商品库存管理DataSet8TableAdapters.商品TableAdapter();
            this.商品库存管理DataSet9 = new 商品库存管理系统.商品库存管理DataSet9();
            this.商品BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.商品TableAdapter3 = new 商品库存管理系统.商品库存管理DataSet9TableAdapters.商品TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "按下查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 25);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品类别DataGridViewTextBoxColumn,
            this.price,
            this.平均销售价格});
            this.dataGridView1.DataSource = this.商品BindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(470, 220);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 商品库存管理DataSet6
            // 
            this.商品库存管理DataSet6.DataSetName = "商品库存管理DataSet6";
            this.商品库存管理DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品BindingSource
            // 
            this.商品BindingSource.DataMember = "商品";
            this.商品BindingSource.DataSource = this.商品库存管理DataSet6;
            // 
            // 商品TableAdapter
            // 
            this.商品TableAdapter.ClearBeforeFill = true;
            // 
            // 商品库存管理DataSet7
            // 
            this.商品库存管理DataSet7.DataSetName = "商品库存管理DataSet7";
            this.商品库存管理DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品BindingSource1
            // 
            this.商品BindingSource1.DataMember = "商品";
            this.商品BindingSource1.DataSource = this.商品库存管理DataSet7;
            // 
            // 商品TableAdapter1
            // 
            this.商品TableAdapter1.ClearBeforeFill = true;
            // 
            // 商品类别DataGridViewTextBoxColumn
            // 
            this.商品类别DataGridViewTextBoxColumn.DataPropertyName = "商品类别";
            this.商品类别DataGridViewTextBoxColumn.HeaderText = "商品类别";
            this.商品类别DataGridViewTextBoxColumn.Name = "商品类别DataGridViewTextBoxColumn";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "平均进货价格";
            this.price.Name = "price";
            // 
            // 平均销售价格
            // 
            this.平均销售价格.DataPropertyName = "value";
            this.平均销售价格.HeaderText = "平均销售价格";
            this.平均销售价格.Name = "平均销售价格";
            // 
            // 商品库存管理DataSet8
            // 
            this.商品库存管理DataSet8.DataSetName = "商品库存管理DataSet8";
            this.商品库存管理DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品BindingSource2
            // 
            this.商品BindingSource2.DataMember = "商品";
            this.商品BindingSource2.DataSource = this.商品库存管理DataSet8;
            // 
            // 商品TableAdapter2
            // 
            this.商品TableAdapter2.ClearBeforeFill = true;
            // 
            // 商品库存管理DataSet9
            // 
            this.商品库存管理DataSet9.DataSetName = "商品库存管理DataSet9";
            this.商品库存管理DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品BindingSource3
            // 
            this.商品BindingSource3.DataMember = "商品";
            this.商品BindingSource3.DataSource = this.商品库存管理DataSet9;
            // 
            // 商品TableAdapter3
            // 
            this.商品TableAdapter3.ClearBeforeFill = true;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 276);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form12";
            this.Text = "仓库与平均差";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品库存管理DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 商品库存管理DataSet6 商品库存管理DataSet6;
        private System.Windows.Forms.BindingSource 商品BindingSource;
        private 商品库存管理DataSet6TableAdapters.商品TableAdapter 商品TableAdapter;
        private 商品库存管理DataSet7 商品库存管理DataSet7;
        private System.Windows.Forms.BindingSource 商品BindingSource1;
        private 商品库存管理DataSet7TableAdapters.商品TableAdapter 商品TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品类别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn 平均销售价格;
        private 商品库存管理DataSet8 商品库存管理DataSet8;
        private System.Windows.Forms.BindingSource 商品BindingSource2;
        private 商品库存管理DataSet8TableAdapters.商品TableAdapter 商品TableAdapter2;
        private 商品库存管理DataSet9 商品库存管理DataSet9;
        private System.Windows.Forms.BindingSource 商品BindingSource3;
        private 商品库存管理DataSet9TableAdapters.商品TableAdapter 商品TableAdapter3;
    }
}