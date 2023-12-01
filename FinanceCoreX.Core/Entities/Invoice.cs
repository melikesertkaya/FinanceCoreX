﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Core.Entities
{

    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
