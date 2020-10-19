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

namespace Ej7DINT
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton boton = sender as RadioButton;

            if (boton.Tag.Equals("1"))
            {
        
                TextoTextBlock.FontSize = 36;
            }
            else if (boton.Tag.Equals("2"))
            {
                TextoTextBlock.FontSize = 48;
                
            }
            else if (boton.Tag.Equals("3"))
            {
                TextoTextBlock.FontSize = 72;
            }
           
           
        }


    }
}
