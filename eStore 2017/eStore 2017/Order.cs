using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        
        public int ProductCode { get; set; }

        [ForeignKey("ProductCode")]
        public virtual Product OrderedProduct { get; set; }


        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer ShipToCustomer { get; set; }

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
