using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Book_category : Form
    {
        public Book_category()
        {
            InitializeComponent();
        }

        private void Book_category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet3.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.libraryDataSet3.Document);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.documentTableAdapter.Fill(this.libraryDataSet3.Document);
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        }
}
