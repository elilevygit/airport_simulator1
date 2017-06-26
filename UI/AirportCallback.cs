
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.ServiceReference;

namespace UI
{

    public delegate void PlanesEventHandler(List<Station> planes);
    public delegate void DCAhistorysEventHandler(List<DCAhistory> dCAhistorys);

    public class AirportCallback : IAirportCallback
    {
        public event PlanesEventHandler stationsEventHandler;
        public event DCAhistorysEventHandler dCAhistorysEventHandler;

        public void SendStations(Station[] stations)
        {

            if (stationsEventHandler != null)
            {
                stationsEventHandler(stations.ToList());

            }
        }




        public void SenddCAhistorys(DCAhistory[] dCAhistorys)
        {
            if (dCAhistorysEventHandler!=null)
            {
                dCAhistorysEventHandler(dCAhistorys.ToList());
            }
        }
    }
}
