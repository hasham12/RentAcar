using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBMS_Project.Models
{
    public partial class CustomerInfo
    {
        public CustomerInfo()
        {
            this.Rentals = new HashSet<Rental>();
        }

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public decimal CustomerCNIC { get; set; }
        public int CustomerTypeID { get; set; }

        public virtual CustomerType CustomerType { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}