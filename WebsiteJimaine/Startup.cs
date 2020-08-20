using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteJimaine.Startup))]
namespace WebsiteJimaine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
