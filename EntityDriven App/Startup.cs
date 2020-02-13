using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityDriven_App.Startup))]
namespace EntityDriven_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
