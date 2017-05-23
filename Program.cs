using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace JWAppIdentityServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "JWAppIdentityServer";

            var host = new WebHostBuilder()
                .UseKestrel()
                //We recommend to configure the same port for IIS Express and self-hosting
                //Identity Server Discovery page is http://localhost:5000/.well-known/openid-configuration
                .UseUrls("http://localhost:5000")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
