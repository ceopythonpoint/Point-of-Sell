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
    public partial class CustomerCURD : MetroFramework.Forms.MetroForm
    {
        Admin_Dashborad admin_ref;
        String CustomerSelectedID = " ";
        public CustomerCURD(Admin_Dashborad a )
        {
            this.admin_ref = a;
            InitializeComponent();
        }

public    CustomerCURD()
    {
        // TODO: Complete member initialization
    }
       

        private void CustomerCURD_Load(object sender, EventArgs e)
        {
            PointOfSellEntities db = new PointOfSellEntities();
            var data = from s in db.Customers select new { s.CustomerID, s.CustomerName, s.CustomerAddress };
            var result = data.ToList();
            this.metroGrid1.DataSource = result;

        }

        private void metroTile1ADDCustomer_Click(object sender, EventArgs e)
        {
            
        var frm = new CustomerADD();
        frm.Location = this.Location;
        frm.StartPosition = FormStartPosition.Manual;
        frm.FormClosing += delegate { this.Show(); };
        frm.Show();
        this.Hide();
             
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.populateGridView();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.CustomerSelectedID = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                PointOfSellEntities db = new PointOfSellEntities();
                var query = db.Customers.Where(x => x.CustomerID == CustomerSelectedID).First();
                this.metroTextBoxCustName.Text = query.CustomerName;
                this.metroTextBoxCustAddress.Text = query.CustomerAddress;
                this.metrotextboxCustomerID.Text = CustomerSelectedID;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString());
            }
        }

        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                return false;

            return true;
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PointOfSellEntities db = new PointOfSellEntities();
            var query = db.Customers.Where(x => x.CustomerName.Contains(this.metroTextBoxSearch.Text) || x.CustomerAddress.Contains(this.metroTextBoxSearch.Text)).ToList();
            var query2 = from s in query select new { s.CustomerID, s.CustomerName, s.CustomerAddress };
            var result = query2.ToList();
            this.metroGrid1.DataSource = result;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.admin_ref.Show();
            this.admin_ref.Visible =true;
            this.Close();

        }
        void ClearAll ()
        {
            this.metroTextBoxCustAddress.Clear();
            this.metroTextBoxCustName.Clear();
            this.metrotextboxCustomerID.Clear();
            this.CustomerSelectedID =" ";
            this.metroTextBoxSearch.Clear();
        }
       void populateGridView ()
        {
            PointOfSellEntities db = new PointOfSellEntities();
            var data = from s in db.Customers select new { s.CustomerID, s.CustomerName, s.CustomerAddress };
            var result = data.ToList();
            this.metroGrid1.DataSource = result;

        }

        private void metroTile2UpdateCustomer_Click(object sender, EventArgs e)
        {
             PointOfSellEntities db = new PointOfSellEntities();
             if (IsStringValid(this.metroTextBoxCustName.Text) && IsStringValid(this.metroTextBoxCustAddress.Text) )
             {
                 try
                 {
                     var query = db.Customers.Where(x => x.CustomerID == CustomerSelectedID).First();
                     query.CustomerAddress = this.metroTextBoxCustAddress.Text;
                     query.CustomerName = this.metroTextBoxCustName.Text;
                     db.SaveChanges();
                     this.populateGridView();
                     this.ClearAll();
                 }
                 catch (Exception)
                 {
                     MessageBox.Show(this, "Message ", "Please Enter the Updated Name and Address ", MessageBoxButtons.OK);

                     //throw;
                 }
             }      
           

        }

        private void metroTileDeleteCustomer_Click(object sender, EventArgs e)
        {

            PointOfSellEntities db = new PointOfSellEntities();
            if (IsStringValid(this.metroTextBoxCustName.Text) && IsStringValid(this.metroTextBoxCustAddress.Text))
            {
                try
                {
                    var query = db.Customers.Where(x => x.CustomerID == CustomerSelectedID).First();
                    //query.CustomerAddress = this.metroTextBoxCustAddress.Text;
                    //query.CustomerName = this.metroTextBoxCustName.Text;
                    db.Customers.Remove(query);
                    db.SaveChanges();
                    this.ClearAll();
                    this.populateGridView();
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Message ", "Please Enter the Updated Name and Address ", MessageBoxButtons.OK);

                    //throw;
                }
            }      

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                this.CustomerSelectedID = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                PointOfSellEntities db = new PointOfSellEntities();
                var query = db.Customers.Where(x => x.CustomerID == CustomerSelectedID).First();
                this.metroTextBoxCustName.Text = query.CustomerName;
                this.metroTextBoxCustAddress.Text = query.CustomerAddress;
                this.metrotextboxCustomerID.Text = CustomerSelectedID;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString());
            }

        }



        }

        
    }//end of namespace 

