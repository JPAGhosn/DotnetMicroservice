using KRK_Shared.Extensions;
using KRK_Shared.Middlewares;
using Recipes.Data;
using Recipes.Endpoints;
using Recipes.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();

builder.Services.AddWebCors();
builder.Services.AddBindings(builder.Configuration);

// Choose the right appsettings based on env variable
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseWebCors();
app.UseHttpsRedirection();

app.MapRecipes();

app.UseMiddleware<ErrorHandlingMiddleware>();

RecipesDataPreparation.GenerateData(app, builder.Environment.IsProduction());

app.Run();