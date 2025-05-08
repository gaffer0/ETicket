using ECommerce_YT.Data;
using ECommerce_YT.Data.Services;
using Microsoft.EntityFrameworkCore;
using static ECommerce_YT.Data.AppDbIntializer;


namespace ECommerce_YT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(
                   builder.Configuration.GetConnectionString("cs")
               )
           );
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IActorService, ActorService>();


            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // Seed the database
            AppDbInitializer.seed(app);

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

        }
    }
}
