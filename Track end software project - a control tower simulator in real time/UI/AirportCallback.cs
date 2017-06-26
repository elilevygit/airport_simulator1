using AirportContracts;
using logical_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{

    public delegate void PlanesEventHandler(List<Plane> planes);

    public class AirportCallback : IAirportDuplexCallback
    {
        public event PlanesEventHandler planesEventHandler;
        public void getPlanesInAir(List<Plane> plans)
        {
            if (planesEventHandler!=null)
            {
                planesEventHandler(plans);
                
            }

        }
    }
}
