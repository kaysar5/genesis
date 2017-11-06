using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

   public class Order
    {


        #region Properties
        [Key]
        public int OrderNumber { get; set; }
        [Required]
        public string OrderStatus { get; set; }
        [Required]
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
