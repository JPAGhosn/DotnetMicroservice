using KRK_Shared.Extensions;
using Repositories.Endpoints;
using Repositories.Extensions;
using Shared.Extensions;
using Shared.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.SetupJson();
builder.Services.AddSharedServices();
builder.Services.AddBindings(builder.Configuration);
builder.Configuration.SetupAppSettings(builder.Environment);
builder.Services.SetupServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSharedBindings(builder.Configuration);
builder.Services.AddWebCors();
builder.Services.SetupAuthentication(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseWebCors();
app.UseGlobalExceptionMiddleware();
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseRouting();
app.SetupAuthentication(builder.Configuration);

app.MapRepositoriesEndpoints();

app.Run();