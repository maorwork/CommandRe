using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OnlineStore.Data;
using OnlineStore.Data.Repositories.Interfaces;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using OnlineStore.Data.UnitOfWork;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OnlineStore.Domain.Users;
using OnlineStore.Data.Repositories;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.API
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            _config = builder.Build();
            _env = env;
        }

        private IConfigurationRoot _config { get; }
        private IHostingEnvironment _env { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_config);

            services.AddDbContext<OnlineStoreContext>
                (options => options.UseSqlServer(
                    _config.GetConnectionString("OnlineStore")), ServiceLifetime.Scoped);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
            services.AddScoped<IShoppingCartItemRepository, ShoppingCartItemRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IUserAddressRepository, UserAddressRepository>();

            services.AddTransient<OnlineStoreInitialData>();
            services.AddTransient<OnlineStoreIdentityInitialData>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAutoMapper();

            services.AddIdentity<User, UserRole>(config =>
            {
                config.User.RequireUniqueEmail = true;
                config.Password.RequiredLength = 8;
            })
            .AddEntityFrameworkStores<OnlineStoreContext, int>()
            .AddUserStore<UserStore<User, UserRole, OnlineStoreContext, int>>()
            .AddRoleStore<RoleStore<UserRole, OnlineStoreContext, int>>()
            .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(config =>
            {
                config.Cookies.ApplicationCookie.Events =
                  new CookieAuthenticationEvents()
                  {
                      OnRedirectToLogin = (ctx) =>
                      {
                          if (ctx.Request.Path.StartsWithSegments("/api") && ctx.Response.StatusCode == 200)
                          {
                              ctx.Response.StatusCode = 401;
                          }

                          return Task.CompletedTask;
                      },
                      OnRedirectToAccessDenied = (ctx) =>
                      {
                          if (ctx.Request.Path.StartsWithSegments("/api") && ctx.Response.StatusCode == 200)
                          {
                              ctx.Response.StatusCode = 403;
                          }

                          return Task.CompletedTask;
                      }
                  };
            });

            services.AddCors(cfg =>
            {
                cfg.AddPolicy("CommandRe", bldr =>
                {
                    bldr.AllowAnyHeader()
                        .AllowAnyMethod()
                        .WithOrigins("http://CommandRe.com");
                });

                cfg.AddPolicy("AnyGET", bldr =>
                {
                    bldr.AllowAnyHeader()
                        .WithMethods("GET")
                        .AllowAnyOrigin();
                });
            });

            services.AddAuthorization(cfg =>
            {
                cfg.AddPolicy("Admin", p => p.RequireClaim("Admin", "True"));
            });

            // Add framework services.
            services.AddMvc(opt =>
            {
                if (!_env.IsProduction())
                {
                    opt.SslPort = 44388;
                }
                opt.Filters.Add(new RequireHttpsAttribute());
            })
              .AddJsonOptions(opt =>
              {
                  opt.SerializerSettings.ReferenceLoopHandling =
                        ReferenceLoopHandling.Ignore;
              });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(_config.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
