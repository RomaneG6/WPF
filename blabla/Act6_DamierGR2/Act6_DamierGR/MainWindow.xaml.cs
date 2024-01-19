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

namespace Act6_DamierGR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreationGrid();
        }
        public void CreationGrid()
        {
            ColumnDefinition[] col = new ColumnDefinition[10];
            RowDefinition[] row = new RowDefinition[10];
            Button[,] Btn = new Button[10, 10];
            int n = 1;

            for (int i = 0; i < col.Length; i++)
            {
                col[i] = new ColumnDefinition();
                row[i] = new RowDefinition();
                Damiers.RowDefinitions.Add(row[i]);
                Damiers.ColumnDefinitions.Add(col[i]);
                if (i % 2 != 0)
                {
                    for (int k = 9; k > -1; k--)
                    {
                        Btn[i, k] = new Button();
                        Btn[i, k].Content = n;
                        Grid.SetRow(Btn[i, k], i);
                        Grid.SetColumn(Btn[i, k], k);
                        Damiers.Children.Add(Btn[i, k]);
                        n++;
                        Btn[i, k].Foreground = Brushes.Red;
                        if ((i + k) % 2 == 1)
                        {
                            Btn[i, k].Background = Brushes.White;
                        }
                        else
                        {
                            Btn[i, k].Background = Brushes.Black;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < row.Length; j++)
                    {
                        Btn[i, j] = new Button();
                        Btn[i, j].Content = n;
                        Grid.SetRow(Btn[i, j], i);
                        Grid.SetColumn(Btn[i, j], j);
                        Damiers.Children.Add(Btn[i, j]);
                        n++;
                        Btn[i, j].Foreground = Brushes.Red;
                        if ((i + j) % 2 == 1)
                        {
                            Btn[i, j].Background = Brushes.White;
                        }
                        else
                        {
                            Btn[i, j].Background = Brushes.Black;
                        }
                    }
                }
            }
        }
    }
}
