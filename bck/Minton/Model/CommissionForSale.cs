//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Milton.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommissionForSale
    {
        public int commisale_id { get; set; }
        public Nullable<int> sales_id { get; set; }
        public Nullable<double> commisale_level1 { get; set; }
        public Nullable<double> commisale_level2 { get; set; }
        public Nullable<double> commisale_level3 { get; set; }
        public Nullable<double> commisale_level4 { get; set; }
    
        public virtual sales sales { get; set; }
    }
}
