using AirportContracts;
using logical_layer;
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

           DuplexChannelFactory<IAirport> factory = new DuplexChannelFactory<IAirport>(instanceContext, "ClientEP");

           IAirport proxy = factory.CreateChannel();


           for (int i = 0; i < 30; i++)
           {
               proxy.addplane();
               System.Threading.Thread.Sleep(5000);
           }
         
           
       
           Console.ReadLine();

        }


    }
}
