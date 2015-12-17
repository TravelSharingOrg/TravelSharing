using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelSharing.Web.Startup))]
namespace TravelSharing.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
