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

namespace Ej8Dint
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int num;
            TextBlock textBlock = sender as TextBlock;
            if (Keyboard.IsKeyDown(Key.F2) || textBox.Tag.Equals("3"))
            {
                if (textBlock.Tag.Equals("t3"))
                {
                    if (!int.TryParse(textBox.Text, out num))
                    {
                        textBox.Text = "Edad incorecta"; 
                    }
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            TextBlock textBlock = sender as TextBlock;
            if (e.Key == Key.F1 || textBox.Tag.Equals("1"))
            {
                if (textBlock.Tag.Equals("t1"))
                {
                    textBlock.Text = "Nombre del cliente";
                }  
            }
            if (e.Key == Key.F2 || textBox.Tag.Equals("2"))
            {
                if (textBlock.Tag.Equals("t2"))
                {
                    textBlock.Text = "Apellido del cliente";
                }

            }

            if (e.Key == Key.F2 || textBox.Tag.Equals("3"))
            {
                if (textBlock.Tag.Equals("t3"))
                {
                    textBlock.Text = "Nombre del cliente";
                }
            }

        }
    }
}
