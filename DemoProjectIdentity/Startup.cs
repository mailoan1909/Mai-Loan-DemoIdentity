using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoProjectIdentity.Startup))]
namespace DemoProjectIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
