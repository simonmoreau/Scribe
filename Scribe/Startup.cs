using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scribe.Startup))]
namespace Scribe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
