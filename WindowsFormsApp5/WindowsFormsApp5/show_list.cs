using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class show_list : Form
    {
        public show_list()
        {
            InitializeComponent();
        }

        private void show_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet2.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.libraryDataSet2.Document);

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            this.documentTableAdapter.Fill(this.libraryDataSet2.Document);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Comments f7 = new Comments();
            f7.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            book_info f10 = new book_info();
            f10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The book is added to cart successfully");
        }
    }
}
