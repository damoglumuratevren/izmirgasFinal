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
   public class CompanyPersonnelManager:ICompanyPersonelService
   {

       private readonly IUnitofWork _unitofWork;
       private readonly IMapper _mapper;

       public CompanyPersonnelManager(IUnitofWork unitofWork, IMapper mapper)
       {
           _unitofWork = unitofWork;
           _mapper = mapper;
       }

       public async Task<IDataResult<CompanyPersonnelDto>> Get(int companyPersonnelId)
       {
           var companyPersonel = await _unitofWork.CompanyPersonnels.GetAsync(cp => cp.Id == companyPersonnelId,cp=>cp.Company);
           if (companyPersonel != null)
           {
               return  new DataResult<CompanyPersonnelDto>(ResultStatus.Success,new CompanyPersonnelDto
               {
                   CompanyPersonnel = companyPersonel,
                   ResultStatus = ResultStatus.Success
               });
           }
           return  new DataResult<CompanyPersonnelDto>(ResultStatus.Error,"Böyle Bir personel Bulunamadı.",null);

       }

        public async Task<IDataResult<CompanyPersonnelListDto>> GetAll()
        {
            var companyPersonels = await _unitofWork.CompanyPersonnels.GetAllAsync(null, cp => cp.Company);
            if (companyPersonels.Count > -1)
            {
                return new DataResult<CompanyPersonnelListDto>(ResultStatus.Success,new CompanyPersonnelListDto
                {
                   CompanyPersonnels = companyPersonels,
                     ResultStatus = ResultStatus.Success
                });

            }
            return new DataResult<CompanyPersonnelListDto>(ResultStatus.Error, "Böyle bir şirket bulunamadı", null);
        }

        public async Task<IDataResult<CompanyPersonnelListDto>> GetAllByNonDeleted()
        {
            var companyPersonels = await _unitofWork.CompanyPersonnels.GetAllAsync(cp=>!cp.IsDeleted,cp=>cp.Company);

            if (companyPersonels.Count > -1)
            {
                return new DataResult<CompanyPersonnelListDto>(ResultStatus.Success, new CompanyPersonnelListDto
                {
                    CompanyPersonnels = companyPersonels,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompanyPersonnelListDto>(ResultStatus.Error,"Personel Bulunamadı",null);
        }

        public async Task<IDataResult<CompanyPersonnelListDto>> GetAllByNonDeletedAndActive()
        {
            var companyPersonels = await _unitofWork.CompanyPersonnels.GetAllAsync(cp => !cp.IsDeleted&&cp.IsActive, cp => cp.Company);

            if (companyPersonels.Count > -1)
            {
                return new DataResult<CompanyPersonnelListDto>(ResultStatus.Success, new CompanyPersonnelListDto
                {
                    CompanyPersonnels = companyPersonels,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CompanyPersonnelListDto>(ResultStatus.Error, "Personel Bulunamadı", null);
        }

        public async Task<IDataResult<CompanyPersonnelListDto>> GetAllByCompany(int companyId)
        {
            var result = await _unitofWork.Companies.AnyAsync(c=>c.Id==companyId);
            if (result)
            {
                var companyPersonels = await _unitofWork.CompanyPersonnels.GetAllAsync(cp=>cp.CompanyId==companyId&&!cp.IsDeleted&&cp.IsActive,cp1=>cp1.Company);
                if (companyPersonels.Count > -1)
                {
                    return new DataResult<CompanyPersonnelListDto>(ResultStatus.Success, new CompanyPersonnelListDto
                    {
                        CompanyPersonnels = companyPersonels,
                        ResultStatus = ResultStatus.Success
                    });
                }
                return new DataResult<CompanyPersonnelListDto>(ResultStatus.Error, "Personeller Bulunamadı", null);
            }
            return new DataResult<CompanyPersonnelListDto>(ResultStatus.Error, "şirket  Bulunamadı", null);
        }

        public async Task<IResult> Add(CompanyPersonnelAddDto companyPersonnelAddDto, string createdByName)
        {
            var companyPersonels = _mapper.Map<CompanyPersonnel>(companyPersonnelAddDto);
            companyPersonels.CreatedByName = createdByName;
            companyPersonels.ModifiedByName = createdByName;
            await _unitofWork.CompanyPersonnels.AddAsync(companyPersonels);
            await _unitofWork.SaveAsync();
            return new Result(ResultStatus.Success,$"{companyPersonnelAddDto.FirstName} Adlı personel eklenmiştir.");
        }

        public async Task<IResult> Update(CompanyPersonnelUpdateDto companyPersonnelUpdateDto, string modifieldByName)
        {
            var companyPersonels = _mapper.Map<CompanyPersonnel>(companyPersonnelUpdateDto);
            companyPersonels.ModifiedByName = modifieldByName;
            await _unitofWork.CompanyPersonnels.UpdateAsync(companyPersonels);
            await _unitofWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{companyPersonnelUpdateDto.FirstName} Adlı personel Güncellenmiştir.");
        }

        public  async  Task<IResult> Delete(int companyPersonnelId, string modifieldByName)
        {
            var result = await _unitofWork.CompanyPersonnels.AnyAsync(a => a.Id == companyPersonnelId);
            if (result)
            {
                var companyPersonels = await _unitofWork.CompanyPersonnels.GetAsync(cp => cp.Id == companyPersonnelId);
                companyPersonels.ModifiedByName = modifieldByName;
                companyPersonels.IsDeleted = true;
                companyPersonels.ModifiedDate=DateTime.Now;
                await _unitofWork.CompanyPersonnels.UpdateAsync(companyPersonels);
                await _unitofWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{companyPersonels.FirstName} Adlı personel Silinmiştir..");
            }
            return  new Result(ResultStatus.Error,"Böyle bir personel bulunamadı...");
        }

        public async Task<IResult> HardDelete(int companyPersonnelId)
        {
            var result = await _unitofWork.CompanyPersonnels.AnyAsync(a => a.Id == companyPersonnelId);
            if (result)
            {
                var companyPersonels = await _unitofWork.CompanyPersonnels.GetAsync(cp => cp.Id == companyPersonnelId);
                await _unitofWork.CompanyPersonnels.DeleteAsync(companyPersonels);
                await _unitofWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{companyPersonels.FirstName} Adlı personel hard  Silinmiştir..");
            }
            return new Result(ResultStatus.Error, "Böyle bir personel bulunamadı...");
        }
    }
}
