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
    
    public partial class ticket
    {
        public ticket()
        {
            this.commentaryXticket = new HashSet<commentaryXticket>();
        }
    
        public int tick_id { get; set; }
        public int typetick_id { get; set; }
        public int subjtick_id { get; set; }
        public int prioritytick_id { get; set; }
        public string tick_observation { get; set; }
        public string tick_userid { get; set; }
        public string tick_agenteid { get; set; }
        public string tick_responsible { get; set; }
        public int chan_id { get; set; }
        public int statustick_id { get; set; }
    
        public virtual channels channels { get; set; }
        public virtual ICollection<commentaryXticket> commentaryXticket { get; set; }
        public virtual priorityXticket priorityXticket { get; set; }
        public virtual statusXticket statusXticket { get; set; }
        public virtual subjectXticket subjectXticket { get; set; }
        public virtual typeXticket typeXticket { get; set; }
    }
}