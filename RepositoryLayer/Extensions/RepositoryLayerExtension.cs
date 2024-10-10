using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Context;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.Repositories.Concrete;
using RepositoryLayer.UnitOfwork.Abstract;
using RepositoryLayer.UnitOfwork.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Extensions
{
    public static class RepositoryLayerExtension
    {
     public static IServiceCollection LoadRepositoryLayerExtension(this IServiceCollection services,IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(option => option.UseSqlServer
            (configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IGenericRepositories<>), typeof(GenericRepositories<>));
            services.AddScoped<IUnitOfWork,UnitOfWork>();

            return services;
        }
    }
}
