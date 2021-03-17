using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "")
            {
                MessageBox.Show("Username can not be empty. Please enter your username.");
            }
            else if (password == "")
            {
                MessageBox.Show("Password can not be empty. Please enter the password.");
            }
            else
            {
                dbAcccess acccess = new dbAcccess();
                List<adminstrator> adminstrators = acccess.checkAdminstrator(username, password);
                if (adminstrators.Any()) 
                {
                    foreach(adminstrator admin in adminstrators)
                    {
                        MessageBox.Show(admin.ToString());
                    }
                    
                }
                else
                {
                    MessageBox.Show("There is no user with the given details. Please provide correct credentials.");
                }
            }
        }
    }
}
