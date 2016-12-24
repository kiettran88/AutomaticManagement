using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AM.Startup))]
namespace AM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
