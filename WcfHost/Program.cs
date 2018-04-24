using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(WcfService2.Service1)))
            {
                host.Open();
                Console.WriteLine("Host started at: " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
