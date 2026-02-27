
using Asp.Versioning;

namespace CwkSocial.Api.Registers
{
    public class MvcRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {

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
            builder.Services.AddEndpointsApiExplorer();
        }
    }
}
