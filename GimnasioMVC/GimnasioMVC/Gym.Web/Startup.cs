using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gym.Web.Startup))]
namespace Gym.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
