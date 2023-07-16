
namespace WindowsFormsApp5
{
    partial class Book_category
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.libraryDataSet3 = new WindowsFormsApp5.LibraryDataSet3();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter = new WindowsFormsApp5.LibraryDataSet3TableAdapters.DocumentTableAdapter();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(452, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Categories Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // libraryDataSet3
            // 
            this.libraryDataSet3.DataSetName = "LibraryDataSet3";
            this.libraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "Document";
            this.documentBindingSource.DataSource = this.libraryDataSet3;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
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
            // Book_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Book_category";
            this.Text = "Book_category";
            this.Load += new System.EventHandler(this.Book_category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private LibraryDataSet3 libraryDataSet3;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private LibraryDataSet3TableAdapters.DocumentTableAdapter documentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
    }
}