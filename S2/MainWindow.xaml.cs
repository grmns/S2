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

namespace S2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {
            ListIngresos ventanaRegistro = new ListIngresos();
            ventanaRegistro.ShowDialog();
        }
        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            ListConductores ventanaRegistro = new ListConductores();
            ventanaRegistro.ShowDialog();
        }
        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }

}
