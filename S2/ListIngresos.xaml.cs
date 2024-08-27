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
    /// Lógica de interacción para ListIngresos.xaml
    /// </summary>
    public partial class ListIngresos : Window
    {

        public class Ingreso
        {
            public DateTime Fecha { get; set; }
            public string Placa { get; set; }
            public string Turno { get; set; }
            public string Conductor { get; set; }
            public string Producto { get; set; }
            public double Peso { get; set; }
            public string Transporte { get; set; }
        }

        public List<Ingreso> Ingresos { get; set; }

        public ListIngresos()
        {
            InitializeComponent();

            // Emular datos
            Ingresos = new List<Ingreso>
        {
            new Ingreso { Fecha = DateTime.Now, Placa = "ABC123", Turno = "Mañana", Conductor = "Juan Perez", Producto = "Granos", Peso = 1000, Transporte = "Camión 1" },
            new Ingreso { Fecha = DateTime.Now, Placa = "DEF456", Turno = "Tarde", Conductor = "Maria Lopez", Producto = "Líquidos", Peso = 1500, Transporte = "Camión 2" },
            new Ingreso { Fecha = DateTime.Now, Placa = "GHI789", Turno = "Noche", Conductor = "Carlos Gómez", Producto = "Químicos", Peso = 2000, Transporte = "Camión 3" }
        };

            // Enlazar datos al DataGrid
            this.DataContext = this;
        }
        private void AddIngresos_Click(object sender, RoutedEventArgs e)
        {
            Window1 ventanaRegistro = new Window1();
            ventanaRegistro.ShowDialog();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
