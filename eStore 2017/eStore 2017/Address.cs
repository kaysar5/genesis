using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore

{
    #region Properties
    /// <summary>
    /// Customer's address
    /// </summary>
    class Address

    {
        public int HouseNumber { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string StateName { get; set; }
        public int Zipcode { get; set; }
        #endregion
    }
}
