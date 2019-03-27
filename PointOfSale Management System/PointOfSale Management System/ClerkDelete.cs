using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using DATAs;


namespace PointOfSale_Management_System
{
    public partial class ClerkDelete : MetroForm 
    {
        string index;
        public ClerkDelete(String index)
        {
            this.index = index;
            InitializeComponent();
        }

        private void ClerkDelete_Load(object sender, EventArgs e)
        {
            PointOfSellEntities db = new PointOfSellEntities();
            String ClerkID = this.index;
            var query = db.Clerks.Where(x => x.ClerkID == ClerkID).First();
            this.label8.Text = query.ClerkID;
            this.textBox2.Text = query.ClerkName;
            this.textBox3.Text = query.Address;
            this.textBox4.Text = query.Salary.ToString();
            this.textBox5.Text = query.Password;
            this.textBox6.Text = query.Manager;
            this.textBox7.Text = query.JoinDate.ToString();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            PointOfSellEntities db = new PointOfSellEntities();
            String ClerkID = this.index;
            var query = db.Clerks.Where(x => x.ClerkID == ClerkID).First();
            db.Clerks.Remove(query);
            db.SaveChanges();
            ClearAll();

        }
        void ClearAll ()
        {
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
        }
    }
}
