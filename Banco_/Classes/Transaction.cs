using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_
{
    public class Transaction
    {
        public string TransanctionCode { get; set; }
        public string User { get; set; }
        public string Type { get; set; }
        public decimal Quanty { get; set; }
    }
}
