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
    
    public partial class visibilityXcommentary
    {
        public visibilityXcommentary()
        {
            this.commentaryXticket = new HashSet<commentaryXticket>();
        }
    
        public int vicomment_id { get; set; }
        public string vicomment_description { get; set; }
    
        public virtual ICollection<commentaryXticket> commentaryXticket { get; set; }
    }
}
