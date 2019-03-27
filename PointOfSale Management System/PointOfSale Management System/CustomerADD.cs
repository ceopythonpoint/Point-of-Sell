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
using DATAs;

namespace PointOfSale_Management_System
{
    public partial class CustomerADD : MetroForm 
    {
       //  private MetroFramework.Controls.MetroGrid gridObj;
        public CustomerADD()
        {
            InitializeComponent();
        }
         
        private void CustomerADD_Load(object sender, EventArgs e)
        {
           using  ( PointOfSellEntities db = new PointOfSellEntities () )
           {
               Customer cus = new Customer();
               this.label1.Text = cus.autoUserID();
           }
           this.clear();
        }
        void clear ()
        {
            this.metroTextBox1name.Clear();
            this.metroTextBox2Address.Clear();
        }

        private void metroTile1AddCustomer_Click(object sender, EventArgs e)
        {
             using  ( PointOfSellEntities db = new PointOfSellEntities () )
             {

                 try
                 {
                     Customer cus = new Customer();
                     cus.CustomerName = this.metroTextBox1name.Text;
                     cus.CustomerAddress = this.metroTextBox2Address.Text;
                     cus.CustomerID = cus.autoUserID();
                     db.Customers.Add(cus);
                     db.SaveChanges();
                     this.clear();
                     this.label1.Text = cus.autoUserID();
                 }
                 catch (Exception a)
                 {
                     MessageBox.Show(a.Message.ToString());
                     //throw;
                 }
             }
            
        }

    }
}
