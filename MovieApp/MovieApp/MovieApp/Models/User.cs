//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserOwnsMovies = new HashSet<UserOwnsMovy>();
        }
    
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<UserOwnsMovy> UserOwnsMovies { get; set; }
    }
}
