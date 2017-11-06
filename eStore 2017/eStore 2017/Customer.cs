using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{

    /// <summary>
    /// customer details
    /// </summary>

    public class Customer
    {
        private static int lastCustomerId = 0;

        #region Properties

        /// <summary>
        /// Customer's identification number
        /// </summary>
        [Key]       
        public int CustomerId { get; private set; }

        /// <summary>
        /// Customer's first name
        /// </summary>
        [Required]
        [StringLength(20,ErrorMessage = "Name cannot be more than 20 charachters")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Customer's last name
        /// </summary>
        [Required]
        [StringLength(25, ErrorMessage = "Last name cannot be more than 25 charachters")]
        public string LastName { get; set; }

        /// <summary>
        /// This the customer's email address
        /// </summary>
        [Required] 
        [StringLength(50, ErrorMessage = "Email address cannot be more than 50 charachters")]
        public string EmailAddress { get; set; }
        
        #endregion

        #region Constructors

        public Customer()
        {
            CustomerId = ++lastCustomerId;
        }

        #endregion
    }

}
