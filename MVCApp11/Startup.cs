using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCApp11.Startup))]
namespace MVCApp11
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

/*
 echo "# MVCApp11" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/noriel1214/MVCApp11.git
git push -u origin main
*/
