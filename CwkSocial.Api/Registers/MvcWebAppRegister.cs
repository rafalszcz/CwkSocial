
using Asp.Versioning.ApiExplorer;

namespace CwkSocial.Api.Registers
{
    public class MvcWebAppRegister : IWebApplicationRegister
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseSwagger();            // exposes /swagger/v1/swagger.json
            app.UseSwaggerUI(options => {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
                foreach (var descritption in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{descritption.GroupName}/swagger.json",
                        descritption.ApiVersion.ToString());
                }
            });
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
