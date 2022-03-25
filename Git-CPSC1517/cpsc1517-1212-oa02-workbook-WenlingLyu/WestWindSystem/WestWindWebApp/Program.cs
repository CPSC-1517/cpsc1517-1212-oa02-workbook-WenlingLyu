#region add namespace for backendDependencies
using WestWindSystem;
using Microsoft.EntityFrameworkCore;
#endregion

var builder = WebApplication.CreateBuilder(args);

#region  Setup database connection for backEnd to use
//Add connectionstring here
var connectionstring = builder.Configuration.GetConnectionString("WestWindDatabase");
builder.Services.BackendDependencies(options => options.UseSqlServer(connectionstring));
#endregion

// Add services to the container.
builder.Services.AddRazorPages();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
