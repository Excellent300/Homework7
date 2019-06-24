using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework7._1.Startup))]
namespace Homework7._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
