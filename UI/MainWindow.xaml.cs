
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.ServiceReference;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AirportCallback _AirportCallback;
        DuplexChannelFactory<IAirport> factory;
        IAirport proxy;
        List<Station> listplanes;
        List<DCAhistory> listdCAhistorys;
        public MainWindow()
        {
            InitializeComponent();
            listplanes = new List<Station>();
            listdCAhistorys = new List<DCAhistory>();
            _AirportCallback = new AirportCallback();

            InstanceContext instanceContext = new InstanceContext(_AirportCallback);
            factory = new DuplexChannelFactory<IAirport>(instanceContext, "WSDualHttpBinding_IAirport");
            proxy = factory.CreateChannel();

            _AirportCallback.stationsEventHandler += _AirportCallback_stationsEventHandler;
            _AirportCallback.dCAhistorysEventHandler += _AirportCallback_dCAhistorysEventHandler;
            proxy.planensInStations();

        }

        void _AirportCallback_dCAhistorysEventHandler(List<DCAhistory> dCAhistorys)
        {
            listdCAhistorys = dCAhistorys;
            DCAhistory.ItemsSource = null;
            DCAhistory.ItemsSource = listdCAhistorys;
            
        }

        void _AirportCallback_stationsEventHandler(List<Station> stations)
        {

            //foreach (var item in planes)
            //{
            //    if (item.PlaneStationTrack.StationTrackID==1)
            //    {
            //        textb.Items.Add(item);
            //    }
            //    if (item.PlaneStationTrack.StationTrackID == 2)
            //    {

            //        textb_Copy.Items.Add(item);
            //    } 
            //    if (item.PlaneStationTrack.StationTrackID == 3)
            //    {

            //        textb_Copy1.Items.Add(item);
            //    }
            //    if (item.PlaneStationTrack.StationTrackID == 4)
            //    {

            //        textb_Copy2.Items.Add(item);
            //    }
            //}
            listplanes = stations;
            refresh();

        }
        private void refresh()
        {
            //if (listplanes.First().Plane != null)
            //{
            //    MessageBox.Show(listplanes.First().Plane.PlaneId.ToString());

            //}
            listplanes1.ItemsSource = null;

            listplanes1.ItemsSource = listplanes;


            moveplanes();
        }
    
        private void moveplanes()
        {
            
        }
        private void b_Click(object sender, RoutedEventArgs e)
        {
            proxy.planensInStations();
        }







    }
}
