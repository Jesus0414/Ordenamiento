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
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(18);
            miLista.Add(7);
            miLista.Add(4);
            miLista.Add(9);
            miLista.Add(11);
            miLista.Add(10);
            miLista.Add(1);
            lstNumeros.ItemsSource = miLista;
        }

        private void btnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            var temp = miLista[0];
            miLista[0] = miLista[3];
            miLista[3] = temp;
        }
    }
}
