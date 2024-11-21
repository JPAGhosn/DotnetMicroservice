using KRK_Shared.Extensions;
using Tags.Data;
using Tags.Endpoints;
using Tags.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Choose the right appsettings based on env variable
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddWebCors();
builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapTagsEndpoints();

app.UseWebCors();

TagsDbPreparation.PrepPopulation(app, builder.Environment.IsProduction());

app.Run();