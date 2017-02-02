using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FixMens.Startup))]
namespace FixMens
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
