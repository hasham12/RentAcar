using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBMS_Project.Models
{
    public partial class CarMake
    {
        public CarMake()
        {
            this.CarInfoes = new HashSet<CarInfo>();
        }

        public int MakeNameID { get; set; }
        public string MakeName { get; set; }

        public virtual ICollection<CarInfo> CarInfoes { get; set; }
    }
}