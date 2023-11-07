using Microsoft.EntityFrameworkCore;
using ProjetoInterdisciplinarConcessionariaDriveTIme.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>
    (options => options.UseMySql(
        "server=localhost;initial catalog=PROJETO_INTERDISCIPLINAR;uid=root;pwd=Andreluiz15.",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql")));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuarios}/{action=Index}/{id?}");

app.Run();
