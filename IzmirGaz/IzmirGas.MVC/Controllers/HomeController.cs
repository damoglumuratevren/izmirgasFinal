using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IzmirGas.Services.Abstract;
using IzmirGaz.Shared.Utilities.Results.ComplexTypes;

namespace IzmirGas.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICompanyService _companyService;

        public HomeController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async  Task<IActionResult> Index()
        {
           // var result = await _companyService.GetCompanyByNonDeletedAndActive(2);
            var result = await _companyService.GetAllByNonDeletedAndActive();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }
    }
}
