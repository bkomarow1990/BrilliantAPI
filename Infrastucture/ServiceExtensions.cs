using System;
using Core.Data;
using Core.Interfaces;
using Core.Services;
using Core.Validation;
using Infrastructure.Data;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceExtensions
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
        }
        public static void AddUnitOfWork(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
        }
        public static void AddFluentValidation(this IServiceCollection services)
        {
            services.AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<CategoryValidator>());
            services.AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<ProductValidator>());
            //services.AddTransient<IValidator<GenreDTO>, GenreValidator>();
        }
    }
}
