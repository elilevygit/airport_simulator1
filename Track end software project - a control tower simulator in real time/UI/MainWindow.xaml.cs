using AirportContracts;
using logical_layer;
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
        public MainWindow()
        {
            InitializeComponent();

            _AirportCallback = new AirportCallback();

            InstanceContext instanceContext = new InstanceContext(_AirportCallback);
            factory = new DuplexChannelFactory<IAirport>(instanceContext, "ClientEP");
            proxy = factory.CreateChannel();

            _AirportCallback.planesEventHandler += _AirportCallback_planesEventHandler;

           
        }

        void _AirportCallback_planesEventHandler(List<Plane> planes)
        {
            textb.ItemsSource = planes;
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            proxy.planensInAir();
        }
    }
}
