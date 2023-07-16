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
    public partial class adminInfo : Form
    {
        public object libraryDataSet2 { get; private set; }

        public adminInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void adminInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.adminTable' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO adminTable(id, position) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "') ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion was successfully completed");
        }
    }
}
