using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace logical_layer
{
    public class Logic
    {

        List<Station> _Stations;
        List<DCAhistory> _DCAhistorys;
        public DALLogic dall;
        

        public Logic()
        {
            _Stations = new List<Station>();

         dall = new DALLogic();


         if (dall.getStations().Count<2)
         {
             InsertStations();
         }
         else
         {
             _Stations = dall.getStations();
         }
         
        }
     

     
        public void DepartPlane(Plane plane)
        {
            Console.WriteLine("Logic DepartPlane();");
            int num = 0;

            Console.WriteLine("DepartPlane   NewMethod(" + plane.PlaneId + ", " + num + ");");
            NewMethod(plane, num);


            Console.WriteLine("");
        }

        private void NewMethod(Plane plane, int num)
        {
            Console.WriteLine("NewMethod          NewMethod(" + plane.PlaneId + "," + num);


            if (_Stations[num].Plane == null)
            {
                Console.WriteLine("NewMethod              NewMethod1(" + plane.PlaneId + "," + num);

                Task.Run(() => NewMethod1(plane, num));


            }
            else
            {

                Console.WriteLine("Stations[num].Plane != null");


                Thread.Sleep(3000);
                Task.Run(() => NewMethod(plane, num));
            }

        }

        private void NewMethod1(Plane plane, int num)
        {
            Console.WriteLine("NewMethod1              NewMethod1(" + plane.PlaneId + "," + num);

            if (_Stations[num].Plane!=null)
            {
                dall.updateDCAhistory(new DCAhistory() { plane = _Stations[num].Plane, station = _Stations[num], Departures = DateTime.Now, Landings = dall.getDCAhistory( _Stations[num]).Landings });
            }
            else
            {
                Console.WriteLine("dall.updateDCAhistory(new DCAhistory() { plane = _Stations[num].Plane, station = _Stations[num], Departures = DateTime.Now })    !!! null !!!     ");
            }

            _Stations[num].Plane = plane;
            Console.WriteLine("NewMethod1             Stations[" + num + "].Plane = " + plane.PlaneId);
            dall.InsertDCAhistory(new DCAhistory() { plane = plane, station = _Stations[num], Landings = DateTime.Now  , Departures=DateTime.MaxValue});
            Thread.Sleep(9000);

            Console.WriteLine("NewMethod1 b    plane" + plane.PlaneId + "num " + num);

            if (num < 2)
            {
                NewMethod(_Stations[num].Plane, num + 1);

            }
            else
            {
                Console.WriteLine("  airp out   ");
            }


            Console.WriteLine("NewMethod1            Stations[" + num + "].Plane = null;");

            _Stations[num].Plane = null;

        }









        public List<Station> GetStations()
        {

            
            return _Stations ;


        }

        public List<DCAhistory> GetdCAhistorys()
        {

            _DCAhistorys= dall.getDCAhistorys();
           

            return _DCAhistorys;
        }
        public void InsertPlane()
        {
          Plane plane= dall.InsertPlane(new Plane());



          DepartPlane(plane);
        }
        public void InsertStations()
        {
            _Stations.Add(dall.InsertStation(new Station(){StationName = "Station4"}));
            _Stations.Add(dall.InsertStation(new Station(){StationName = "Station2"}));
            _Stations.Add(dall.InsertStation(new Station(){StationName = "Station3" }));

        }

        public void UpdateStations()
        {
            dall.UpdateStations(_Stations);
        }
    }
}









#region MyRegion







//public void LandingPlane(Plane plane)
//{
//    Console.WriteLine("Logic LandingPlane();");

//    //StationTrack.Planes.Remove(plane);
//}



//List<Plane> lp = new List<Plane>();

//Console.WriteLine("Logic plainesInAir();");
//foreach (var item in Stations)
//{
//    if (item.Plane!=null)
//    {
//        lp.Add(item.Plane);
//    }
//}


//public void rearndg()
//{
//    List<Station> Stationstmp = Stations;

//    Stationstmp.Reverse();

//    foreach (var item in Stationstmp)
//    {
//        if (item.Equals(Stationstmp.First()))
//        {

//        }
//        else if (item.Equals(Stationstmp.Last()))
//        {
//            Stationstmp[Stationstmp.FindIndex(a => a.Plane == item.Plane) + 1].Plane = item.Plane;

//            item.Plane = null;
//        }
//        else
//        {
//            Stationstmp[Stationstmp.FindIndex(a => a.Plane == item.Plane) + 1].Plane = item.Plane;
//        }

//    }

//    Stationstmp.Reverse();
//    Stations = Stationstmp;
//}
//#region MyRegion
//private void myTimer_Tick(object sender, EventArgs e)
//{
//    Console.WriteLine("Logic myTimer_Tick();");

//    if (Stations.Find(s => s.StationName == "Station2").Plane == null)
//    {
//        Stations.Find(s => s.StationName == "Station2").Plane = StationTrack.Planes.Last();

//        StationTrack.Planes.Remove(StationTrack.Planes.Last());

//        myTimer1.Interval = 5000;
//        myTimer1.Tick += new EventHandler(myTimer_Tick1);
//        myTimer1.Start();
//        myTimer.Stop();



//    }
//    else
//    {
//        myTimer.Stop();
//        myTimer.Interval = 500;
//        myTimer.Tick += new EventHandler(myTimer_Tick);
//        myTimer.Start();
//    }


//}
//private void myTimer_Tick1(object sender, EventArgs e)
//{
//    Console.WriteLine("Logic myTimer_Tick1();");

//    if (Stations.Find(s => s.StationName == "Station3").Plane == null)
//    {
//        Stations.Find(s => s.StationName == "Station3").Plane = Stations.Find(s => s.StationName == "Station2").Plane;

//        Stations.Find(s => s.StationName == "Station2").Plane = null;

//        myTimer2.Interval = 5000;
//        myTimer2.Tick += new EventHandler(myTimer_Tick2);
//        myTimer2.Start();
//        myTimer1.Stop();

//    }
//    else
//    {
//        myTimer1.Stop();

//        myTimer1.Interval = 500;
//        myTimer1.Tick += new EventHandler(myTimer_Tick1);
//        myTimer1.Start();
//    }
//}
//private void myTimer_Tick2(object sender, EventArgs e)
//{

//    Console.WriteLine("Logic myTimer_Tick2();");

//    if (Stations.Find(s => s.StationName == "Station3").Plane == null)
//    {
//        Stations.Find(s => s.StationName == "Station4").Plane = Stations.Find(s => s.StationName == "Station4").Plane;

//        Stations.Find(s => s.StationName == "Station4").Plane = null;

//        myTimer3.Interval = 5000;
//        myTimer3.Tick += new EventHandler(myTimer_Tick3);
//        myTimer3.Start();
//        myTimer2.Stop();

//    }
//    else
//    {
//        myTimer2.Stop();
//        myTimer2.Interval = 500;
//        myTimer2.Tick += new EventHandler(myTimer_Tick2);
//        myTimer2.Start();
//    }
//}
//private void myTimer_Tick3(object sender, EventArgs e)
//{
//    Console.WriteLine("Logic myTimer_Tick3();");

//    if (Stations.Find(s => s.StationName == "Station4").Plane == null)
//    {
//        Stations.Find(s => s.StationName == "Station4").Plane = Stations.Find(s => s.StationName == "Station4").Plane;

//        Stations.Find(s => s.StationName == "Station4").Plane = null;

//        myTimer4.Interval = 5000;
//        myTimer4.Tick += new EventHandler(myTimer_Tick4);
//        myTimer4.Start();
//        myTimer3.Stop();

//    }
//    else
//    {
//        myTimer3.Stop();
//        myTimer3.Interval = 500;
//        myTimer3.Tick += new EventHandler(myTimer_Tick3);
//        myTimer3.Start();
//    }
//}
//private void myTimer_Tick4(object sender, EventArgs e)
//{
//    Console.WriteLine("Logic myTimer_Tick4();");

//    if (Stations.Find(s => s.StationName == "Station4").Plane == null)
//    {
//        Stations.Find(s => s.StationName == "Station4").Plane = Stations.Find(s => s.StationName == "Station4").Plane;

//        Stations.Find(s => s.StationName == "Station4").Plane = null;
//        myTimer4.Stop();
//    }
//    else
//    {
//        myTimer4.Stop();
//        myTimer4.Interval = 500;
//        myTimer4.Tick += new EventHandler(myTimer_Tick4);
//        myTimer4.Start();
//    }
//} 
//#endregion
#region MyRegion
//private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
//private System.Windows.Forms.Timer myTimer1 = new System.Windows.Forms.Timer();
//private System.Windows.Forms.Timer myTimer2 = new System.Windows.Forms.Timer();
//private System.Windows.Forms.Timer myTimer3 = new System.Windows.Forms.Timer();
//private System.Windows.Forms.Timer myTimer4 = new System.Windows.Forms.Timer(); 
#endregion


#endregion