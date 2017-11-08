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

namespace Lab10_1
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

        private void BtnTruck_click(object sender, RoutedEventArgs e)
        {
             String add = (Convert.ToInt32(truckTextBlock.Text) + 1).ToString();
            truckTextBlock.Text = add;
        }

        private void BtnCar_click(object sender, RoutedEventArgs e)
        {
            String add = (Convert.ToInt32(carTextBlock.Text) + 1).ToString();
            carTextBlock.Text = add;
        }
    }
}
