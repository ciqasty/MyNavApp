using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNav.Startup))]
namespace MyNav
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
