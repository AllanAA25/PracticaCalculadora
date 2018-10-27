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

namespace PracticaCalculadora
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

        LogicaCalculadora lc = new LogicaCalculadora();

        private void CalcularArea(object sender, RoutedEventArgs e)
        {
            double? resultado = lc.CalcularArea(txtValor1.Text, txtValor2.Text, txtValor3.Text, txtValor4.Text, txtValor5.Text, cmbFigura.Text);
            string resultadox = (resultado != null) ? resultado.ToString() : "Error";
            txtResultado.Text = resultadox;
        }

        private void CalcularPerimetro(object sender, RoutedEventArgs e)
        {
            double? resultado = lc.CalcularPerimetro(txtValor1.Text, txtValor2.Text, txtValor3.Text, txtValor4.Text, txtValor5.Text, cmbFigura.Text);
            string resultadox = (resultado != null) ? resultado.ToString() : "Error";
            txtResultado.Text = resultadox;
        }

        private void CalcularVolumen(object sender, RoutedEventArgs e)
        {
            double? resultado = lc.CalcularVolumen(txtValor1.Text, txtValor2.Text, txtValor3.Text, txtValor4.Text, txtValor5.Text, cmbFigura.Text);
            string resultadox = (resultado != null) ? resultado.ToString() : "Error";
            txtResultado.Text = resultadox;
        }
    }
}
