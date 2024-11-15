using KRK_Subscriptions.Endpoints;
using KRK_Subscriptions.Extensions;

Console.WriteLine("Hello World!");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddServices();
builder.Services.AddConfigurationSettings(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// if (app.Environment.IsProduction()) app.UseHttpsRedirection();

app.MapSubscriptionsEndpoints();

app.Run();