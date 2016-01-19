using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobileWebFormsApplication.Startup))]
namespace MobileWebFormsApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
