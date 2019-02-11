using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBMS_Project.Models
{
    public partial class PickLocation
    {
        public PickLocation()
        {
            this.Rentals = new HashSet<Rental>();
        }

        public int LocationID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PickAddress { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}