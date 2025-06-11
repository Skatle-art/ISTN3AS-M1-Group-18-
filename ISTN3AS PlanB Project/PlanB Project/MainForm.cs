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
       
        public MainForm()
        {
            InitializeComponent();
        }
        private void PrepareForm(Form MyChild)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            MyChild.MdiParent = this;
            MyChild.WindowState = FormWindowState.Maximized;
            MyChild.Show();
        }
        public void SetLogin(Form PersonRegistering)
        {
            
            if (PersonRegistering == ReceptionistForm.ActiveForm)
            {

            }
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
                ShowLoginForm(loginForm);
            }

        }
        public void ShowLoginForm(Form Lform)
        {
            // Set default size
            Lform.Size = new Size(500, 500); // Width = 400, Height = 300

            // Center the form on screen
            Lform.StartPosition = FormStartPosition.CenterScreen;
            Lform.ShowDialog(this);

            
        }
    }
}
