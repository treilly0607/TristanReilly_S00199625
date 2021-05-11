using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TristanReilly_S00199625
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Added db items to listbox
            GameData db = new GameData();  
            var query = from p in db.Games select p;

            GamesLB.ItemsSource = query.ToList();
        }

        private void GamesLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Change details based on selected item
            Game SelectedGame = GamesLB.SelectedItem as Game;

            if (SelectedGame != null)
            {
                GameImage.Source = new BitmapImage(new Uri(SelectedGame.GameImage, UriKind.Relative));
                DecsriptionTblock.Text = SelectedGame.Description;
                PlatformTblock.Text = SelectedGame.Platform;
                PriceTblock.Text = Convert.ToString(SelectedGame.Price);
            }
        }
    }
}
