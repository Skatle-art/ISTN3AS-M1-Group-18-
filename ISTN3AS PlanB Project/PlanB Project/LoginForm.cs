using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanB_Project
{
    
    public partial class LoginForm : Form
    {
        public static String username;
        public static string role;
        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            int password;
           
            usersTableAdapter2.UserLogin(wstGrp18DataSet2.Users, LoginUserNameBox.Text, LoginPasswordBox.Text);

            if (wstGrp18DataSet2.Users.Count > 0)
            { 
                    username = wstGrp18DataSet2.Users[0].UserName;
                    password = int.Parse(wstGrp18DataSet2.Users[0].Password);

                    MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
                if (username == LoginUserNameBox.Text && password == Convert.ToInt32(LoginPasswordBox.Text))
                {
                     role = wstGrp18DataSet2.Users[0].Job_description; // Get the role from the dataset

                    if (role == "Receptionist")
                    {
                        ReceptionistForm Receptionist = new ReceptionistForm();
                        mainForm.SetLogin(Receptionist);
                        this.Close();
                        MessageBox.Show(" Dentist Successfully Logged in .");

                    }
                    else if (role == "Dentist")
                    {


                        DentistForm dentistForm = new DentistForm();
                        mainForm.SetLogin(dentistForm); // Call method to prepare the form
                        this.Close();  // Close LoginForm
                        MessageBox.Show("Dentist Successfully Logged In.");

                    }
                    else if(role == "Assistant")
                    {
                        AssistantForm Assistant = new AssistantForm();
                        mainForm.SetLogin(Assistant);                         
                        this.Close();
                        MessageBox.Show("Assistant Successfully Logged in .");
                        
                        //access MainForm menu strip items


                    }
                    /*else if (role == "Admin")
                    {

                    mainForm.PrepareForm();
                    this.Close();
                    MessageBox.Show("Admin Successfully Logged in .");
                    }
                    */
                    else
                    {
                         MessageBox.Show("Un.");
                    }
                     
                    



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
