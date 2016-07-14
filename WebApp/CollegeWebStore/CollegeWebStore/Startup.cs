using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeWebStore.Startup))]
namespace CollegeWebStore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
