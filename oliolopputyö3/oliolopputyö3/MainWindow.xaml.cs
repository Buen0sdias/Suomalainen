using System;
using System.Collections.Generic;
using System.IO;
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

namespace oliolopputyö3
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
        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {

            // tuotteet jotka voit valita suoraan (ei kirjoituksella)

            if (cbJuoma.IsChecked == true)
            {
                tbOstokset.Text = tbOstokset.Text + tbTuote.Text + " (Juoma)  ";
            }
            if (cbKarkki.IsChecked == true)
            {
                tbOstokset.Text = tbOstokset.Text + tbTuote.Text + " (Karkki)  ";
            }
            if (cbSipsi.IsChecked == true)
            {
                tbOstokset.Text = tbOstokset.Text + tbTuote.Text + " (Sipsi)  ";
            }
            if (cbVaate.IsChecked == true)
            {
                tbOstokset.Text = tbOstokset.Text + tbTuote.Text + " (Vaate)  ";
            }



        }
        //Tämä kohta on se jonka pitäisi siirtää tekstin toiseen tiedostoon. Ja kun syötät ne kertoo onko syötetty vai eikö ole?
        private void btnTotext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbSuccessful.Text = string.Empty;
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter file = new StreamWriter(System.IO.Path.Combine(docPath, "GameList.txt")))
                {
                    file.WriteLine(tbOstokset.Text);
                }
                tbSuccessful.Text = "Ostokset on maksettu.";
                tbOstokset.Text = string.Empty;
            }

            catch
            {
                tbSuccessful.Text = string.Empty;
                tbSuccessful.Text = "Error";
                tbOstokset.Text = string.Empty;



            }




        }
        //Tässä kohtaan luetellaan eri genret. Elikkä kun painat vaikka kauhu genren se menee "ostoksen perään perään"
        private void cbJuoma_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void cbKarkki_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void cbSipsi_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void cbVaate_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void Off_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
