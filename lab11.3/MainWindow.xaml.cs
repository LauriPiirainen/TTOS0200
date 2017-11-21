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

namespace Lab11._3wpf
{

    public partial class MainWindow : Window
    {




        public MainWindow()
        {
            InitializeComponent();

        }


        private void Tyhjennä_Click(object sender, RoutedEventArgs e)
        {
            Txtbox.Text = "";
        }


        private void Arvo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a;
                Random rng = new Random();
                if (int.TryParse(Rivienmäärä.Text, out a))
                {
                    if (Peli.Text == "Lotto")
                    {
                        int linja = 0;
                        string rivit = null;
                        for (int y = 0; y < a; y++)
                        {
                            List<int> lottonum = new List<int>();
                            int num;
                            for (int i = 0; i < 7; i++)
                            {
                                do
                                {
                                    num = rng.Next(1, 41);
                                } while (lottonum.Contains(num));
                                lottonum.Add(num);
                            }
                            linja++;
                            rivit += "Arvottu rivi " + linja + ": " + String.Join(", ", lottonum.ToArray()) + "\n";
                        }

                        Txtbox.Text = rivit;
                    }

                    else if (Peli.Text == "Viking Lotto")
                    {
                        int linja = 0;
                        string rivit = null;
                        for (int y = 0; y < a; y++)
                        {
                            List<int> lottonum = new List<int>();
                            int num;
                            for (int i = 0; i < 6; i++)
                            {
                                do
                                {
                                    num = rng.Next(1, 49);
                                } while (lottonum.Contains(num));
                                lottonum.Add(num);
                            }
                            linja++;
                            rivit += "Arvottu rivi " + linja + ": " + String.Join(", ", lottonum.ToArray()) + "\n";
                        }

                        Txtbox.Text = rivit;

                    }

                    else if (Peli.Text == "Eurojackpot")
                    {
                        int linja = 0;
                        string rivit = null;
                        for (int y = 0; y < a; y++)
                        {
                            List<int> lottonum = new List<int>();
                            int num;
                            for (int i = 0; i < 5; i++)
                            {
                                do
                                {
                                    num = rng.Next(1, 51);
                                } while (lottonum.Contains(num));
                                lottonum.Add(num);
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                do
                                {
                                    num = rng.Next(1, 10);
                                } while (lottonum.Contains(num));
                                lottonum.Add(num);
                            }
                            linja++;
                            rivit += "Arvottu rivi " + linja + ": " + String.Join(", ", lottonum.ToArray()) + "\n";
                        }

                        Txtbox.Text = rivit;
                    }

                }
                else
                {
                    Txtbox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}