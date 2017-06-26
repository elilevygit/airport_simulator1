using System;
    using Repository;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALLogic
    {



       public List<Station> UpdateStations(List<Station> station)
       {
           using (var db = new DBContent())
           {

               if (db.Stations.Count() == 0)
               {
                   db.Stations.AddRange(station);
               }
               else
               {

                   foreach (var item in station)
                   {
                       var st = db.Stations.Find(item.StationId);
                       db.Entry(db.Stations.Find(item.StationId)).CurrentValues.SetValues(item);
                   }
               }

               db.SaveChanges();

               return db.Stations.ToList();
           }
       }

       public Plane InsertPlane(Plane plane)
       {

           using (var db = new DBContent())
           {
               db.Planes.Add(plane);

               db.SaveChanges();


               return db.Planes.ToArray().Last();
           }

       }

       public Station InsertStation(Station station)
       {

           using (var db = new DBContent())
           {
               db.Stations.Add(station);

               db.SaveChanges();

               return db.Stations.Where(e => e.StationName == station.StationName).First();
           }
       }


       public List<Station> getStations()
       {
           using (var db = new DBContent())
           {

               return db.Stations.ToList();
           }
       }
       public DCAhistory InsertDCAhistory(DCAhistory _DCAhistory)
       {

           using (var db = new DBContent())
           {
               db.DCAhistorys.Add(_DCAhistory);

               db.SaveChanges();

               return db.DCAhistorys.Where(e => e.plane.PlaneId == _DCAhistory.plane.PlaneId).First();
           }
       }

      
       public List<DCAhistory> getDCAhistorys()
       {
           using (var db = new DBContent())
           {

               
                List<DCAhistory> d = db.DCAhistorys.Include("plane").Include("station").ToList();


                return d;
            }
       }

       public DCAhistory getDCAhistory(Station _Station)
       {
           using (var db = new DBContent())
           {

               return db.DCAhistorys.Where(e => e.station.StationName == _Station.StationName).First();
           }
       }

       public void updateDCAhistory(DCAhistory dCAhistory)
       {
           using (var db = new DBContent())
           {
               //db.DCAhistorys.(dCAhistory);
             db.Entry(db.DCAhistorys.Find(dCAhistory)).CurrentValues.SetValues(dCAhistory);
               db.SaveChanges();

           }
       }
    }

}
   
