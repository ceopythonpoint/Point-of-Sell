//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public Item()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }
    
        public string ItemNo { get; set; }
        public string I_Description { get; set; }
        public int Buy_price { get; set; }
        public int Sell_price { get; set; }
        public int StockUnit { get; set; }
        public int CategoryID { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}