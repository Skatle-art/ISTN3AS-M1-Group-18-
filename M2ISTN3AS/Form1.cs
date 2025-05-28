using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2ISTN3AS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void receptionistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RegistrationForm = new Form();
            RegistrationForm.ShowDialog();
        }
    }
}
