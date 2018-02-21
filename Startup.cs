using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assingnment_1_.Startup))]
namespace Assingnment_1_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
