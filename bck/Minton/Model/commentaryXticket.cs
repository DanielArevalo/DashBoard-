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
    
    public partial class commentaryXticket
    {
        public int commentick_id { get; set; }
        public int tick_id { get; set; }
        public string commentick_observation { get; set; }
        public string commentick_userid { get; set; }
        public int vicomment_id { get; set; }
    
        public virtual ticket ticket { get; set; }
        public virtual visibilityXcommentary visibilityXcommentary { get; set; }
    }
}
