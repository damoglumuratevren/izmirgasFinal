using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Shared.Entities.Abstract;

namespace IzmirGaz.Entities.Concrete
{
   public class Company:EntityBase,IEntity
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public DateTime VisaDuration { get; set; }
        public DateTime CompanyCertificateEndDate { get; set; }

        public string CompanyCountry { get; set; }
        public string CompanyPhoneNumber { get; set; }

        public string Email{ get; set; }
        public string CompanyManagerFirstName{ get; set; }

        public string CompanyManagerLastName { get; set; }

        public string CompanyManagerPhoneNumber { get; set; }

        public double CompanyPerformanceReport { get; set; } = 0;

        public double PercentageOfGasFired { get; set; } = 0;

        public ICollection<CompanyPersonnel> CompanyPersonnels { get; set; }
    }
}
