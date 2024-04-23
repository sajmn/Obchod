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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interakční logika pro Editace.xaml
    /// </summary>
    public partial class Editace : Window
    {
        public Polozka P { get; set; }
        public Editace(Polozka p)
        {
            P = p;
            InitializeComponent();
            DataContext = P;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            P.Nazev = ProNazev.Text;
            P.Pocet = ProPocet.Text;       
            P.Cena = int.Parse(ProCenu.Text);


            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
