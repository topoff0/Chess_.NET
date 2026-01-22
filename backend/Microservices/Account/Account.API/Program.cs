using Account.API.Extensions;
using Account.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.TraversePath().Load();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddOpenApi();

builder.Services.AddMySwagger();

builder.Services.AddInfrastructure(builder.Configuration);



// ======================= APP ======================= 
var app = builder.Build();

await app.Services.ApplyMigrationAsync();

app.UseMySwagger(app.Environment);

app.Run();

