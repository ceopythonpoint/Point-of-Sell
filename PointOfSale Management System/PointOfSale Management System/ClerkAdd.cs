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
using MetroFramework.Forms;
using MetroFramework ;
using ValidationHelper;

namespace PointOfSale_Management_System
{
    public partial class ClerkAdd : MetroForm
    {
        public ClerkAdd()
        {
            InitializeComponent();
        }

        int deptID =1;

        private void ClerkAdd_Load(object sender, EventArgs e)
        {
            this.metroComboBox1.Items.Add("Sales");
            this.metroComboBox1.Items.Add("Marketing");
            this.metroComboBox1.Items.Add("Human Resourse");
            Clerk a = new Clerk();
            this.label8.Text = a.autoUserID();

        }
        void  valueOfDept(string item)
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
                    Clerk cl = new Clerk();
                    cl.ClerkID = cl.autoUserID();
                    cl.ClerkName = this.textBox2.Text;
                    cl.Address = this.textBox3.Text;
                    cl.Salary = Int32.Parse(this.textBox4.Text);
                    cl.Password = this.textBox5.Text;
                    cl.DeptID = this.deptID;
                    cl.JoinDate = this.metroDateTime1.Value;
                    db.Clerks.Add(cl);
                    db.SaveChanges();
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
