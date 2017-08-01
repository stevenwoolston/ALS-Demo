using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Unit
    {
        public string UnitID { get; set; }
        public string SerialNumber { get; set; }
        public string Site { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string YearOfManufacture { get; set; }
    }
}