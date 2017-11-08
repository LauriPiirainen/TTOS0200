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

namespace Lab10_2
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

        double number = 0;
        double number2 = 0;

        //dollareista euroiksi
        private void ostomäärä_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dollari_arvo.Text == null)
            {
                euro_arvo.Text = 0.ToString();
            }
            else
            {
                number = double.Parse(dollari_arvo.Text);
                number2 = number * 0.8997;
                euro_arvo.Text = number2.ToString("0.00"); //Kaksi desimaalia
            }
        }

        //Euroista dollareiksi
        private void maksumäärä_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (euro_arvo.Text == null)
            {
                dollari_arvo.Text = 0.ToString();
            }
            else
            {
                number = double.Parse(euro_arvo.Text);
                number2 = number / 0.8997;
                dollari_arvo.Text = number2.ToString("0.00"); //Kaksi desimaalia
            }
        }

        private void Valuutanvalinta_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
