using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{
    
    
    class Product
    {
        private static int lastProductCode = 500;
       
        #region Properties
        /// <summary>
        /// Product's name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Product's code number
        /// </summary>
        public int ProductCode { get;  }

        /// <summary>
        /// Price of the product
        /// </summary>
        public decimal ProductPrice { get; private set; }
        
        #endregion

        #region Constructor
<<<<<<< HEAD
<<<<<<< HEAD
        public Product(decimal price)
        {
            ProductCode = ++lastProductCode;
            ProductPrice=price;
=======
        /// <summary>
        /// Constructs a product 
        /// </summary>
        /// <param name="price">Price</param>
        public Product(decimal price)
        {
            ProductCode = ++lastProductCode;
            ProductPrice = price;
>>>>>>> 2329b4a530f3134ed58b1eaab38afa077469dcfa
=======
        /// <summary>
        /// Constructs a product 
        /// </summary>
        /// <param name="price">Price</param>
        public Product(decimal price)
        {
            ProductCode = ++lastProductCode;
            ProductPrice = price;
>>>>>>> 2329b4a530f3134ed58b1eaab38afa077469dcfa
        }
#endregion
   }
   
}
