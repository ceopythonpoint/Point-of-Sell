using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAs
{
    public partial class Customer
    {
        public string autoUserID()
        {
            
            string thisUserIDOutPut = " ";
            try
            {
                PointOfSellEntities db = new PointOfSellEntities();
                var query = db.Database.SqlQuery<string>("SELECT TOP 1 CustomerID from Customer order by CustomerID desc").FirstOrDefault();
                Console.WriteLine(query);
                string LastUserID = query.Substring(3);
                int thisUserID = Int32.Parse(LastUserID);
                thisUserID++;
                thisUserIDOutPut = "Cus" + Convert.ToString(thisUserID);

                // string Lastnumber = query.Substring(query.Length - Math.Min(3, query.Length));
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            return thisUserIDOutPut;
        }
    }
}
