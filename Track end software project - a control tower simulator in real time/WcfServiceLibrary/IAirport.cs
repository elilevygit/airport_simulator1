using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AirportContracts
{
    [ServiceContract(SessionMode = SessionMode.Required,
                    CallbackContract = typeof(IAirportDuplexCallback))]
   public interface IAirport
    {
        [OperationContract(IsOneWay = true)]

        void addplane();
        [OperationContract(IsOneWay = true)]

        void planensInAir();

    }
}
