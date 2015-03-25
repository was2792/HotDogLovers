using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotDog.Startup))]
namespace HotDog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
