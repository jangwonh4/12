using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Assignment4.Startup))]
namespace Web_Assignment4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
