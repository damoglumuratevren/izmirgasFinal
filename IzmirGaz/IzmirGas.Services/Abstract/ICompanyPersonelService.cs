using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Entities.Dtos;
using IzmirGaz.Shared.Utilities.Results.Abstract;

namespace IzmirGas.Services.Abstract
{
  public  interface ICompanyPersonelService
    {
        Task<IDataResult<CompanyPersonnelDto>> Get(int companyPersonnelId);
        Task<IDataResult<CompanyPersonnelListDto>> GetAll();

        Task<IDataResult<CompanyPersonnelListDto>> GetAllByNonDeleted();
        Task<IDataResult<CompanyPersonnelListDto>> GetAllByNonDeletedAndActive();

        Task<IDataResult<CompanyPersonnelListDto>> GetAllByCompany(int companyId);
        Task<IResult> Add(CompanyPersonnelAddDto companyPersonnelAddDto, string createdByName);

        Task<IResult> Update(CompanyPersonnelUpdateDto companyPersonnelUpdateDto, string modifieldByName);

        Task<IResult> Delete(int companyPersonnelId, string modifieldByName);

        Task<IResult> HardDelete(int companyPersonnelId);
    }
}
