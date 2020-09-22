using JsonApiDotNetCore.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiJADNC.Data;
using WebApiJADNC.Models;

namespace WebApiJADNC
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Environment = environment;

            var builder = new ConfigurationBuilder()
           .SetBasePath(environment.ContentRootPath)
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
           .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true)
           .AddJsonFile("appsettings.local.json", optional: true) // Per developer file. 
           .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")));

            services.AddJsonApi<AppDbContext>(
                options => options.Namespace = "api");
        }

        public void Configure(IApplicationBuilder app, AppDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            CreateSampleData(context);

            app.UseRouting();
            app.UseJsonApi();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }

        private static void CreateSampleData(AppDbContext context)
        {
            context.Articles.AddRange(new Article
            {
                Title = "What's new in JsonApiDotNetCore",
                Author = new Person
                {
                    Name = "John Doe"
                }
            }, new Article
            {
                Title = ".NET Core Best Practices",
                Author = new Person
                {
                    Name = "Microsoft"
                }
            });

            context.SaveChanges();
        }
    }
}
