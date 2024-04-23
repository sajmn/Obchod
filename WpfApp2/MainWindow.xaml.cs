using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Polozka> Polozky { get; set; }
        public MainWindow()
        {
            Polozky = new();
            InitializeComponent();
            seznam.ItemsSource = Polozky;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nazev = ProNazev.Text;
            string pocet = ProPocet.Text;
            int cena = int.Parse(ProCenu.Text);

            Polozka Nova = new Polozka(VytvorId(), nazev, pocet, cena);
            Polozky.Add(Nova);

        }

        private int VytvorId() => Polozky.Count + 1;


      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Polozka? info = seznam?.SelectedItem as Polozka ?? new Polozka(-1, "Neznámá položka", "Položka nenalezena", 0);
            MessageBox.Show($"{info.Id} {info.Nazev} {info.Pocet} {info.Cena}");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Polozka? hledany = seznam?.SelectedItem as Polozka;
            if (hledany != null)
            {
                Editace edit = new Editace(hledany);              
                Editace editaceOkno = new Editace(hledany);
                editaceOkno.ShowDialog();
            }


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Polozka? hledany = seznam?.SelectedItem as Polozka;
            MessageBoxResult volba = MessageBox.Show($"Odebrat {hledany.Nazev}?", "Odebrat", MessageBoxButton.YesNo);
            if (volba == MessageBoxResult.Yes)
            {
                Polozky.Remove(hledany);
                seznam.ItemsSource = null;
                seznam.ItemsSource = Polozky;
            }
            else
            {
                MessageBox.Show("Položka nebyl nalezena"); 
            }
        }

       
    }
}