//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Market_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class receiptDetailTbl
    {
        public int receiptDetailID { get; set; }
        public Nullable<int> receiptID { get; set; }
        public Nullable<int> productID { get; set; }
        public Nullable<double> productQuantity { get; set; }
        public Nullable<double> productTotalPrice { get; set; }
        public Nullable<bool> productRebate { get; set; }
    
        public virtual productTbl productTbl { get; set; }
        public virtual receiptTbl receiptTbl { get; set; }
    }
}
