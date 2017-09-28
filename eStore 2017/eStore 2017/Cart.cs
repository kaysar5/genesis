using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{/// <summary>
/// number of items that the cart contains
/// </summary>
    class Cart
    {
        public int TotalItems { get; set; }
        public int AddItems { get; set; }
        public int RemoveItems { get; set; }
    }
}
