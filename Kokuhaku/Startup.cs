using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kokuhaku.Startup))]
namespace Kokuhaku
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
