using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnderstandingCodeFirstProject.Models
{
    public class Movie
    {
        [Key]//primary key
        public int MovieNo { get; set; }
        [Required]//not null
        [Column("MovieName")]//specify the column name
        public string Name { get; set; }
        public float Duration { get; set; }

        public virtual ICollection<Disc> Discs { get; set; }
    }
}