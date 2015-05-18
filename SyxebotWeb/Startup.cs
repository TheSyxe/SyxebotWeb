using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SyxebotWeb.Startup))]
namespace SyxebotWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
