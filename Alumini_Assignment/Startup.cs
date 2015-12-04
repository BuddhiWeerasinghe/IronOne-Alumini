using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alumini_Assignment.Startup))]
namespace Alumini_Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
