using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JimaineRolePlayWebsite.Startup))]
namespace JimaineRolePlayWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
