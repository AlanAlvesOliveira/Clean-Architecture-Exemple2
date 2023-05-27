using _3_Infra.Data.Context;
using _4_Infrastructure.Ioc;
using Microsoft.EntityFrameworkCore;

namespace _5_Web
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region Services
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            builder.Services.AddDbContext<ApplicationContext>(
                option => option.UseSqlServer(
                    builder.Configuration.GetConnectionString("app"), o => o.CommandTimeout(3000)
                )
            );
                 
            builder.Services.RegistradorDeServicos();
            #endregion


            #region App
            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpints =>
            {
                endpints.MapControllerRoute(name: "default", pattern:"{controller=Home}/{action=Index}");
            });

            app.Run();
            #endregion
        }
    }
}