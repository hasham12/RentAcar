//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerInfo
    {
        public CustomerInfo()
        {
            this.Rentals = new HashSet<Rental>();
        }
    
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCNIC { get; set; }
        public int CustTypeId { get; set; }
    
        public virtual CustomerType CustomerType { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}