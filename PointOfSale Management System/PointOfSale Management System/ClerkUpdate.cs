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
using MetroFramework;
using DATAs;
using ValidationHelper;

namespace PointOfSale_Management_System
{
    public partial class ClerkUpdate : MetroForm 
    {
        string index;
        public ClerkUpdate( string index)
        {
            this.index = index;
            InitializeComponent();
            this.label8.Text = index;
        }
        int deptID = 1;

        private void ClerkUpdate_Load(object sender, EventArgs e)
        {

            PointOfSellEntities db = new PointOfSellEntities();
            String ClerkID = this.index;
            var query = db.Clerks.Where(x => x.ClerkID == ClerkID).First();
            //this.label8.Text = query.ClerkID;
            this.textBox2.Text = query.ClerkName;
            this.textBox3.Text = query.Address;
            this.textBox4.Text = query.Salary.ToString();
            this.textBox5.Text = query.Password;
            this.metroComboBox1.SelectedValue = query.Manager;
            this.metroDateTime1.Value = query.JoinDate;
             this.metroComboBox1.Items.Add("Sales");
            this.metroComboBox1.Items.Add("Marketing");
            this.metroComboBox1.Items.Add("Human Resourse");
        }
        void valueOfDept(string item)
        {
            if (item.Equals("Sales"))
                this.deptID = 1;
            else if (item.Equals("Marketing"))
                this.deptID = 4;
            else
                this.deptID = 5;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueOfDept(metroComboBox1.SelectedItem.ToString());
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            if (Val.IsStringValid(this.textBox2.Text) && Val.IsStringValid(this.textBox4.Text) && Val.IsStringValid(this.textBox5.Text))
            {
                try
                {
                    PointOfSellEntities db = new PointOfSellEntities();
                    var cl = db.Clerks.Where(x => x.ClerkID == this.index).First();
                    cl.ClerkID = this.index;
                    cl.ClerkName = this.textBox2.Text;
                    cl.Address = this.textBox3.Text;
                    cl.Salary = Int32.Parse(this.textBox4.Text);
                    cl.Password = this.textBox5.Text;
                    cl.DeptID = this.deptID;
                    cl.JoinDate = this.metroDateTime1.Value;
                    //db.Clerks.Add(cl);
                    db.SaveChanges();
                    MetroMessageBox.Show(this, "Message", "Value Has been Update ", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Message", ex.Message.ToString(), MessageBoxButtons.OK);
                }
               
            }

            MetroMessageBox.Show(this, "Message", "Value Has been Update ", MessageBoxButtons.OK);

            
        
        }
        
    }
}
