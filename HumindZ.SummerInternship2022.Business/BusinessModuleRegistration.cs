﻿using HumindZ.SummerInternship2022.Business.Repositories.ProductDocumentDocumentationLinksRepository;
using HumindZ.SummerInternship2022.Business.Repositories.ProductDocumentExamplesRepository;
using HumindZ.SummerInternship2022.Business.Repositories.ProductRepository;
using HumindZ.SummerInternship2022.Business.Repositories.UserRepository;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HumindZ.SummerInternship2022.Business
{
    public static class BusinessModuleRegistration
    {
        public static void AddBusinessModule(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductDocumentExamplesRepository, ProductDocumentExamplesRepository>();
            services.AddScoped<IProductDocumentDocumentationLinksRepository, ProductDocumentDocumentationLinksRepository>();
        }

        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("HumindZSummerInternship2022ConnectionString")));
        }
    }
}
