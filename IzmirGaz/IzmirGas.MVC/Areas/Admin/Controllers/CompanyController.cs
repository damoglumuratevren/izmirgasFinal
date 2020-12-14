using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IzmirGas.Services.Abstract;
using IzmirGaz.Shared.Utilities.Results.ComplexTypes;

namespace IzmirGas.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<IActionResult> Index()
        {

            var result = await _companyService.GetAll();
            return View(result.Data);
        }
    }
}
