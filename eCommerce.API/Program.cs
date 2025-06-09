using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add Infrastructure services
builder.Services.AddInfrastructure();
// Add Core services
builder.Services.AddCore();

// Add Controllers to the service collection
builder.Services.AddControllers();

// Build the web application
var app = builder.Build();

app.UseExceptionHandlingMiddleware();

//Routing
app.UseRouting();

//Auth
app.UseAuthorization();
app.UseAuthentication();

//Controller routes
app.MapControllers();
app.Run();



