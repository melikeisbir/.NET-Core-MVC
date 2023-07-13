using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
namespace Example.MVC.Data
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Example.MVC")); // LOCAL
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Example.MVC")); // PROD
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("DefaultConnection");
            }
        }
    }
}
