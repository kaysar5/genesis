using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{
    class Order
    {
        
        
        #region Properties
        public string OrderStatus { get; set; }
<<<<<<< HEAD
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
=======
        public Product OrderdedProduct { get; set; }
        public int Quantity { get; set; }

        public decimal OrderTotal()
        {
            decimal result;
            result = Quantity * OrderdedProduct.ProductPrice;
            return (result);
        }
>>>>>>> 2329b4a530f3134ed58b1eaab38afa077469dcfa

    }

}
