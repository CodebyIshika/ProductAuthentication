using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductAuthentication.Startup))]
namespace ProductAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
