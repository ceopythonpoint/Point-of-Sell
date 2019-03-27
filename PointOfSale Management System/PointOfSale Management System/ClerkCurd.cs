using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATAs;

namespace PointOfSale_Management_System
{
    public partial class ClerkCurd : MetroFramework.Forms.MetroForm 
    {
        Admin_Dashborad admin_ref;
        public ClerkCurd( Admin_Dashborad a )
        {
            this.admin_ref = a;
            InitializeComponent();
        }

        string ClerkID = " ";
        
        void populategridView ()
        {
            using ( PointOfSellEntities db = new PointOfSellEntities ()  )
            {
                var query = db.Clerks.ToList();
                this.metroGrid1.DataSource = query;
            }
        }

        private void ClerkCurd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointOfSellDataSet.Clerk' table. You can move, or remove it, as needed.
            this.clerkTableAdapter.Fill(this.pointOfSellDataSet.Clerk);

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PointOfSellEntities db = new PointOfSellEntities();
            String cusId = this.metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.ClerkID = cusId;
           /* var frm = new Info(this.ClerkID);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
            * */

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var frm = new Info(this.ClerkID);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

        private void metroTile1ADDclerk_Click(object sender, EventArgs e)
        {
            var frm = new ClerkAdd();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            populategridView();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PointOfSellEntities db = new PointOfSellEntities();
            String cusId = this.metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.ClerkID = cusId;
            /*
            var frm = new Info(this.ClerkID);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
             * */

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.admin_ref.Show();
            this.admin_ref.Visible = true;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PointOfSellEntities db = new PointOfSellEntities();
            var query = db.Clerks.Where(x => x.ClerkName.Contains(this.textBox1.Text)).ToList();
            this.metroGrid1.DataSource = query;

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            PointOfSellEntities db = new PointOfSellEntities();
           // String cusId = this.metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //this.ClerkID = cusId;
            var frm = new ClerkUpdate(this.ClerkID);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();


        }

        private void metroTile3delete_Click(object sender, EventArgs e)
        {
            PointOfSellEntities db = new PointOfSellEntities();
            // String cusId = this.metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //this.ClerkID = cusId;
            var frm = new ClerkDelete(this.ClerkID);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

    }
}
