using System;
using System.Collections.Generic;
using System.Text;
using IzmirGas.Services.Abstract;
using IzmirGas.Services.Concrete;
using IzmirGaz.Data.Abstract;
using IzmirGaz.Data.Concrete;
using IzmirGaz.Data.Concrete.EntityFremework.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace IzmirGas.Services.Extensions
{
   public static  class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<IzmirGazContext>();
            serviceCollection.AddScoped<IUnitofWork, UnitofWork>();
            serviceCollection.AddScoped<ICompanyService, CompanyManager>();
            serviceCollection.AddScoped<ICompanyPersonelService, CompanyPersonnelManager>();
            return serviceCollection;
        }
    }
}
