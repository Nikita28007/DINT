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

namespace EJ3dint
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

        private void opacidadAltaTextbloc_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 1.0;
        }
        private void opacidadMediaTextbloc_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.60;
        }
        private void opacidadBajaTextbloc_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.30;
        }

        private void rellenoTextBloc_Checked(object sender, RoutedEventArgs e)
        {
           imagenImage.Stretch = Stretch.Fill;
        }

        private void uniformeTextBloc_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Uniform;
        }

        private void rellenoUniformeTextBloc_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.UniformToFill;
        }

        private void sinAjusteTextBloc_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.None;
        }

    }
}
