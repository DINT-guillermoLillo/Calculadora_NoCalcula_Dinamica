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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock texto = new TextBlock();
            Viewbox viewbox = new Viewbox();
            Button boton = new Button();
            int tag = 1;
            Grid grid = (Grid)this.Content;

            for (int x = 1; x <= 3; x++) {
                for (int i = 0; i < 3; i++)
                {
                    texto.Text = tag.ToString();
                    
                    viewbox.Child = texto;
                    
                    boton.Content = viewbox;
                        boton.Tag = tag;
                        boton.Margin = new Thickness(5);
                        boton.Click += Button_Click;

                    grid.Children.Add(boton);
                        Grid.SetColumn(boton, i);
                        Grid.SetRow(boton, x);

                    boton = new Button();
                    viewbox = new Viewbox();
                    texto = new TextBlock();

                    tag++;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextoPrincipal.Text += ((Button)sender).Tag;
        }
    }
}
