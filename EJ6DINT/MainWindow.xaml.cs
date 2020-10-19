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

namespace EJ6DINT
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            imagen1Image.Opacity = 0.5;
            imagen2Image.Opacity = 0.5;
            imagen3Image.Opacity = 0.5;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image imagenes = sender as Image;
            imagenes.Opacity = 1;
     
            
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Image imagenes = sender as Image;
            imagenes.Opacity = 0.5;
        
        }
    }
}
