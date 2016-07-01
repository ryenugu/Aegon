using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aegon.Startup))]
namespace Aegon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
