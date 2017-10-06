using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{
    public enum TypeOfStatus
    {
        Complete,
        Incomplete
    }
    class Order
    {
        
        
        #region Properties
        public string OrderStatus { get; set; }

        public int Quantity { get; set; }
        public Product OrderedProduct { get; set; }

        #endregion
        #region Methods
        public decimal OrderTotal()
        {
          
            decimal result;
            result = Quantity * OrderedProduct.ProductPrice;
            return (result);
        }
       

        #endregion

       

    }

}
