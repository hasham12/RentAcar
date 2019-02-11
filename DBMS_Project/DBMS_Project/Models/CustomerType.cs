using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBMS_Project.Models
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            this.CustomerInfoes = new HashSet<CustomerInfo>();
        }

        public int CustomerTypeID { get; set; }
        public string CustomerTypeName { get; set; }
        public int Discount { get; set; }

        public virtual ICollection<CustomerInfo> CustomerInfoes { get; set; }
    }
}