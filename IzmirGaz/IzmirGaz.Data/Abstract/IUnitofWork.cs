using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IzmirGaz.Data.Abstract
{
   public interface IUnitofWork:IAsyncDisposable
    {
        ICompanyRepository Companies { get; }
        ICompanyPersonnelRepository CompanyPersonnels { get; }


        Task<int> SaveAsync();


    }
}
