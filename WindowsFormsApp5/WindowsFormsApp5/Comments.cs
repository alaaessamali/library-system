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
    public partial class Comments : Form
    {
        public Comments()
        {
            InitializeComponent();
        }

        private void Comments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet3.comment' table. You can move, or remove it, as needed.
            this.commentTableAdapter.Fill(this.libraryDataSet3.comment);
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.commentTableAdapter.Fill(this.libraryDataSet3.comment);
            dataGridView1.Columns[1].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO comment(id, copy_id, words, title) VALUES (" + textBox1.Text + ", " + textBox3.Text + ", '" + textBox2.Text + "', '"+ textBox4.Text + "') ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Comment was successfully posted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE comment SET words = '" + textBox2.Text + "' WHERE id = " + textBox1.Text + " and copy_id = " + textBox3.Text + " ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Comment was successfully Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM comment   WHERE id = " + textBox1.Text + " and copy_id = " + textBox3.Text + " ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Comment was successfully deleted");
        }
    }
}
