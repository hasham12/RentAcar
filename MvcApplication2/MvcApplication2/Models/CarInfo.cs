//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarInfo
    {
        public CarInfo()
        {
            this.Rentals = new HashSet<Rental>();
        }
    
        public int CarId { get; set; }
        public string CarModel { get; set; }
        public string EngineNo { get; set; }
        public string ChasisNo { get; set; }
        public string PlateNo { get; set; }
        public string RegistrationYear { get; set; }
        public decimal RentCharges { get; set; }
        public decimal RentChargesKm { get; set; }
        public int MakeNameID { get; set; }
    
        public virtual CarMake CarMake { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
