using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace S2S_Auth_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
