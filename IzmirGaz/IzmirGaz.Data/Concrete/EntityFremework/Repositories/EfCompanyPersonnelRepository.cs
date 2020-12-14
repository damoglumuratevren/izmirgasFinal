using IzmirGaz.Data.Abstract;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace IzmirGaz.Data.Concrete.EntityFremework.Repositories
{
   public class EfCompanyPersonnelRepository: EfEntityRepositoryBase<CompanyPersonnel>,ICompanyPersonnelRepository
    {
        public EfCompanyPersonnelRepository(DbContext context) : base(context)
        {
        }
    }
}
