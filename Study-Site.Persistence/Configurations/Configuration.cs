using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Persistence.Configurations
{
    static class Configuration 
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../../Presentation/Study-Site.MainAPI"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}

