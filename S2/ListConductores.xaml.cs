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

namespace S2
{
    /// <summary>
    /// Lógica de interacción para ListConductores.xaml
    /// </summary>
    public partial class ListConductores : Window

    {

        public class Conductor
        {
            public string Nombre { get; set; }
            public string Licencia { get; set; }
            public string Transporte { get; set; }
        }

        public List<Conductor> Conductores { get; set; }

        public ListConductores()
        {
            InitializeComponent();

            // Emular datos
            Conductores = new List<Conductor>
        {
            new Conductor { Nombre = "Juan Perez", Licencia = "ABC123", Transporte = "Camión 1" },
            new Conductor { Nombre = "Maria Lopez", Licencia = "XYZ789", Transporte = "Camión 2" },
            new Conductor { Nombre = "Carlos Gómez", Licencia = "DEF456", Transporte = "Camión 3" }
        };

            // Enlazar datos al DataGrid
            this.DataContext = this;
        }
        private void AddConductor_Click(object sender, RoutedEventArgs e)
        {
            AddConductor ventanaRegistro = new AddConductor();
            ventanaRegistro.ShowDialog();
        }
        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
