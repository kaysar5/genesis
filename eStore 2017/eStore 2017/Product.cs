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
        /// Whether the item is available or not
        /// </summary>
        public bool IsActive { get;  }
        public decimal ProductPrice { get; private set; }


        #endregion

        #region Constructor
        public Product()
        {
            ProductCode = ++lastProductCode;
        }
#endregion

    }
   
}
