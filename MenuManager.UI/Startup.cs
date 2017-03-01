using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenuManager.UI.Startup))]
namespace MenuManager.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
