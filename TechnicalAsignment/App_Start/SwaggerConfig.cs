using System.Web.Http;
using WebActivatorEx;
using TechnicalAsignment;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace TechnicalAsignment
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {                       
                        c.SingleApiVersion("v1", "Technical Assignment");                        
                    })
                .EnableSwaggerUi();
        }
    }
}
