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
    public partial class ReaderInfo : Form
    {
        public ReaderInfo()
        {
            InitializeComponent();
        }

        private void ReaderInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet2.Reader' table. You can move, or remove it, as needed.
            this.readerTableAdapter.Fill(this.libraryDataSet2.Reader);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.readerTableAdapter.Fill(this.libraryDataSet2.Reader);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO Reader(id,job, company, reader_Address,num_of_books) VALUES (" + textBox1.Text + ", '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', " + textBox5.Text + " ) ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion was successfully completed");
        }
    }
}
