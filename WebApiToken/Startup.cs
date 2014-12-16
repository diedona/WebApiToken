using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebApiToken.Startup))]
namespace WebApiToken
{
    public class Startup
    {
        public void Configuration(IAppBuilder App)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            App.UseWebApi(config);
        }
    }
}