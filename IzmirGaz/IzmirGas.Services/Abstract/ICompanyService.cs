using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Entities.Dtos;
using IzmirGaz.Shared.Utilities.Results.Abstract;

namespace IzmirGas.Services.Abstract
{
    public  interface ICompanyService
    {
        Task<IDataResult<CompanyDto>> Get(int companyId);

        Task<IDataResult<CompanyListDto>> GetCompanyByNonDeletedAndActive(int companyId);
        Task<IDataResult<CompanyListDto>> GetAll();

        Task<IDataResult<CompanyListDto>> GetAllByNonDeleted();
        Task<IDataResult<CompanyListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(CampanyAddDto campanyAddDto, string createdByName);

        Task<IResult> Update(CompanyUpdateDto companyUpdateDto, string modifieldByName);

        Task<IResult> Delete(int companyId, string modifieldByName);

        Task<IResult> HardDelete(int companyId);


    }
}
