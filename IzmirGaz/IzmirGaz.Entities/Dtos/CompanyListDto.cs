using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace IzmirGaz.Entities.Dtos
{
  public  class CompanyListDto:DtoGetBase
    {
        public  IList<Company> Companies { get; set; }
    }
}
