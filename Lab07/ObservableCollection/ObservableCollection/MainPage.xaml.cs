using System;
using System.Collections.Generic;
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
using ObservableCollection.Models;
using System.Collections.ObjectModel;
using System.Threading;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ObservableCollection
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<IconSS> Icons;
        private ObservableCollection<Contact> Contacts;

        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<IconSS>();

            Icons.Add(new IconSS { iconPath = "https://github.com/hungdaycb00/UWP-MH/blob/master/U41-Example1/U41-Example1/Assets/female-03.png?raw=true" });
            Icons.Add(new IconSS { iconPath = "https://github.com/hungdaycb00/UWP-MH/blob/master/U41-Example1/U41-Example1/Assets/female-03.png?raw=true" });
            Icons.Add(new IconSS { iconPath = "https://github.com/hungdaycb00/UWP-MH/blob/master/U41-Example1/U41-Example1/Assets/female-03.png?raw=true" });
  
            //Thêm item làm mẫu:
            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact { FirstName = "Nhu", LastName = "Duc", AvatarPath = "https://github.com/hungdaycb00/UWP-MH/blob/master/U41-Example1/U41-Example1/Assets/female-03.png?raw=true" });
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((IconSS)AvatarComboBox.SelectedValue).iconPath;
            //Thêm item mới
            Contacts.Add(new Contact { FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text, AvatarPath = avatar });

            //Reset data
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";

            //AvatarComboBox.SelectedItem = -1;
            FirstNameTextBox.Focus(FocusState.Programmatic);
        }
    }
}
