//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoreOnMVCandEFinProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class disc
    {
        public int id { get; set; }
        public Nullable<int> movie_id { get; set; }
        public Nullable<double> rental_cost { get; set; }
    
        public virtual movy movy { get; set; }
    }
}
