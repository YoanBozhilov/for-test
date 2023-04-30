using Microsoft.EntityFrameworkCore;
using for_test.Models;
using for_test.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<SQLDbContext>(options =>
{
    options.UseMySQL("Server=localhost;Database=test;Uid=root;Pwd=test;");
});
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<EventService>();


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
