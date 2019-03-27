using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAs
{
    public partial class Clerk
    {
        public string autoUserID()
        {
            PointOfSellEntities db = new PointOfSellEntities();
            string thisUserIDOutPut = " ";
            try
            {
                var query = db.Database.SqlQuery<string>("SELECT TOP 1 ClerkID from Clerk order by ClerkID desc").FirstOrDefault();
                Console.WriteLine(query);
                string LastUserID = query.Substring(5);
                int thisUserID = Int32.Parse(LastUserID);
                thisUserID++;
                thisUserIDOutPut = "Clerk" + Convert.ToString(thisUserID);

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
