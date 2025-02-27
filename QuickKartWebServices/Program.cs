using AutoMapper; // Add this namespace
using Microsoft.EntityFrameworkCore; // Add this namespace
using QuickKartDataAccessLayer;
using QuickKartDataAccessLayer.Models; // Add this namespace for QuickKartDBContext and QuickKartRepository

namespace QuickKartWebServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Configure AutoMapper
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile()); // MappingProfile should be defined in your project
            });
            IMapper mapper = mappingConfig.CreateMapper();
            builder.Services.AddSingleton(mapper);

            // Register QuickKartRepository with DbContext
            builder.Services.AddSingleton<QuickKartRepository>(
                new QuickKartRepository(
                    new QuickKartDBContext(
                        new DbContextOptionsBuilder<QuickKartDBContext>()
                            .UseSqlServer(builder.Configuration.GetConnectionString("QuickKartDBConnectionString"))
                            .Options)));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
