using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TradeUnionMVC.Startup))]
namespace TradeUnionMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
