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

namespace Laskin22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float Arvo1;
        float Arvo2;
        public MainWindow()
        {
            InitializeComponent();
            Luku1.Text = "";
            Luku2.Text = "";
        }

        private void Summa_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                Arvo1 = Convert.ToSingle(Luku1.Text);
                Arvo2 = Convert.ToSingle(Luku2.Text);
                Tulos.Text = Convert.ToString(Arvo1 + Arvo2);
                Luku1.Text = "";
                Luku2.Text = "";
            }
            catch (Exception ex)
            {
               Tulos.Text = "Olet tyhmä";
            }
        }

        private void Vähennys_Click(object sender, RoutedEventArgs e)
        {
            Arvo1 = Convert.ToSingle(Luku1.Text);
            Arvo2 = Convert.ToSingle(Luku2.Text);
            Tulos.Text = Convert.ToString(Arvo1 - Arvo2);
            Luku1.Text = "";
            Luku2.Text = "";
        }

        private void Jako_Click(object sender, RoutedEventArgs e)
        {
            Arvo1 = Convert.ToSingle(Luku1.Text);
            Arvo2 = Convert.ToSingle(Luku2.Text);
            Tulos.Text = Convert.ToString(Arvo1 / Arvo2);
            Luku1.Text = "";
            Luku2.Text = "";
        }

        private void Kerto_Click(object sender, RoutedEventArgs e)
        {
            Arvo1 = Convert.ToSingle(Luku1.Text);
            Arvo2 = Convert.ToSingle(Luku2.Text);
            Tulos.Text = Convert.ToString(Arvo1 * Arvo2);
            Luku1.Text = "";
            Luku2.Text = "";
        }
    }
}
