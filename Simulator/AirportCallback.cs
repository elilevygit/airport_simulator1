
using Simulator.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{

   // public delegate void 

   public class AirportCallback : IAirportCallback
    {


       public void SendStations(Station[] stations)
       {
           Console.WriteLine("getPlanesInAir " + stations.Count().ToString());
           if (stations.First().Plane!=null)
           {
               Console.WriteLine("getPlanesInAir " + stations.First().Plane.PlaneId);
           }
           else
           {
               Console.WriteLine("getPlanesInAir " + stations.First().Plane);

           }
       }


       public void SenddCAhistorys(DCAhistory[] dCAhistorys)
       {
           Console.WriteLine("SenddCAhistorys " + dCAhistorys.Count().ToString());
           if (dCAhistorys.First().plane != null)
           {
               Console.WriteLine("SenddCAhistorys " + dCAhistorys.First().plane.PlaneId);
           }
           else
           {
               Console.WriteLine("SenddCAhistorys " + dCAhistorys.First().plane);

           }
       }
    }
}
