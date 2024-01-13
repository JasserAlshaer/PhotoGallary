using Microsoft.EntityFrameworkCore;
using PhotoGallary_Reopsitary.Context;
using PhotoGallary_Reopsitary.IReops;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PhotoGallaryDbContext>(cnn => cnn.UseSqlServer(builder.Configuration.GetValue<string>("SqlConnectionString")));
builder.Services.AddScoped<IPhotoGallary, PhotoGallary_Reopsitary.Implementation.PhotoGallary>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
