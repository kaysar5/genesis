using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{/// <summary>
/// Order details 
/// </summary>
    class Order
    {/// <summary>
    /// number of the order placed
    /// </summary>
        public int OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public Product OrderdedProduct { get; set; }
        public int Quantity { get; set; }

        public decimal OrderTotal()
        {
            decimal result;
            result = Quantity * OrderdedProduct.ProductPrice;
            return (result);
        }

    }
}
