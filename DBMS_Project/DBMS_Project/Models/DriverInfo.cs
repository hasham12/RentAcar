using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBMS_Project.Models
{
    public partial class DriverInfo
    {
        public DriverInfo()
        {
            this.Rentals = new HashSet<Rental>();
        }

        public int DriverID { get; set; }
        public string DriverName { get; set; }
        public decimal DriverCharges { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}