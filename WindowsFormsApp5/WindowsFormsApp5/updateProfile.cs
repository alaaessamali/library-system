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
    public partial class updateProfile : Form
    {
        public updateProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE profileTable SET userName = '"+textBox1.Text+"' where userName = '"+textBox3.Text+"'  ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update userName was successfully completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE profileTable SET userPssword = '" + textBox2.Text + "' where userName = '" + textBox3.Text + "'  ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update Password was successfully completed");
        }

        private void updateProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.profileTable' table. You can move, or remove it, as needed.
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.profileTableTableAdapter.Fill(this.libraryDataSet1.profileTable);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM profileTable WHERE userName = '"+textBox3.Text+"' ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion was successfully completed");
        }
    }
}
