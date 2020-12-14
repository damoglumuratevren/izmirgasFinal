using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Shared.Entities.Abstract;

namespace IzmirGaz.Entities.Concrete
{
  public  class CompanyPersonnel:EntityBase,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public string PersonelType { get; set; }

        public string PersonelImg { get; set; }


        public string PersonelEmail { get; set; }
        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
