﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Detail
    {
        public int DetailID { get; set; }

        public int Quantity { get; set; }
        public int Prize { get; set; }


        //public User Seller { get; set; }
        //public int SellerID { get; set; }
        public User Client { get; set; }
        public Product Product { get; set; }
        public int ProductID { get; set; }

        //1 Detail have an invoice
        public Invoice Invoice { get; set; }
        public int InvoiceID { get; set; }
    }
}
