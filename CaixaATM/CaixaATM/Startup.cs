using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaixaATM.Startup))]
namespace CaixaATM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
