using IzmirGaz.Data.Abstract;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace IzmirGaz.Data.Concrete.EntityFremework.Repositories
{
    public  class EfCompanyRepository:EfEntityRepositoryBase<Company>,ICompanyRepository
    {
        public EfCompanyRepository(DbContext context) : base(context)
        {

        }
    }
}
