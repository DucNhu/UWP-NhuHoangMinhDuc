using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;

using Windows.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using product.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace product
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<logo> logos;
        private List<price> prices;
        private List<color> colors;
        private ObservableCollection<infor> infors;

        public MainPage()
        {
            this.InitializeComponent();
            colors = new List<color>();
            prices = new List<price>();
            logos = new List<logo>();

            colors.Add(new color { colors = "red" });
            colors.Add(new color { colors = "blue" });
            colors.Add(new color { colors = "gray" });

            prices.Add(new price { prices = "gray" });

            logos.Add(new logo { logos = "https://github.com/hungdaycb00/UWP-MH/blob/master/U41-Example1/U41-Example1/Assets/female-03.png?raw=true" });

            infors = new ObservableCollection<infor>();

        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            //GetAnimationBaseValue data
            string color = ((color)ColorBox.SelectedValue).colors;
            string price = ((price)PriceBox.SelectedValue).prices;
            string logo = ((logo)AvtBox.SelectedValue).logos;
            //Thêm item mới
            infors.Add(new infor { Color = color, Price = price, Logo = logo });
            //ColorBox.SelectedItem = -1;
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
