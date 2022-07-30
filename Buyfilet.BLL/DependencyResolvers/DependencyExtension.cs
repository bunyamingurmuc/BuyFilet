using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.BLL.Interfaces;
using Buyfilet.BLL.Services;
using Buyfilet.BLL.ValidationRules;
using Buyfilet.BLL.ValidationRules.Category;
using Buyfilet.BLL.ValidationRules.Comment;
using Buyfilet.BLL.ValidationRules.Image;
using Buyfilet.DAL.Contexts;
using Buyfilet.DAL.UnitOfWork;
using Buyfilet.DTOs;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Buyfilet.BLL.DependencyResolvers
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<BuyfiletContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });
            services.AddScoped<IUOW, UOW>();
            services.AddScoped<IBFUserService, BFUserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICommentService, CommentService>();

            services.AddTransient<IValidator<BFUserCreateDto>, BFUserCreateDtoValidator>();
            services.AddTransient<IValidator<BFUserLoginDto>, BFUserLoginDtoValidator>();
            services.AddTransient<IValidator<BFUserUpdateDto>, BFUserUpdateDtoValidator>();

            services.AddTransient<IValidator<ProductCreateDto>, ProductCreateDtoValidator>();
            services.AddTransient<IValidator<ProductUpdateDto>, ProductUpdateDtoValidator>();
            services.AddTransient<IValidator<BFUserUpdateDto>, BFUserUpdateDtoValidator>();

            services.AddTransient<IValidator<CategoryCreateDto>, CategoryCreateDtoValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateDtoValidator>();

            services.AddTransient<IValidator<ImageCreateDto>, ImageCreateDtoValidator>();
            services.AddTransient<IValidator<ImageUpdateDto>, ImageUpdateDtoValidator>();

            services.AddTransient<IValidator<CommentCreateDto>, CommentCreateDtoValidator>();
            services.AddTransient<IValidator<CommentUpdateDto>, CommentUpdateDtoValidator>();



        }
    }
}
