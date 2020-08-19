using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bierenapplication.Models
{
    public class Bier
    {
        [DisplayFormat(DataFormatString = "{0:000}")]
        public int ID { get; set; }

        public string Naam { get; set; }
        [UIHint("kleurtjes")]
        public float Alcohol { get; set; }
    }
}
