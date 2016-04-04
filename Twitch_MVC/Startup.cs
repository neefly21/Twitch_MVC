using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Twitch_MVC.Startup))]
namespace Twitch_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
