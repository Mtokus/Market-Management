﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ShopManagementEntities : DbContext
    {
        public ShopManagementEntities()
            : base("name=ShopManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<productDetailTbl> productDetailTbl { get; set; }
        public virtual DbSet<productGroupTbl> productGroupTbl { get; set; }
        public virtual DbSet<productTbl> productTbl { get; set; }
        public virtual DbSet<receiptDetailTbl> receiptDetailTbl { get; set; }
        public virtual DbSet<receiptTbl> receiptTbl { get; set; }
        public virtual DbSet<StaffEntryExitTbl> StaffEntryExitTbl { get; set; }
        public virtual DbSet<staffPositionTbl> staffPositionTbl { get; set; }
        public virtual DbSet<staffTbl> staffTbl { get; set; }
        public virtual DbSet<supplierTbl> supplierTbl { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        public virtual ObjectResult<ProcedureStaffEntryExit_Result> ProcedureStaffEntryExit()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureStaffEntryExit_Result>("ProcedureStaffEntryExit");
        }
    
        public virtual ObjectResult<productProcedure_Result> productProcedure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<productProcedure_Result>("productProcedure");
        }
    }
}
