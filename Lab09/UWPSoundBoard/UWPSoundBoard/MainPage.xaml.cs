using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPSoundBoard.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPSoundBoard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<sound> sounds;
        private List<String> Suggestions;
        private List<MenuItems> MenuItems;
        public MainPage()
        {
            this.InitializeComponent();
            sounds = new ObservableCollection<sound>();
            SoundManager.GetAllSounds(sounds);

            MenuItems = new List<MenuItems>();
            MenuItems.Add(new MenuItem { Iconfile = "Assets/Icons/animals.png", CategoryTextBlock = SoundCategory.Animals });
            MenuItems.Add(new MenuItem { Iconfile = "Assets/Icons/Cartoon.png", CategoryTextBlock = SoundCategory.Cartoons });
            MenuItems.Add(new MenuItem { Iconfile = "Assets/Icons/taunt.png", CategoryTextBlock = SoundCategory.Taunts });
            MenuItems.Add(new MenuItem { Iconfile = "Assets/Icons/waring.png", CategoryTextBlock = SoundCategory.Warnings });
        }

        private void Backbutton_Click(object sender, RoutedEventArgs e)
        {
            goBack();
        }

        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }

        private void goBack() {
            SoundManager.GetAllSounds(sounds);
            CategoryTextBlock.Text = "All Sounds";
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            SoundManager.GetSoundsByName(sounds, sender.Text);
            CategoryTextBlock.Text = sender.Text;
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Visible;
        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = (MenuItems)e.ClickedItem;
        }

    }
}
