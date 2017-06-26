using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Station
    {
       public int StationId { get; set; }
       public string StationName { get; set; }
       public virtual Plane Plane { get; set; }

    }

 
 
}
