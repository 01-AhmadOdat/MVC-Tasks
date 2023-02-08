using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authentication8_2_2023.Startup))]
namespace Authentication8_2_2023
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
