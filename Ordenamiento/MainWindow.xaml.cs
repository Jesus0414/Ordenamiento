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
            miLista.Add(5);
            lstNumeros.ItemsSource = miLista;
        }

        private void btnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /*int i;int j;for(i=0; i> miLista.Count; i++){for (j = 1; j > miLista.Count; j++){var temp = miLista[j];miLista[j] = miLista[j+1];miLista[j+1] = temp;}}*/
            int gap, temp, i;
            gap = miLista.Count / 2;

            while (gap > 0)
            {
                for(i = 0; i < miLista.Count; i++)
                {
                    if (gap + i < miLista.Count && miLista[i] > miLista[gap + i])
                    {
                        temp = miLista[i];
                        miLista[i] = miLista[gap + i];
                        miLista[gap + i] = temp;
                    }

                }
                gap--;
            }

        }

        private void btnBubble_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < miLista.Count - 1; i++)
                {
                    if (miLista[i] > miLista[i + 1])
                    {
                        int temp = miLista[i];
                        miLista[i] = miLista[i + 1];
                        miLista[i + 1] = temp;
                        intercambio = true;
                    }
                }
            /*int i, j, temp;for (i = 0; i < miLista.Count; i++){for (j = 0; j < i + 1; j++){if(j + 1 < miLista.Count && miLista[j] > miLista[j + 1]){temp = miLista[j];miLista[j] = miLista[j + 1];miLista[j + 1] = temp;}}}intercambio = true;break;*/
            } while (intercambio);
           
        }
    }
}
