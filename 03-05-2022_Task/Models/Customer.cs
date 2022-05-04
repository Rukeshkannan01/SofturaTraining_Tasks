using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdoMVC_03.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string ContactNo { get; set; }
    }
}
