using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{
     
    
   public  class Product
    {
        #region Properties

        /// <summary>
        /// Product's name
        /// </summary>
        [Required]
        public string ProductName { get; set; }

        /// <summary>
        /// Product's code number
        /// </summary>
        [Key]
        public int ProductCode { get; set; }
        
        /// <summary>
        /// Price of the product
        /// </summary>
        [Required]
        public decimal ProductPrice { get;  set; }
        public virtual ICollection<Order> Orders { get; set; }

        #endregion

        public void print()
        {
            Console.WriteLine("ProductName: " + ProductName);
            Console.WriteLine("ProductCode: " + ProductCode);
            Console.WriteLine("ProductPrice: "+ ProductPrice);
        }
      
   }
   
}
