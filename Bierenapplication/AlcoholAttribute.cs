﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bierenapplication
{
    public class AlcoholAttribute : ValidationAttribute
    {
        public override bool IsValid(object value) 
        {
            if (value == null)
            return true; 
            if (!(value is float))
            return false;
            var alcoholwaarde = (float)value;
             return ((alcoholwaarde <15) && (alcoholwaarde >0));
        }
    }
}
