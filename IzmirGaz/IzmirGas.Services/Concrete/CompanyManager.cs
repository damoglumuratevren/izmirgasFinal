using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IzmirGas.Services.Abstract;
using IzmirGaz.Data.Abstract;
using IzmirGaz.Entities.Concrete;
using IzmirGaz.Entities.Dtos;
using IzmirGaz.Shared.Utilities.Results.Abstract;
using IzmirGaz.Shared.Utilities.Results.ComplexTypes;
using IzmirGaz.Shared.Utilities.Results.Concrete;

namespace IzmirGas.Services.Concrete
{
  public  class CompanyManager:ICompanyService
  {
      private readonly IUnitofWork _unitOfWork;
      private readonly IMapper _mapper;

      public CompanyManager(IUnitofWork unitOfWork, IMapper mapper)
      {
          _unitOfWork = unitOfWork;
          _mapper = mapper;
      }

      public async Task<IDataResult<CompanyDto>> Get(int companyId)
      {
         var company= await _unitOfWork.Companies.GetAsync(c => c.Id == companyId,c=>c.CompanyPersonnels);
         if (company != null)
         {
             return new DataResult<CompanyDto>(ResultStatus.Success, new CompanyDto
             {
                 Company = company,
                 ResultStatus = ResultStatus.Success
             });
         }
         return new DataResult<CompanyDto>(ResultStatus.Error, "Böyle bir şirket bulunamadı",null);
      }

        public async Task<IDataResult<CompanyListDto>> GetCompanyByNonDeletedAndActive(int companyId)
        {
            var company = await _unitOfWork.Companies.GetAllAsync(c => c.Id == companyId, c => !c.IsDeleted && c.IsActive, c => c.CompanyPersonnels);
            if (company != null)
            {
                return new DataResult<CompanyListDto>(ResultStatus.Success, new CompanyListDto
                {
                    Companies = company,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompanyListDto>(ResultStatus.Error, "Böyle bir şirket bulunamadı", null);
        }


        public async Task<IDataResult<CompanyListDto>> GetAll()
        {
            var companies = await _unitOfWork.Companies.GetAllAsync(null, c => c.CompanyPersonnels);
            if (companies.Count > -1)
            {
                return  new DataResult<CompanyListDto>(ResultStatus.Success, new CompanyListDto
                {
                    Companies = companies,
                    ResultStatus = ResultStatus.Success
                  //  Message = "Hiç bir şirket bulunamadı"
                });
            }
            return  new DataResult<CompanyListDto>(ResultStatus.Error,"Hiç bir şirket bulunamadı",new CompanyListDto
            {
                Companies = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hiç bir şirket bulunamadı"
            });

        }

        public async Task<IDataResult<CompanyListDto>> GetAllByNonDeleted()
        {
            var companies = await _unitOfWork.Companies.GetAllAsync(c=>!c.IsDeleted,c=>c.CompanyPersonnels);
            if (companies.Count > -1)
            {
                return new DataResult<CompanyListDto>(ResultStatus.Success,new CompanyListDto
                {
                    Companies = companies,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompanyListDto>(ResultStatus.Error, "Hiç bir şirket bulunamadı", null);
        }

        public async Task<IDataResult<CompanyListDto>> GetAllByNonDeletedAndActive()
        {
            var companies = await _unitOfWork.Companies.GetAllAsync(c => !c.IsDeleted&&c.IsActive, c => c.CompanyPersonnels);
            if (companies.Count > -1)
            {
                return new DataResult<CompanyListDto>(ResultStatus.Success, new CompanyListDto
                {
                    Companies = companies,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompanyListDto>(ResultStatus.Error, "Hiç bir şirket bulunamadı", null);
        }

        public async Task<IResult> Add(CampanyAddDto campanyAddDto, string createdByName)
        {
            var company = _mapper.Map<Company>(campanyAddDto);    
                company.CreatedByName=createdByName;
                company.ModifiedByName=createdByName;
                await _unitOfWork.Companies.AddAsync(company);
                await _unitOfWork.SaveAsync();
        return new Result(ResultStatus.Success,$"{campanyAddDto.CompanyName} adlı şirket basarılı bir şekilde eklenmiştir.");
        }

        public async Task<IResult> Update(CompanyUpdateDto companyUpdateDto, string modifieldByName)
        {
            var company = _mapper.Map<Company>(companyUpdateDto);
            company.ModifiedByName = modifieldByName;
            await _unitOfWork.Companies.UpdateAsync(company);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{companyUpdateDto} adlı şirket basarılı bir şekilde güncellenmiştir...");

        }

        public async Task<IResult> Delete(int companyId, string modifieldByName)
        {
            var company = await _unitOfWork.Companies.GetAsync(c => c.Id == companyId);
            if (company != null)
            {
                company.IsDeleted = true;
                company.ModifiedByName = modifieldByName;
                company.ModifiedDate=DateTime.Now;
                await _unitOfWork.Companies.UpdateAsync(company);
                await _unitOfWork.SaveAsync();
                return  new Result(ResultStatus.Success, $"{company.CompanyName} adlı şirket basarılı bir şekilde silinmiştir...");
            }
            return new Result(ResultStatus.Error, "Böyle bir şirket bulunamadı");
        }

        public async Task<IResult> HardDelete(int companyId)
        {
            var company = await _unitOfWork.Companies.GetAsync(c => c.Id == companyId);
            if (company != null)
            {

                await _unitOfWork.Companies.DeleteAsync(company);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{company.CompanyName} adlı şirket basarılı bir şekilde tamamıyle  silinmiştir...");
            }
            return new Result(ResultStatus.Error, "Böyle bir şirket bulunamadı");
        }


    }
}
