using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDB
{
    public static class Helper
    {
        public static string CnnVan(string name) { 
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
