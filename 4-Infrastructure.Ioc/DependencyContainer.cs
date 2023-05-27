﻿using _1_Domain.Entities.Tables;
using _1_Domain.Interfaces;
using _2_Application.Interfaces;
using _2_Application.Services;
using _3_Infra.Data.Context;
using _3_Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace _4_Infrastructure.Ioc
{
    public static class DependencyContainer
    {
        public static void RegistradorDeServicos(this IServiceCollection services)
        {
            //Application
            services.AddScoped<IHomeService, HomeService>();

            //Repositories
            services.AddScoped<IQueryRepository<TableExample>, QueryRepository<TableExample, ApplicationContext>>();


        }
    }
}
