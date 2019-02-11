using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBMS_Project.Models
{
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