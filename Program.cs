using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Parcial1.Data;
using Blazored.Toast;
using Blazored.Toast.Services;
using Microsoft.EntityFrameworkCore;
 


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor(); 
builder.Services.AddBlazoredToast();
var ConStr = builder.Configuration.GetConnectionString("ConStr");

builder.Services.AddDbContext<Contexto>( con =>
    con.UseSqlite(ConStr)
);


builder.Services.AddTransient<AportesBLL>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

