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
    public partial class DentistForm : Form
    {
        public DentistForm()
        {
            InitializeComponent();
        }
       
        private void DentistForm_Load(object sender, EventArgs e)
        {
            // Set the panel to be part of the form
            //.BringToFront(); // Ensure the panel is on top of other controls
            //panel1.Dock = DockStyle.Right; // Dock the panel to the right side of the form
            MainForm parent = this.MdiParent as MainForm;
            if (parent != null)
            {
                // Medical = new ToolStripMenuItem("Medical Records");
                // Add the Medical Record menu item to the main form's menu strip
                //parent.menuStrip1.Items.Add("Medical Records");
                //parent.menuStrip1.Items.Add("Treatment");
                //parent.menuStrip1.Items.Add("Report");
            }
        }
    }
}
