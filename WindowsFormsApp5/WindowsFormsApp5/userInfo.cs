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
    public partial class userInfo : Form
    {
        public userInfo()
        {
            InitializeComponent();
        }

        private void userInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet2.userTable' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'libraryDataSet1.userTable' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'libraryDataSet1.userTable' table. You can move, or remove it, as needed.


        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminInfocs f4 = new AdminInfocs();
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.userTableTableAdapter.Fill(this.libraryDataSet2.userTable);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            authorInfo f5 = new authorInfo();
            f5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO userTable(id, name_, account) VALUES (" + textBox2.Text + " ,'" + textBox1.Text + "', '" + textBox3.Text + "') ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Inseartion was successfully completed, Press any of the buttons");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReaderInfo f9 = new ReaderInfo();
            f9.Show();
            
        }
    }
}
