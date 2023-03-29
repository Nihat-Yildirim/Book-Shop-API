using Core.Utilities.IOC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Configurations
{
    public class Connection
    {
        static ConfigurationManager _configurationManager = ServiceTool.ServiceProvider.GetService<ConfigurationManager>();
        
        public static string ConnectionString 
        {
            get
            {
                _configurationManager.SetBasePath("D:\\Projeler\\Book-Shop-API\\BookShopAPI\\");
                _configurationManager.AddJsonFile("appsettings.json");
                return _configurationManager.GetConnectionString("MSSQL");
            }
        }
    }
}