using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwilioCheckout.Startup))]
namespace TwilioCheckout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
