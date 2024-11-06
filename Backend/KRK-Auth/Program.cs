using KRK_Auth.Bindings;
using KRK_Auth.Clients;
using KRK_Auth.Endpoints;
using KRK_Auth.Extensions;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.Configure<KeycloakOptions>(builder.Configuration.GetSection("Services:Keycloak"));
builder.Services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<KeycloakOptions>>().Value);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddCors(options =>
{
    options.AddPolicy("Web", policyBuilder =>
    {
        policyBuilder
            .WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Keycloak HTTP service
builder.Services.AddHttpClient<KeycloakClient>();


var app = builder.Build();

app.UseCors("Web");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapAuthEndpoints();

if (app.Environment.IsProduction()) app.UseHttpsRedirection();

app.Run();