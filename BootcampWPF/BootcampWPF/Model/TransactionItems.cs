//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BootcampWPF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionItems
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public System.DateTimeOffset CreateDate { get; set; }
        public System.DateTimeOffset UpdateDate { get; set; }
        public System.DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<int> Items_id { get; set; }
        public Nullable<int> Transactions_id { get; set; }
    
        public virtual Items Items { get; set; }
        public virtual Transactions Transactions { get; set; }
    }
}
