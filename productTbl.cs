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
    
    public partial class productTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productTbl()
        {
            this.productDetailTbl = new HashSet<productDetailTbl>();
            this.receiptDetailTbl = new HashSet<receiptDetailTbl>();
        }
    
        public int productID { get; set; }
        public string productName { get; set; }
        public Nullable<double> productPrice { get; set; }
        public string productBarcode { get; set; }
        public Nullable<double> productKDVRate { get; set; }
        public Nullable<int> productStockQuantity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productDetailTbl> productDetailTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<receiptDetailTbl> receiptDetailTbl { get; set; }
    }
}
