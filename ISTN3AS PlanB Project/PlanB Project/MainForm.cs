using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanB_Project
{
    public partial class MainForm : Form
    {
        public static String LoggedInAs;

       
        public MainForm()
        {
            InitializeComponent();
            // Set the default size of the MainForm
            this.Size = new Size(1100,600); // Width = 800, Height = 600
        }
        public string PrepareForm(Form MyChild)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            MyChild.MdiParent = this;
            MyChild.WindowState = FormWindowState.Maximized;    
            MyChild.Show();
            return LoggedInAs;

        }
        public string SetLogin(Form PersonRegistering)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            PersonRegistering.MdiParent = this;
            PersonRegistering.WindowState = FormWindowState.Maximized;
            LoggedInAs = LoginForm.role; // Store the name of the child form
                                         //set the username and role of user to the MainForm TopStrip
            
            menuStrip1.Items[4].Text = "Logged in as: " + LoggedInAs + " " + LoginForm.username;
            menuStrip1.Items["Logout"].Visible = true; // Show the logout menu item
            PersonRegistering.Show();
            return LoggedInAs;

        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
         

        }

        private void receptionistLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            else
            {
                
                LoginForm loginForm = new LoginForm();
                //loginForm.MdiParent = this;
                ShowLoginForm(loginForm);
            }

        }
        public void ShowLoginForm(Form Lform)
        {
            // Set default size
            //Lform.Size = new Size(500, 500); // Width = 400, Height = 300

            // Center the form on screen
            Lform.StartPosition = FormStartPosition.CenterScreen;
            Lform.Show(this);

            
        }

        private void dentistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //DentistForm Twoslice = new DentistForm();
            //PrepareForm(Twoslice);
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AppointmentForm appointmentForm = new AppointmentForm();
            // Set default size for the appointment form
            appointmentForm.Size = new Size(800, 800); // Width = 400, Height = 300
            PrepareForm(appointmentForm);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["MainForm"];
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
            //ms.Items["Logout"].Visible = false; // Show the logout menu item

        }
    }
}
