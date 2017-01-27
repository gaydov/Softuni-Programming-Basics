using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ratings.Startup))]
namespace Ratings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
