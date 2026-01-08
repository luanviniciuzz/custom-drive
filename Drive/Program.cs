using Drive.Endpoints;
using EstruturaMinimalApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

//WebApplicationBuilder : Configuration, Evironment, Host, Logging, Metrics, Services, WebHost
builder.AddServices();

var app = builder.Build();

app.MapFileEndPoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "Drive v1"));
}

app.UseHttpsRedirection();

app.Run();
