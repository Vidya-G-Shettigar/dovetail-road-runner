using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agents.VictorInsurance.BuildingBlocks.Bootstrapper.SwaggerRegistration;
using Agents.VictorInsurance.BuildingBlocks.Bootstrappper.CorsRegistration;
using Agents.VictorInsurance.BuildingBlocks.Model.Cors;
using Agents.VictorInsurance.BuildingBlocks.Model.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using  Agents.VictorInsurance.Business.Documents.Infrastructure.Bootstrapper;
using Agents.VictorInsurance.Business.Documents.Repository.Bootstrapper;
using Agents.VictorInsurance.Business.Documents.Services.Bootstrapper;
using Agents.VictorInsurance.GenericRepository.Bootstrapper;

namespace Agents.VictorInsurance.Api.Documents
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
             var configBuilder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.Documents.json",
                                optional:false, 
                                reloadOnChange: true);
            Configuration = configBuilder.Build();   
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
             AddSwaggerConfig(services);
            AddCors(services);
            RegisterDocumentServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
              app.UseSwagger();

            app.UseCors(options => options.AllowAnyOrigin());

            var swaggerDetails = Configuration.GetSection("SwaggerDetails").Get<SwaggerDetails>();
            app.UseSwaggerUI(config => {
                config.SwaggerEndpoint("swagger/"+swaggerDetails.Version+"/swagger.json", swaggerDetails.ApiName);
                config.RoutePrefix = string.Empty;
            });
        }

          private void AddSwaggerConfig(IServiceCollection serviceCollection)
        {
            var test = Configuration.GetSection("SwaggerDetails").Get<SwaggerDetails>();
            SwaggerRegistration.RegisterSwaggerServices(serviceCollection,Configuration.GetSection("SwaggerDetails").Get<SwaggerDetails>());
        }

        private void AddCors(IServiceCollection serviceCollection)
        {
        var corsDetails = Configuration.GetSection("Cors").Get<CorsDetails>();     
            if(string.Equals(corsDetails.Default,"true", System.StringComparison.InvariantCultureIgnoreCase))
                CorsRegistration.RegisterDefaultCors(serviceCollection);
            else
                CorsRegistration.RegisterCorsWithOrigins(serviceCollection,corsDetails.Uri);
        }

         private void RegisterDocumentServices(IServiceCollection serviceCollection)
        {
            MapperRegistration.RegisterMapperProfiles(serviceCollection);
            RepositoryRegistration.RegisterRepository(serviceCollection);
            ServiceRegistration.RegisterServices(serviceCollection);
            GenericRepositoryRegistration.RegisterGenericRepository(serviceCollection);

        }
    }
}
