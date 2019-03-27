using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PointOfSale_Management_System
{
    public partial class Admin_Dashborad : MetroForm
    {
        public Admin_Dashborad()
        {
            InitializeComponent();
        }

        private void mtileCustomer_Click(object sender, EventArgs e)
        {
            CustomerCURD cusCurd = new CustomerCURD(this);
            this.Hide();
            cusCurd.Show();

        }

        private void metroTileClerk_Click(object sender, EventArgs e)
        {
            ClerkCurd clu = new ClerkCurd(this);
            this.Hide();
            clu.Show();

        }
    }
}
