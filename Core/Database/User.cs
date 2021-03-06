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
    
    public partial class User
    {
        public User()
        {
            this.Blog = new HashSet<Blog>();
            this.Comment = new HashSet<Comment>();
            this.Loguser = new HashSet<Loguser>();
            this.Userdetail = new HashSet<Userdetail>();
            this.Usernotice = new HashSet<Usernotice>();
            this.Userrole = new HashSet<Userrole>();
        }
    
        public decimal ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public Nullable<System.DateTime> Logintimes { get; set; }
        public Nullable<System.DateTime> Committime { get; set; }
        public Nullable<System.DateTime> Updatetime { get; set; }
    
        public virtual ICollection<Blog> Blog { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Loguser> Loguser { get; set; }
        public virtual ICollection<Userdetail> Userdetail { get; set; }
        public virtual ICollection<Usernotice> Usernotice { get; set; }
        public virtual ICollection<Userrole> Userrole { get; set; }
    }
}
