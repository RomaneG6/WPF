using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;

namespace MatchingGame_Grootaers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DispatcherTimer timer = new DispatcherTimer();
            int tempsEcoule = 0;
            int nbPairesTrouvees = 0;
            InitializeComponent();
            SetUpGame();
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += new EventHandler(Timer_Tick);
        }
        private void SetUpGame()
        {
            DispatcherTimer timer = new DispatcherTimer();
            int tempsEcoule = 0;
            int nbPairesTrouvees = 0;
            timer.Start();
            int index = 0;
            string nextEmoji = "";
            Random nbAlea = new Random();
            List<string> animalEmoji = new List<string>()
            {
                "🍥","🍥",
                "💕","💕",
                "🍕","🍕",
                "🌭","🌭",
                "🥡","🥡",
                "🐬","🐬",
                "🦋","🦋",
                "💮","💮",
            };
            foreach (TextBlock textBlock in grdMain.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "txtTemps")
                {
                    index = nbAlea.Next(animalEmoji.Count); // index est de type int
                                                            // nbalea est un objet de type Random()
                    nextEmoji = animalEmoji[index];// nextEmoji est de type string
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);// on retire un animal de la liste pour ne pas l’attribuer à nouveau.
                }
            }
            TextBlock derniereTBClique; // on va l’utiliser pour faire une référence à  la TextBlock sur laquelle on vient de cliquer
            bool trouvePaire = false;
            private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
            {
                TextBlock textBlockActif = sender as TextBlock;
                if (!trouvePaire)
                {
                    textBlockActif.Visibility = Visibility.Hidden;
                    derniereTBClique = textBlockActif;
                    trouvePaire = true;
                }
                else if (textBlockActif.Text == derniereTBClique.Text)
                {
                    nbPairesTrouvees++;
                    textBlockActif.Visibility = Visibility.Hidden;
                    trouvePaire = false;
                }
                else
                {
                    derniereTBClique.Visibility = Visibility.Visible;
                    trouvePaire = false;
                }

            }
            private void txtTemps_MouseDown(object sender, MouseButtonEventArgs e)
            {
                if (nbPairesTrouvees == 8)
                {
                    SetUpGame();
                }
            }


        }
    }
}
