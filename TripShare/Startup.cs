using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TripShare.Startup))]
namespace TripShare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
