using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeFirstAssessment.Startup))]
namespace CodeFirstAssessment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
