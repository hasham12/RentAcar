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
    
    public partial class CarMake
    {
        public CarMake()
        {
            this.CarInfoes = new HashSet<CarInfo>();
        }
    
        public int MakeNameId { get; set; }
        public string MakeName { get; set; }
    
        public virtual ICollection<CarInfo> CarInfoes { get; set; }
    }
}
