using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_StudentData1.Startup))]
namespace mvc_StudentData1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
