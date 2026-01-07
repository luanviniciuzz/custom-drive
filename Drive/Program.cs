using EstruturaMinimalApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//WebApplicationBuilder : Configuration, Evironment, Host, Logging, Metrics, Services, WebHost
builder.AddServices();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "Drive v1"));
}

app.UseHttpsRedirection();

app.Run();
