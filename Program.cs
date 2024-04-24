
using Microsoft.EntityFrameworkCore;
using AndradeLeonardo_ExamenProgreso1.DatosLeonardoAndrade;
using Microsoft.Extensions.DependencyInjection;
using AndradeLeonardo_ExamenProgreso1.Data;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AndradeLeonardo_ExamenProgreso1Context>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("AndradeLeonardo_ExamenProgreso1Context") ?? throw new InvalidOperationException("Connection string 'AndradeLeonardo_ExamenProgreso1Context' not found.")));

//Conexion sql server local e mssqllocal


builder.Services.AddDbContext<ApplicationDbContext>(opciones =>
opciones.UseSqlServer(builder.Configuration.GetConnectionString("AndradeLeonardo_ExamenProgreso1Context")));













// Add services to the container.
builder.Services.AddControllersWithViews();

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
