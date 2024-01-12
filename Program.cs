using FiveToSeven.Services.Alphanumeric;
using FiveToSeven.Services.Minich5;
using FiveToSeven.Services.Minich6;
using FiveToSeven.Services.Numeric;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMinich5Service , Minich5Service>();
builder.Services.AddScoped<IMinich6Service ,Minich6Service>();
builder.Services.AddScoped<IMinich7Service, Minich7Service>();
builder.Services.AddScoped<INumericService, NumericService>();
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
