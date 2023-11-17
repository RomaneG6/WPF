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

namespace UAA14_I3_Grootaers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Calculer.Click += new RoutedEventHandler(Calculer_Click);
            Nombre1.KeyDown += new KeyEventArgs(Nombre_key);
            Nombre2.KeyDown += new KeyEventArgs(Nombre_key);
        }

        private void Calculer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nombre_key(object sender, KeyEventArgs e)
        {

        }
    }
}
