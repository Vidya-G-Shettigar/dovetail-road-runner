using Agents.VictorInsurance.BuildingBlocks.Bootstrapper.SwaggerRegistration;
using Agents.VictorInsurance.BuildingBlocks.Bootstrappper.CorsRegistration;
using Agents.VictorInsurance.BuildingBlocks.Model.Cors;
using Agents.VictorInsurance.BuildingBlocks.Model.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Agents.VictorInsurance.GenericRepository.Bootstrapper;


namespace Agents.VictorInsurance.Api.Services
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var configBuilder = new ConfigurationBuilder()
                   .AddJsonFile("appsettings.Services.json",
                               optional: false,
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
            RegisterServices(services);
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
            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("swagger/" + swaggerDetails.Version + "/swagger.json", swaggerDetails.ApiName);
                config.RoutePrefix = string.Empty;
            });
        }
        private void AddSwaggerConfig(IServiceCollection serviceCollection)
        {
            var test = Configuration.GetSection("SwaggerDetails").Get<SwaggerDetails>();
            SwaggerRegistration.RegisterSwaggerServices(serviceCollection, Configuration.GetSection("SwaggerDetails").Get<SwaggerDetails>());
        }

        private void AddCors(IServiceCollection serviceCollection)
        {
            var corsDetails = Configuration.GetSection("Cors").Get<CorsDetails>();
            if (string.Equals(corsDetails.Default, "true", System.StringComparison.InvariantCultureIgnoreCase))
                CorsRegistration.RegisterDefaultCors(serviceCollection);
            else
                CorsRegistration.RegisterCorsWithOrigins(serviceCollection, corsDetails.Uri);
        }
        
        private void RegisterServices(IServiceCollection serviceCollection)
        {
            GenericRepositoryRegistration.RegisterGenericRepository(serviceCollection);

            Agents.VictorInsurance.Business.ApiProvider.Services.Bootstrapper.ServiceRegistration.RegisterServices(serviceCollection);
            Agents.VictorInsurance.Business.ApiProvider.Repository.Bootstrapper.RepositoryRegistration.RegisterRepository(serviceCollection);
            Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Bootstrapper.MapperRegistration.RegisterMapperProfiles(serviceCollection);
            
            Agents.VictorInsurance.Business.Policy.Services.Boostrapper.ServiceRegistration.RegisterServices(serviceCollection);
            Agents.VictorInsurance.Business.Policy.Repository.Boostrapper.RepositoryRegistration.RegisterRepository(serviceCollection);
            Agents.VictorInsurance.Business.Policy.Infrastructure.Bootstrapper.MapperRegistration.RegisterMapperProfiles(serviceCollection);

            Agents.VictorInsurance.Business.Quote.Services.Bootstrapper.ServiceRegistration.RegisterServices(serviceCollection);
            Agents.VictorInsurance.Business.Quote.Repository.Bootstrapper.RepositoryRegistration.RegisterRepository(serviceCollection);
            Agents.VictorInsurance.Business.Quote.Infrastructure.Bootstrapper.MapperRegistration.RegisterMapperProfiles(serviceCollection);

            Agents.VictorInsurance.Business.Questionnaire.Infrastructure.Bootstrapper.MapperRegistration.RegisterMapperProfiles(serviceCollection);
            Agents.VictorInsurance.Questionnaire.Proposal.Services.Bootstrapper.ServiceRegistration.RegisterServices(serviceCollection);
            Agents.VictorInsurance.Business.Questionnaire.Repository.Bootstrapper.RepositoryRegistration.RegisterRepository(serviceCollection);
        
            Agents.VictorInsurance.Business.Proposal.Services.Bootstrapper.ServiceRegistration.RegisterServices(serviceCollection);
            Agents.VictorInsurance.Business.Proposal.Repository.Bootstrapper.RepositoryRegistration.RegisterRepository(serviceCollection);
            Agents.VictorInsurance.Business.Proposal.Infrastructure.Bootstrapper.MapperRegistration.RegisterMapperProfiles(serviceCollection);
        
        }
    }
}
