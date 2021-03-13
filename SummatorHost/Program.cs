using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MySql.Data.MySqlClient;

namespace SummatorHost
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(Summator.Summator)))
            {
                host.Open();
                Console.WriteLine("Host started...");
                Console.ReadLine();
            }

         
        }
    }
}
