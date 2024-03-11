using BusinessLayer.Abstrack;
using BusinessLayer.Concrete;
using DataAccesss.Abstrack;
using DataAccesss.Concrete;
using DataAccesss.Context;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers();
builder.Services.AddScoped<IMailServices, MailManager>();
builder.Services.AddScoped<IMailRepository, MailRepository>();
builder.Services.AddScoped<ISenderServices, MailSenderServices>();

builder.Services.AddDbContext<KisiselDBContext>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{

}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();


