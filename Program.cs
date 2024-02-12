using FiveToSeven.Service.Minich10;
using FiveToSeven.Service.Minich9;
using FiveToSeven.Services.Alphanumeric;
using FiveToSeven.Services.Minich5;
using FiveToSeven.Services.Minich6;
using FiveToSeven.Services.MinichOne;
using FiveToSeven.Services.MinichThree;
using FiveToSeven.Services.MinichTwo;
using FiveToSeven.Services.Numeric;
using FiveToSeven.Services.SayHello;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(option =>{
    option.AddPolicy("CorsPolicy",
                builder =>{
                    builder.AllowAnyHeader();
                        builder.AllowAnyMethod();
                            builder.AllowAnyOrigin();
                }
    );
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISayHelloService, SayHelloService>();
builder.Services.AddScoped<IAskingQuestionsService ,AskingQuestionsService >();
builder.Services.AddScoped<IAddTwoNumbersService ,AddTwoNumbersService>();
builder.Services.AddScoped<IMinich5Service , Minich5Service>();
builder.Services.AddScoped<IMinich6Service ,Minich6Service>();
builder.Services.AddScoped<IMinich7Service, Minich7Service>();
builder.Services.AddScoped<INumericService, NumericService>();
builder.Services.AddScoped<IMinich9Service, Minich9Service>();
builder.Services.AddScoped<IMinich10Service, Minich10Service>();
builder.Services.AddScoped<IGreaterThanOrLessThanService, GreaterThanOrLessThanService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
