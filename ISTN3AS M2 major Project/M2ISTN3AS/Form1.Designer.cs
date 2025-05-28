
namespace M2ISTN3AS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accessControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptionistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dentistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assistantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookNewAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(709, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(260, 679);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessControlToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accessControlToolStripMenuItem
            // 
            this.accessControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receptionistToolStripMenuItem,
            this.dentistToolStripMenuItem,
            this.assistantToolStripMenuItem});
            this.accessControlToolStripMenuItem.Name = "accessControlToolStripMenuItem";
            this.accessControlToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.accessControlToolStripMenuItem.Text = "Access_Control";
            // 
            // receptionistToolStripMenuItem
            // 
            this.receptionistToolStripMenuItem.Name = "receptionistToolStripMenuItem";
            this.receptionistToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.receptionistToolStripMenuItem.Text = "Receptionist";
            // 
            // dentistToolStripMenuItem
            // 
            this.dentistToolStripMenuItem.Name = "dentistToolStripMenuItem";
            this.dentistToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dentistToolStripMenuItem.Text = "Dentist";
            // 
            // assistantToolStripMenuItem
            // 
            this.assistantToolStripMenuItem.Name = "assistantToolStripMenuItem";
            this.assistantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.assistantToolStripMenuItem.Text = "Assistant";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookNewAppointmentToolStripMenuItem,
            this.viewAppointmentsToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // bookNewAppointmentToolStripMenuItem
            // 
            this.bookNewAppointmentToolStripMenuItem.Name = "bookNewAppointmentToolStripMenuItem";
            this.bookNewAppointmentToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.bookNewAppointmentToolStripMenuItem.Text = "Book New Appointment";
            // 
            // viewAppointmentsToolStripMenuItem
            // 
            this.viewAppointmentsToolStripMenuItem.Name = "viewAppointmentsToolStripMenuItem";
            this.viewAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.viewAppointmentsToolStripMenuItem.Text = "View Appointments";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(258, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 707);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accessControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptionistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dentistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assistantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookNewAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}

