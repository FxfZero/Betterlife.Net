//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loguser
    {
        public decimal ID { get; set; }
        public decimal User_ID { get; set; }
        public Nullable<short> Usertype { get; set; }
        public string Log_Content { get; set; }
        public Nullable<System.DateTime> Committime { get; set; }
    
        public virtual User User { get; set; }
    }
}
