using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFLib;
using System.ServiceModel;
namespace ConsoleWCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCFLib.EmpService)); //give class name
            host.Open();
            Console.WriteLine("service started...");
            Console.ReadLine();
            host.Close();
            //Console.ReadKey();
        }
    }
}
