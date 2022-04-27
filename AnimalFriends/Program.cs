using Core.Interfaces;
using Core.Services;
using FluentValidation.AspNetCore;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using WebAPI.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<CustomerService, CustomerService>();
builder.Services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

builder.Services.AddControllersWithViews(options =>
    options.Filters.Add<ApiExceptionFilterAttribute>())
        .AddFluentValidation(x => x.AutomaticValidationEnabled = false);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();