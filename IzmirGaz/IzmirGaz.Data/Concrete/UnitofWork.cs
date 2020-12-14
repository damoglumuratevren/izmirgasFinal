using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IzmirGaz.Data.Abstract;
using IzmirGaz.Data.Concrete.EntityFremework.Contexts;
using IzmirGaz.Data.Concrete.EntityFremework.Repositories;

namespace IzmirGaz.Data.Concrete
{
   public class UnitofWork:IUnitofWork
   {
       private readonly IzmirGazContext _context;
       private EfCompanyRepository _companyRepository;
       private EfCompanyPersonnelRepository _companyPersonnelRepository;
       

       public UnitofWork(IzmirGazContext context)
       {
           _context = context;
       }
       public ICompanyRepository Companies => _companyRepository ?? new EfCompanyRepository(_context);

       public ICompanyPersonnelRepository CompanyPersonnels =>
           _companyPersonnelRepository ?? new EfCompanyPersonnelRepository(_context);
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();

        }
   }
}
