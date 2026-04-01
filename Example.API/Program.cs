using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//RESTful => Http protocol => Architectural style  => Json


//plugins
builder.Services.AddControllers(); // MVC Design Pattern
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

//Middleware
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); // swagger web ui
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
