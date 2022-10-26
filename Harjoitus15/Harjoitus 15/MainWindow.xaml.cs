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

namespace Harjoitus_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int henkilöautot = 0;
        private int kuormaautot = 0;
        public MainWindow()
        {
            InitializeComponent();

            tbHenkilöauto.Text = henkilöautot.ToString();
            tbKuormaauto.Text = kuormaautot.ToString();

        }

        private void btnkuorma_auto_Click(object sender, RoutedEventArgs e)
        {
            henkilöautot++;
            tbHenkilöauto.Text = henkilöautot.ToString();
        }

        private void btnhenkilöauto_Click(object sender, RoutedEventArgs e)
        {
            henkilöautot++;
            tbKuormaauto.Text = kuormaautot.ToString();

        }
    }
}
