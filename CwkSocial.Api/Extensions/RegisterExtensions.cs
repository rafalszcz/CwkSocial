using CwkSocial.Api.Registers;

namespace CwkSocial.Api.Extensions
{
    public static class RegisterExtensions
    {
        public static void RegisterServices(this WebApplicationBuilder builder,Type scanningType)
        {
           // var registests = scanningType.Assembly.GetTypes().Where(t=>t.IsAssignableTo<IWebApplicationBuilderRegister>())

        }
        public static void REgisterPiplineComponents(this WebApplication app,Type scanningType)
        {

        }

    }
}
