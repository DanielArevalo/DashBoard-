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
    
    public partial class menus
    {
        public menus()
        {
            this.permissionsXmenu = new HashSet<permissionsXmenu>();
        }
    
        public int menu_id { get; set; }
        public string menu_name { get; set; }
        public int app_id { get; set; }
        public string menu_action { get; set; }
        public string menu_controller { get; set; }
        public string menu_icon { get; set; }
        public bool menu_isparent { get; set; }
        public int menu_parentid { get; set; }
    
        public virtual apps apps { get; set; }
        public virtual ICollection<permissionsXmenu> permissionsXmenu { get; set; }
    }
}
