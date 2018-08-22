using System.Web.Http;
using WebActivatorEx;
using DotNet.Swagger.WebApi;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace DotNet.Swagger.WebApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "Com.App.SysApi");
                c.IncludeXmlComments(GetXmlCommentsPath());
                // c.OperationFilter<HttpHeaderFilter>();  // Ȩ�޹���

            }).EnableSwaggerUi(c => {
                c.DocumentTitle("ϵͳ�����ӿ�");
                // ʹ������
                c.InjectJavaScript(thisAssembly, "DotNet.Swagger.WebApi.Scripts.Swagger.swagger_lang.js");
            });
        }

        private static string GetXmlCommentsPath()
        {
            return string.Format("{0}/bin/DotNet.Swagger.WebApi.xml", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
