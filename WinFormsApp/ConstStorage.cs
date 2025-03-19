using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class ConstStorage
    {
        //  
        public static string ConnectionDb => $"Data source={Environment.CurrentDirectory}\\dbmain.db;";
        public static string ConfigPath => $"{Environment.CurrentDirectory}\\appconfig.json";
    }
}
