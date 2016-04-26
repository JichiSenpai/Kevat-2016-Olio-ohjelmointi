using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using LSD.DB;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LSD
{

    public sealed partial class Main : Page
    {
        public GameView gameview { get; set; }

        public RunView runview { get; set; }

        public Main()
        {
            this.InitializeComponent();

            this.gameview = new GameView();
            this.runview = new RunView();
            /* 
           
            ----- vanhaa paskakoodia -----

            Game game1 = new Game(
                1,
                "Star Wars: Episode 1 Racer",
                1, 
                3);

            Game game2 = new Game(
               2,
               "Sly Cooper and the Thievius Raccoonus",
               2,
               2);

            Game game3 = new Game(
                3,
                "Devil May Cry 3 HD",
                3,
                1);

            Dictionary<int, Game> games = new Dictionary<int, Game>();

            games.Add(1, game1);
            games.Add(2, game2);
            games.Add(3, game3);
           

            //<Border BorderBrush="Black" BorderThickness="0,1,0,0" Height="100">
            
            
            //textBlock.Text = game1.gameName;
            int teksti = 1;

            
            //border.BorderBrush = new SolidColorBrush((Color)color.GetValue(null));
            //new SolidColorBrush(Color.Black)

            int looppi = games.Count;
            
            while (looppi != 0)
            {
               // Border border = new Border();
               // border.Name = "border" + teksti;
               // border.BorderThickness = new Thickness(0, 5, 0, 0);

                TextBlock txt = new TextBlock();
                txt.Name = "textBox" + teksti;                
                txt.Text = games[teksti].gameName;
                txt.FontSize = 30;
                txt.TextWrapping = TextWrapping.Wrap;
                teksti++;
                //  stack1.Children.Add(border);
                // border.Child = txt;
                stack1.Children.Add(txt);
                looppi--;
            }
            */

            /* vanhaa layouttia
            <StackPanel x:Name="stack1" HorizontalAlignment="Left" Width="360" Background="#FFB4B4B4" Margin="10">

        </StackPanel>
            */

        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Game game = (Game)e.ClickedItem;

            title.Text = game.gameName;
            info.Text = "Platform: " + game.gamePlatform + "\nRegion: " + game.gameRegion;
            RunList.ItemsSource = null;
            //RunList.ItemsSource = runview.Runs;

            
            var query = from runs in runview.Runs
                        join games in gameview.Games
                        on runs.gameId equals game.gameId
                        select runs;

            //List<Run> viewruns = query.Except(query.GroupBy(i => i.runId).Select(ss => ss.FirstOrDefault())).ToList();

            // RunList.ItemsSource = query.Except(query.GroupBy(x => x.runId).Select(y => y.FirstOrDefault()));

            RunList.ItemsSource = query.Distinct();

        }

        private void RunClick(object sender, ItemClickEventArgs e)
        {
           // Game game = (Game)e.ClickedItem;

          //  title.Text = game.gameName;
           // info.Text = "Platform: " + game.gamePlatform + "\nRegion: " + game.gameRegion;
        }
    }
}
