using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCUsageStatistics.Startup))]
namespace PCUsageStatistics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
