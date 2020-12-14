using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Shared.Entities.Abstract;

namespace IzmirGaz.Entities.Dtos
{
    public class CompanyPersonnelDto:DtoGetBase
    {
        public CompanyPersonnel CompanyPersonnel { get; set; }
    }
}
