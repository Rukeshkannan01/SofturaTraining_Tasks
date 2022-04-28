using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProductEntityFw.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
        public string EmailID { get; set; }
        public string City { get; set; }
    }

}

// Product List
/*
 ProductID int identity(2201,1),
ProductName varchar(50),
Price money,
MfgDate date default getdate(),
ExpDate date   -- dateadd(month,3,MfgDate)
*/

/*
PurchaseDetails
(
BillNo int identity(1111,1),
CustomerID int,
ProductID int,
Quantity int,
TotalAmount int,
BillDate date default getdate()
*/
