using Microsoft.Extensions.Configuration;
using System.Windows;
using WeatherApp.Services;
using WeatherApp.ViewModels;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TemperatureViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            /// TODO : Faire les appels de configuration ici ainsi que l'initialisation

            vm = new TemperatureViewModel();

            DataContext = vm;

            vm.SetTemperatureService(new OpenWeatherService(AppConfiguration.GetValue("APIKey")));
        }


  

 
    }
}
