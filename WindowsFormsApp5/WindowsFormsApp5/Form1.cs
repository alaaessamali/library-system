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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.profileTable' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'libraryDataSet1.profileTable' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'libraryDataSet.userTable' table. You can move, or remove it, as needed.



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO profileTable(userName,userPssword) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "') ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Sign Up was successfully completed, Press Next");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.profileTableTableAdapter.Fill(this.libraryDataSet1.profileTable);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "Admin")
            {
                Main f2 = new Main(textBox3.Text);
                f2.Show();
                this.Hide();

            }
            else if(textBox3.Text == "Author")
            {
                Main f2 = new Main(textBox3.Text);
                f2.Show();
                this.Hide();
            }

            else if (textBox3.Text == "Reader")
            {
                Main f2 = new Main(textBox3.Text);
                f2.Show();
                this.Hide();
            }
        }
    }
}
