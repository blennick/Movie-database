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
    
    public partial class MainActor
    {
        public MainActor()
        {
            this.Movies = new HashSet<Movie>();
        }
    
        public int actorId { get; set; }
        public string actorFName { get; set; }
        public string actorLName { get; set; }
        public string actorRole { get; set; }
    
        public virtual ICollection<Movie> Movies { get; set; }
    }
}