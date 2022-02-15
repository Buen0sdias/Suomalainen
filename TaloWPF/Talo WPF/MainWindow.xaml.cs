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

namespace Talo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Double Henkilöautot = 20;

        private bool _IsOn;
        public bool IsOn

        {
            get
            { 
                return _IsOn;
            }

            set
            {
                _IsOn = value;
                BTNvalot.Content = _IsOn ? "Valot on Päällä" : "Valot ovat pois päältä";
            }



        }

        private bool _IssOn;

        public bool IssOn

        {
            get
            {
                return _IssOn;
            }

            set
            {
                _IssOn = value;
                Lukot.Content = _IssOn ? "Lukko on kiinni " : "lukko on auki";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IssOn = !IssOn;
        }

        private void BTNvalot_Click(object sender, RoutedEventArgs e)
        {
            IsOn = !IsOn;
        }

        private void BTNlämpö_Click(object sender, RoutedEventArgs e)
        {
            Henkilöautot = Henkilöautot + 0.5;
            Lampotila.Text = Henkilöautot.ToString();
        }

        private void BTNlämpö2_Click(object sender, RoutedEventArgs e)
        {
            Henkilöautot = Henkilöautot - 0.5;

            Lampotila.Text = Henkilöautot.ToString();
        }
    }
}
