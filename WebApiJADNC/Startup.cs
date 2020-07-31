using JsonApiDotNetCore;
using JsonApiDotNetCore.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiJADNC.Data;
using WebApiJADNC.Models;

namespace WebApiJADNC
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
           options.UseSqlite("Data Source=sample.db"));

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
