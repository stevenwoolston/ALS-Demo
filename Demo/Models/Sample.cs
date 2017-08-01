using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Sample
    {
        public string SampleID { get; set; }
        public string DateSampled { get; set; }
        public string SIFNo { get; set; }
        public string Severity { get; set; }
        public string DateDiagnosed { get; set; }
        public string ProblemCode { get; set; }
        public string UnitType { get; set; }
        public string UnitLocation { get; set; }
        public string UnitID { get; set; }
        public string UnitDescription { get; set; }
        public string UIN { get; set; }
        public string LabNumber { get; set; }
    }
}