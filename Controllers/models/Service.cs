//using AutoMapper.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace test_project.Controllers.models
{
    public static class Service
    {


        public static void addserv(this IServiceCollection serv, IConfiguration Configuration)
        {
            serv.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnecetion")));
            serv.AddControllers();
            serv.AddScoped<IUserRepo, UserRepo>();
            serv.AddScoped<IPostRepo, PostRepo>();
            serv.AddAutoMapper(typeof(Startup));

            serv.AddSwaggerGen(Options =>
            {
                Options.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = "swagger apu",
                        Description = "api swagger",
                        Version = "v1"

                    });

            });
        }

    } }
