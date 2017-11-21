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

namespace Lab11._4wpf
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


        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var name = (string)button.Content;
            if (inputBox.Text == "0") inputBox.Text = name;
            else inputBox.Text += name;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {

            if (float.TryParse(inputBox.Text, out float luku))
            {
                Infobox.Text = "";


                if (Lämppallura.IsChecked == true)
                {


                    if (luku > 140)
                    {
                        TxtLämp.Text = "140";
                        Infobox.Text = "Max 140";

                    }
                    else if (luku < 0)
                    {
                        TxtLämp.Text = "0";
                        Infobox.Text = "Min 0";

                    }
                    else TxtLämp.Text = inputBox.Text;
                    inputBox.Text = "0";
                }
                else if (Kostpallula.IsChecked == true)
                {



                    if (luku > 99)
                    {
                        TxtKosteus.Text = "99";
                        Infobox.Text = "Max 99";

                    }
                    else if (luku < 0)
                    {
                        TxtKosteus.Text = "0";
                        Infobox.Text = "Min 0";

                    }
                    else TxtKosteus.Text = inputBox.Text;
                    inputBox.Text = "0";
                }

            }


        }

        private void BtnTyhj_Click(object sender, RoutedEventArgs e)
        {
            if (inputBox != null)
                inputBox.Text = "";
            TxtKosteus.Text = "0";
            TxtLämp.Text = "0";


        }


    }



}