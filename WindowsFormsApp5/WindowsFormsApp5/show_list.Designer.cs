
namespace WindowsFormsApp5
{
    partial class show_list
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
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet2 = new WindowsFormsApp5.LibraryDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.documentTableAdapter = new WindowsFormsApp5.LibraryDataSet2TableAdapters.DocumentTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter the title to buy or to add comment on or to view info about it";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(340, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 60);
            this.button4.TabIndex = 15;
            this.button4.Text = "View book info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(175, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 60);
            this.button3.TabIndex = 14;
            this.button3.Text = "Add and View comments";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 60);
            this.button2.TabIndex = 13;
            this.button2.Text = "Buy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter the title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.availabilityNoDataGridViewTextBoxColumn,
            this.copyidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(527, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // availabilityNoDataGridViewTextBoxColumn
            // 
            this.availabilityNoDataGridViewTextBoxColumn.DataPropertyName = "availability_No";
            this.availabilityNoDataGridViewTextBoxColumn.HeaderText = "availability_No";
            this.availabilityNoDataGridViewTextBoxColumn.Name = "availabilityNoDataGridViewTextBoxColumn";
            // 
            // copyidDataGridViewTextBoxColumn
            // 
            this.copyidDataGridViewTextBoxColumn.DataPropertyName = "copy_id";
            this.copyidDataGridViewTextBoxColumn.HeaderText = "copy_id";
            this.copyidDataGridViewTextBoxColumn.Name = "copyidDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year_";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year_";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month_";
            this.monthDataGridViewTextBoxColumn.HeaderText = "month_";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "Document";
            this.documentBindingSource.DataSource = this.libraryDataSet2;
            // 
            // libraryDataSet2
            // 
            this.libraryDataSet2.DataSetName = "LibraryDataSet2";
            this.libraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "when start project the book title and price only will be exist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(449, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Remeber the copy_ID as you will need when adding new comment";
            // 
            // show_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "show_list";
            this.Text = "show_list";
            this.Load += new System.EventHandler(this.show_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private LibraryDataSet2 libraryDataSet2;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private LibraryDataSet2TableAdapters.DocumentTableAdapter documentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}