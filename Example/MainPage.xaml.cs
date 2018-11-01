using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Example.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Example
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static ObservableCollection<POJO.RootObject> list { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            list = new ObservableCollection<POJO.RootObject>();
            this.DataContext = this;

        }

        private async void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            List<POJO.RootObject> dateYoutube = await POJO.GetYoutube();
            for (int i = 0; i < dateYoutube.Count; i++)
            {
                list.Add(dateYoutube[i]);
            }

            GridViewShow.ItemsSource = list;
        }
    }
}
