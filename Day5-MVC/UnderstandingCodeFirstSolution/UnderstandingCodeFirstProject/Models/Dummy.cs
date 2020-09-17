using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnderstandingCodeFirstProject.Models
{
    public class Dummy
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }
        [Key, Column(Order = 2)]
        public float Cost { get; set; }
        public float Anothet { get; set; }
    }
}