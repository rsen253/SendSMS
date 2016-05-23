using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendSMS.Startup))]
namespace SendSMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
