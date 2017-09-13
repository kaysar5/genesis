using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore_2017
{
    #region Properties
    /// <summary>
    /// Product Details
    /// </summary>
    class Product
    {
        /// <summary>
        /// Product's name
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Product's code number
        /// </summary>
        public int ItemCode { get; set; }
        /// <summary>
        /// Whether the item is available or not
        /// </summary>
        public bool InStock { get; set; }
        /// <summary>
        /// Manufacturing date
        /// </summary>
        public DateTime LaunchDate { get; set; }
        #endregion


    }
}
