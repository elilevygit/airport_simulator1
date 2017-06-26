using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(AirportService));
            try
            {
                host.Open();

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally
            {
                host.Close();
            }
        }
    }
}



























                //AirportService asd = new AirportService();
                //asd.addplane();

                //Thread.Sleep(1300);
             
                //asd.addplane();
                //Thread.Sleep(700);

                //asd.addplane();
                //Thread.Sleep(1000);

                //asd.addplane();
