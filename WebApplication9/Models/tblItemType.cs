//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblItemType
    {
        public tblItemType()
        {
            this.tblItems = new HashSet<tblItem>();
        }
    
        public string ItemType { get; set; }
    
        public virtual ICollection<tblItem> tblItems { get; set; }
    }
}
