using Example.MVC.Core.Entities;
using Example.MVC.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Example.MVC.Data
{
    public static class ServiceRegistration
    {
        public static void AddDataArc(this IServiceCollection services)
        {
            services.AddDbContext<ExampleMVCDbContext>(options =>
            {
                options.UseSqlServer(Configuration.ConnectionString);
            });

            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ExampleMVCDbContext>();

            //public void ConfigureServices(IServiceCollection services)
            //{
            //    services.AddDbContext<ExampleMVCDbContext>();
            //    services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ExampleMVCDbContext>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<ExampleMVCDbContext>();
            //    services.AddControllersWithViews();
            //    services.AddMVC(config =>)
            //    {
            //        var policy = new AuthorizationPolicyBuilder()
            //            .RequireAuthenticatedUser()
            //            .Build();
            //        config.Filters.Add(new AuthorizeFilter(policy));
            //    });
            //    services.AddMvc();
            //}
            }
        }
    
}
