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
    public partial class book_info : Form
    {
        public book_info()
        {
            InitializeComponent();
        }

       

        private void book_info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet3.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.libraryDataSet3.Document);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.documentTableAdapter.Fill(this.libraryDataSet3.Document);

        }
    }
}
