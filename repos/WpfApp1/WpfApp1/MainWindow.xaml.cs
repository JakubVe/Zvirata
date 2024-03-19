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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public List<Zvire> Zvirata {get;set;}
        public MainWindow()
        {
            InitializeComponent();
            Zvirata = new List<Zvire>
            {
                new pes(),
                new Kocka(),
                new Ptak(),
            };
            List.ItemsSource = Zvirata;
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Zvire zvire = (Zvire)List.SelectedItem;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Jméno: {zvire.Jmeno}");
            sb.AppendLine($"Počet noh: {zvire.Nohy}");
            sb.AppendLine($"Barva: {zvire.Barva}");
            sb.AppendLine($"Umí látat: {zvire.Leta}");

            if (zvire is pes pes)
            {
                sb.AppendLine($"Rasa:{pes.Rasa}");
            }
            else if (zvire is Kocka Kocka)
            {
                sb.AppendLine($"Počet Chloupků: {Kocka.Chloupky}");
            }
            else if (zvire is  Ptak ptak)
            {
                sb.AppendLine($"Vodní druh:{ptak.Vodni}");
            }
            MessageBox.Show(sb.ToString());
            
            

            //MessageBox.Show($"Jméno: {zvire.Jmeno}\n Zvíře: {zvire.GetType().Name}\n Počet nohou: {zvire.Nohy}\n Umí létat: {zvire.Leta}\n Barva: {zvire.Barva}\n Zvuk: {zvire.VydejZvuk()}");
        }
    }

    
}
