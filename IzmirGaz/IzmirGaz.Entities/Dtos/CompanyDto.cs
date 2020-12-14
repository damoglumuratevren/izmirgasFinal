using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Shared.Entities.Abstract;

namespace IzmirGaz.Entities.Dtos
{
  public  class CompanyDto:DtoGetBase
    {
        public Company Company { get; set; }
    }
}
