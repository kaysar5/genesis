using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StrollerStoreUI.Startup))]
namespace StrollerStoreUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
