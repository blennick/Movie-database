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
    
    public partial class UserOwnsMovy
    {
        public int ownId { get; set; }
        public int userId { get; set; }
        public int movieId { get; set; }
    
        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }
    }
}
