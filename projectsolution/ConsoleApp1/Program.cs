using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day14_AuthenticationLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder().ConfigureServices(ConfigureServices)
             .ConfigureServices(services => services.AddSingleton<Class1>())
             .Build()
             .Services
             .GetService<Class1>()
             .DisplayResult();
        }

        //Dependeny Container
        //Where we register all our dependencies of this project
        private static void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
        {
            services.AddSingleton<IUserAuthenticate, Login>();
        }
    }
}
