using logical_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AirportContracts
{
   public interface IAirportDuplexCallback
    {
       [OperationContract]

       void getPlanesInAir(List<Plane> plans);

    }
}
