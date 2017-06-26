
using Simulator.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    class Program
    {
      
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new AirportCallback());

            DuplexChannelFactory<IAirport> factory = new DuplexChannelFactory<IAirport>(instanceContext, "WSDualHttpBinding_IAirport");

           IAirport proxy = factory.CreateChannel();

           Console.WriteLine("proxy;");

           for (int i = 0; i < 30; i++)
           {
               proxy.addplane();
               Console.WriteLine("proxy.addplane();");

               System.Threading.Thread.Sleep(5000);

           }
         
           
       
           Console.ReadLine();

        }


    }
}
