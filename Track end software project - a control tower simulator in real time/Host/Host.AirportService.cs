using AirportContracts;
using logical_layer;
using Repository;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Host
{


    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]

    public class AirportService : IAirport
    {
        static CancellationTokenSource _source = new CancellationTokenSource();
        private CancellationToken _token = _source.Token;
        Logic logic = new Logic();
        System.Timers.Timer updateClient = null;
        List<IAirportDuplexCallback> Callbackusers = new List<IAirportDuplexCallback>();
        IAirportDuplexCallback GetCurrentCallback()
        {
            return OperationContext.Current.GetCallbackChannel<IAirportDuplexCallback>();
        }
        public void addplane()
        {
            Console.WriteLine("AirportService addplane();");
            bool isin = false;
            foreach (var item in Callbackusers)
            {
                if (GetCurrentCallback() == item)
                {
                    isin = true;
                }
            }
            if (!isin)
            {
                Callbackusers.Add(GetCurrentCallback());

                //registeredTicker = ticker;

                updateClient = new System.Timers.Timer(5000);

                updateClient.Elapsed += new ElapsedEventHandler(updateClient_Elapsed);

                updateClient.Enabled = true;

                updateClient.Start();

               // StartSendingData();
                
            }

            logic.InsertPlane();

        }

  
        void updateClient_Elapsed(object sender, ElapsedEventArgs e)
        {

            StartSendingData();

        }
        public void StartSendingData()
        {
            Console.WriteLine("User asked for data");
            Task.Run((Action)SendToClint, _token);
          
        }

        public void planensInStations()
        {
            Console.WriteLine("AirportService planensInAir();");
            bool isin = false;
            foreach (var item in Callbackusers)
            {
                if (GetCurrentCallback() == item)
                {
                    isin = true;
                }
            }
            if (!isin)
            {
                Callbackusers.Add(GetCurrentCallback());

            }

        }

        private void SendToClint()
        {
            Console.WriteLine("AirportService send_to_clint();");

            foreach (var item in Callbackusers)
            {
                item.SendStations(logic.GetStations());
                item.SenddCAhistorys(logic.GetdCAhistorys());

                Console.WriteLine("item.SendStations(logic.GetStations());");
            }
            
            logic.UpdateStations();
        }

    
     


    }
}





//send_to_clint();



























//logic.DepartPlane(new Plane() { PlaneId = 1 });

//Thread.Sleep(7000);
//logic.DepartPlane(new Plane() { PlaneId = 2 });
//Thread.Sleep(3000);
//logic.DepartPlane(new Plane() { PlaneId = 3 });
