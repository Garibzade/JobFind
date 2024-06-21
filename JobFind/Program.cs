using JobFind.DAL;
using JobFind.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JobFind
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<JobFindContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            var app = builder.Build();

           
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapControllerRoute("areas", "{area:exists}/{controller=Admin}/{action=Index}/{id?}");


            app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
