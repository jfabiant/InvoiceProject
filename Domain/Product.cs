﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int ProductID { get; set; }

        [StringLength(150, MinimumLength =3)]
        public string ProductName { get; set; }
        public double Price { get; set; }
        
        [Range(0,3)]
        public int Stock { get; set; }

        //Campos de Auditoria
        [StringLength(150, MinimumLength = 3)]
        public string CreatedBy { get; set; }

        [StringLength(150, MinimumLength = 3)]
        public string ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool Enable { get; set; }
    }
}
