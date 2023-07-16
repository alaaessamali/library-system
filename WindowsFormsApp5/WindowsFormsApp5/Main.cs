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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string username;
        public Main(string s)
        {
            InitializeComponent();
            username = s;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(username == "Reader")
            {
              
                button6.Hide();
                button7.Hide();
            }

            else if(username == "Author")
            {
                button7.Hide();
            }
            else if(username == "Admin")
            {
               
                button6.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show_list f6 = new show_list();
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateProfile f3 = new updateProfile();
            f3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userInfo f3 = new userInfo();
            f3.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uploadContent f4 = new uploadContent();
            f4.Show();
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Book_category f11 = new Book_category();
            f11.Show();
        }
    }
}
