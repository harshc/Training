using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kcsara.Training.Startup))]
namespace Kcsara.Training
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
