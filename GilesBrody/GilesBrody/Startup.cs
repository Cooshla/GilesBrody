using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GilesBrody.Startup))]
namespace GilesBrody
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
