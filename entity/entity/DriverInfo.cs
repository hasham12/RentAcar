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
    
    public partial class DriverInfo
    {
        public DriverInfo()
        {
            this.Rentals = new HashSet<Rental>();
        }
    
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public double DriverCharges { get; set; }
    
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
