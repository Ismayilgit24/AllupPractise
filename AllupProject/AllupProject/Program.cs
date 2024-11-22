using AllupProject.DAL;
using Microsoft.EntityFrameworkCore;

namespace AllupProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(
                opt => opt.UseSqlServer("server=DESKTOP-NKLQH71\\SQLEXPRESS;database=AllupBP217;trusted_connection=true;integrated security=true;TrustServerCertificate=true;")

                );
            var app = builder.Build();

            app.UseStaticFiles();
           
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=index}/{id?}"
                );
            app.Run();
        }
    }
}
