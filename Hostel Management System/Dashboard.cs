using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Hostel_Management_System
{
    public partial class Dashboard : Telerik.WinControls.UI.RadForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            RadForm1 rf = new RadForm1();
            rf.Show();
            this.Hide();
        }

        Boolean labelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelVisible == true)
            {
                lbl_hms.Visible = true;
                labelVisible = false;
            }
            else
            {
                lbl_hms.Visible = false;
                labelVisible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddNewRoom anr = new AddNewRoom();
            anr.Show();
        }
    }
}
