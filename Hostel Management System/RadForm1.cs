using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Hostel_Management_System
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if(txt_user.Text=="malik" && txt_password.Text == "malik")
            {
                
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                txt_password.Clear();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
