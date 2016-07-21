using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ejemplo01.Startup))]
namespace Ejemplo01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
