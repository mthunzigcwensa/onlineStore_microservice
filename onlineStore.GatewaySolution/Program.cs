using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using onlineStore.GatewaySolution.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddAppAuthetication();
builder.Services.AddOcelot();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseOcelot();
app.Run();