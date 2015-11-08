using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Foosball.Web.Startup))]
namespace Foosball.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
