using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiApp2.Startup))]
namespace WebApiApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
