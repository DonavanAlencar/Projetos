using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TorredeHanoi.Application.Interfaces;
using TorredeHanoi.Application.Services;
using TorredeHanoi.Domain.Interfaces;
using TorredeHanoi.Domain.Repository;
using TorredeHanoi.Infra.Data.Context;
using TorredeHanoi.Infra.Data.Repositories;

namespace TorredeHanoi.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IMoveCalculatorAppService, MoveCalculatorAppService>();
            services.AddScoped<ILogRepository, LogRepository>();
            services.AddScoped<ILogAppService, LogAppService>();
            services.AddScoped<EventStoreSQLContext>();
            services.AddMemoryCache();
        }
    }
}
