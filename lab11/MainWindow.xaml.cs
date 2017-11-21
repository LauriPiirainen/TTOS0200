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

namespace Lab11wpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = "";
            List<String> list = new List<string>();
            if ((bool)Cboxmaito.IsChecked) list.Add("Maito");
            if ((bool)Cboxvoi.IsChecked) list.Add("Voi");
            if ((bool)Cboxkana.IsChecked) list.Add("Kana");
            if ((bool)Cboxsit.IsChecked) list.Add("Sitruuna");
            if ((bool)Cboxolut.IsChecked) list.Add("Kaljaa");
            foreach (string item in list)
            {
                text += item + " ";
            }
            Ostoslista.Text = text;

        }
    }
}