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
    
    public partial class city
    {
        public city()
        {
            this.neighborhood = new HashSet<neighborhood>();
        }
    
        public int city_id { get; set; }
        public string city_name { get; set; }
        public int states_id { get; set; }
    
        public virtual states states { get; set; }
        public virtual ICollection<neighborhood> neighborhood { get; set; }
    }
}
