using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(habs_bets.Startup))]
namespace habs_bets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
