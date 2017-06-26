
namespace Repository
{
   public class Station
    {
       public int StationId { get; set; }
       public string StationName { get; set; }
       public virtual Plane Plane { get; set; }

    }

 
 
}
