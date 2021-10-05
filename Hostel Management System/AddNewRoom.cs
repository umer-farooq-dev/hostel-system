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
    public partial class AddNewRoom : Telerik.WinControls.UI.RadForm
    {
        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location =new Point(350, 170);
            lbl_Room.Visible = false;
            lbl_RoomExist.Visible = false;
        }
    }
}
