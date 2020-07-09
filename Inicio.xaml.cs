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

namespace GelateriaNonnos
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnCerrar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSalir(object sender, RoutedEventArgs e)
        {
            MainWindow objLogin = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objLogin.Show();
        }
    }
}
