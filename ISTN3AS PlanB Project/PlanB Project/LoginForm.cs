using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanB_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String username;
            int password;
            usersTableAdapter1.LoginUser(wstGrp18DataSet1.Users, LoginUserNameBox.Text, LoginPasswordBox.Text);
            if (wstGrp18DataSet1.Users.Count > 0)
            { 
                    username = wstGrp18DataSet1.Users[0].UserName;
                    password = int.Parse(wstGrp18DataSet1.Users[0].Password);
                    if (username == LoginUserNameBox.Text && password == Convert.ToInt32(LoginPasswordBox.Text))
                    {
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("No user found with the provided credentials.");
            }
        }
    }
}
