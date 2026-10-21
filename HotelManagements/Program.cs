using HotelManagements.Entities;
using HotelManagements.Interfaces;
using HotelManagements.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IRoomService, RoomServices>();
builder.Services.AddScoped<IGuestService, GuestService>();
builder.Services.AddDbContext<HotelDbContext>(option => option.UseSqlServer(
    builder.Configuration.GetConnectionString("DbConnection")
    ));
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "My Api v1");
    });
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
