using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A_Hand_2.Startup))]
namespace A_Hand_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
