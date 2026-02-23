using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using CwkSocial.Api.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApiVersioning(config =>
{
    config.DefaultApiVersion = new ApiVersion(1, 0);
    config.AssumeDefaultVersionWhenUnspecified = true;
    config.ReportApiVersions = true;
    config.ApiVersionReader = new UrlSegmentApiVersionReader();
}).AddApiExplorer(config =>
    {
        config.GroupNameFormat = "'v'VVV";
        config.SubstituteApiVersionInUrl = true;
    }
    );
builder.Services.AddSwaggerGen();
builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

builder.Services.AddEndpointsApiExplorer();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// Use Swashbuckle here so the JSON endpoint is available at /swagger/v1/swagger.json



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Register the Swagger JSON endpoint and the UI (Swashbuckle)
    app.UseSwagger();            // exposes /swagger/v1/swagger.json
    app.UseSwaggerUI(options => {
     var provider=app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
        foreach(var descritption in provider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"/swagger/{descritption.GroupName}/swagger.json",
                descritption.ApiVersion.ToString());
        }
    });          // interactive UI at /swagger
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
