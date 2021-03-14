using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Soccer.Web.Startup))]
namespace Soccer.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
