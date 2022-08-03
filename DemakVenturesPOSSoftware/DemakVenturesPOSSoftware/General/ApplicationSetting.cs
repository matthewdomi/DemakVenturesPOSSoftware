using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DemakVenturesPOSSoftware.General
{
    public class ApplicationSetting
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
        }
    }
}
