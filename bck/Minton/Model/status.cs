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
    
    public partial class status
    {
        public status()
        {
            this.entity = new HashSet<entity>();
            this.invoices = new HashSet<invoices>();
            this.sales = new HashSet<sales>();
            this.statusclaims = new HashSet<statusclaims>();
        }
    
        public int status_id { get; set; }
        public string status_description { get; set; }
    
        public virtual ICollection<entity> entity { get; set; }
        public virtual ICollection<invoices> invoices { get; set; }
        public virtual ICollection<sales> sales { get; set; }
        public virtual ICollection<statusclaims> statusclaims { get; set; }
    }
}