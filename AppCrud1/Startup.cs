using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppCrud1.Startup))]
namespace AppCrud1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
