using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{

   public enum TypeOfPayment
    {
        Credit,
        Debit            
    }
    class Payment
    {
        public int PaymentDetails { get; set; }
        public TypeOfPayment PaymentType { get; set; }
    }
}
