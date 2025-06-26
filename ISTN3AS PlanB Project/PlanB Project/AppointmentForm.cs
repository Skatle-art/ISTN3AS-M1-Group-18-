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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp18DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.wstGrp18DataSet.Patient);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            //get back to the main form home page and close this form
           
           
            MainForm BossForm = new MainForm();

            if (LoginForm.role == "Dentist" || LoginForm.role == "Receptionist" || LoginForm.role == "Assistant")
            {
               //close this child and open another child form
                if(LoginForm.role == "Dentist")
                {
                    DentistForm dentistForm = new DentistForm();
                    BossForm.SetLogin(dentistForm); // Call method to prepare the form
                }
                else if(LoginForm.role == "Receptionist")
                {
                    ReceptionistForm receptionistForm = new ReceptionistForm();
                    BossForm.SetLogin(receptionistForm); // Call method to prepare the form
                }
                else if(LoginForm.role == "Assistant")
                {
                    AssistantForm assistantForm = new AssistantForm();
                    BossForm.SetLogin(assistantForm); // Call method to prepare the form
                }
                this.Close(); // Close the AppointmentForm
                MessageBox.Show("Appointment Form Closed. Returning to Main Form.");





            }
            else
            {
                MessageBox.Show("Main form is not open.");
            }
        }
    }
}
