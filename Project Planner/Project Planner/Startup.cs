using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Planner.Startup))]
namespace Project_Planner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
