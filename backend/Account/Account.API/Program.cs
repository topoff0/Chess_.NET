using Account.API.Extensions;
using Account.Infrastructure;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.TraversePath().Load();

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddMyCors();


// ======================= APP ======================= 
var app = builder.Build();

await app.Services.ApplyMigrationAsync();

app.UseRouting();
app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.MapControllers();

app.Run();

