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
        [StringLength(20, MinimumLength = 0, ErrorMessage = "De naam bevat min. {2}, max. {1} tekens")]
        public string Naam { get; set; }
        [UIHint("kleuren")]
        [Alcohol(ErrorMessage ="{0} heeft een ongeldige waarde")]
        public float Alcohol { get; set; }
    }
}
