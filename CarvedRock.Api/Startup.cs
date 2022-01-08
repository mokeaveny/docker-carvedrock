using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using CarvedRock.Api.Domain;
using CarvedRock.Api.Interfaces;
using CarvedRock.Api.Middleware;
using CarvedRock.Api.Integrations;
using Serilog;

namespace CarvedRock.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("Db");
            var simpleProperty = Configuration.GetValue<string>("SimpleProperty");
            var nestedProp = Configuration.GetValue<string>("Inventory:NestedProperty");

            Log.ForContext("ConnectionString", connectionString)
                .ForContext("SimpleProperty", simpleProperty)
                .ForContext("Inventory:NestedProperty", nestedProp)
                .Information("Loaded configuration!", connectionString);

            var dbgView = (Configuration as IConfigurationRoot).GetDebugView();
            Log.ForContext("ConfigurationDebug", dbgView)
                .Information("Configuration dump.");

            services.AddScoped<IProductLogic, ProductLogic>();
            services.AddScoped<IQuickOrderLogic, QuickOrderLogic>();
            services.AddSingleton<IOrderProcessingNotification, OrderProcessingNotification>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarvedRock.Api", Version = "v1" });
                // Test comment
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<CustomExceptionHandlingMiddleware>();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarvedRock.Api v1"));
            }

            app.UseCustomRequestLogging();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
