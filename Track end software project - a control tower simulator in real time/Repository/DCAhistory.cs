using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DCAhistory
    {

      public  int DCAhistoryId { get; set; }
        public DateTime Departures { get; set; }
        public DateTime Landings { get; set; }

        public Plane plane { get; set; }

        public Station station { get; set; }


    }
}
