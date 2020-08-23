using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteJimaine.Startup))]
namespace WebsiteJimaine
{
    public partial class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
