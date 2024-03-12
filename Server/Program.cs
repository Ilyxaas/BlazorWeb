using System;
using System.Linq;
using BlazorProject.Client;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using BlazorProject.Server.Servises;
using BlazorProject.Server.Serviсes.IServices;
using Microsoft.Extensions.DependencyInjection;
using BlazorProject.Server;
using Microsoft.AspNetCore.Components;
using static System.Runtime.InteropServices.JavaScript.JSType;


var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql
    (builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<UserServiсes>();

var app = builder.Build();





// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");


System.Diagnostics.Debug.WriteLine("SomeText");

app.MapPost("api/registration", (EditContext? user) => {

    //Console.WriteLine(app.Configuration.GetConnectionString("Default"));
    // устанавливаем id для нового пользователя
    //user.Field = Guid.NewGuid().ToString();
    // добавляем пользователя в список
    Console.Write("Обработали");

    var serv = app.Services.GetService<UserServiсes>();

    return 1;
    
});


app.Run();

