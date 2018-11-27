using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bloger.Startup))]
namespace Bloger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
