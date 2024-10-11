using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace prova2_ex7
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Middleware1: Incoming Request\n");

                await next();

                await context.Response.WriteAsync("Middleware1: Outgoing Response\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Middleware2: Incoming Request\n");

                await next();

                await context.Response.WriteAsync("Middleware2: Outgoing Response\n");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Middleware3: Incoming Request handle and response generated\n");
            });
        }
    }
}
