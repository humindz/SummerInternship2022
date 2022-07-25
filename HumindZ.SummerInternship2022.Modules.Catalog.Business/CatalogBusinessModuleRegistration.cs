using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HumindZ.SummerInternship2022.Modules.Catalog.Business
{
    public static class CatalogBusinessModuleRegistration
    {
        public static void AddCatalogDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CatalogContext>(options => options.UseSqlServer(configuration.GetConnectionString("HumindZSummerInternship2022ConnectionString")));
        }
    }
}
