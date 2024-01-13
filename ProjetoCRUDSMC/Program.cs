using Microsoft.EntityFrameworkCore;
using ProjetoCRUDSMC.Data;

namespace ProjetoCRUDSMC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<VendaContext>(options => options.UseSqlServer("Server=localhost\\sqlexpress;Initial Catalog=Vendas;Integrated Security=True;TrustServerCertificate=True"));
            builder.Services.AddDbContext<RelatorioFuncionarioContext>(options => options.UseSqlServer("Server=localhost\\sqlexpress;Initial Catalog=RelatorioFuncionario;Integrated Security=True;TrustServerCertificate=True"));

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}