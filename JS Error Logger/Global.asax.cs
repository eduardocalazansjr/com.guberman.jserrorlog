using System.Web;
using System.Web.Http;
using WebApiContrib.Formatting.Jsonp;

namespace JSErrorlog
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.AddJsonpFormatter();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
