using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnderstandingCodeFirstProject.Models
{
    public class Disc
    {
        public int id { get; set; }
        public float Cost { get; set; }
        public int MovieNo { get; set; }

        //choose the foreign key to build relation
        public virtual Movie Movie { get; set; }
    }
}