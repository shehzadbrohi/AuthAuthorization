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
    
    public partial class tblItem
    {
        public int ItemID { get; set; }
        public string Item { get; set; }
        public string ItemType { get; set; }
        public Nullable<decimal> Cost { get; set; }
    
        public virtual tblItemType tblItemType { get; set; }
    }
}