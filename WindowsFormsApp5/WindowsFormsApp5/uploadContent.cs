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
    public partial class uploadContent : Form
    {
        public uploadContent()
        {
            InitializeComponent();
        }

        private void uploadContent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet2.Document' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'libraryDataSet2.Document' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'libraryDataSet2.Book' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'libraryDataSet1.Document' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'libraryDataSet1.Book' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-7KAOM00;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO Document(title, price, Author, category,id, copy_id,  availability_No ) values ('" + textBox1.Text + "', " + textBox2.Text + "  ,'" + textBox3.Text + "', '" + textBox4.Text + "', " + textBox5.Text + "," + textBox6.Text + ", " + textBox8.Text + "  )";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Book was successfully uploaded");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.documentTableAdapter.Fill(this.libraryDataSet2.Document);
        }
    }
}
