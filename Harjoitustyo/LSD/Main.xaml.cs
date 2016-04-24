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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LSD
{
    public class Game
    {
        public int gameId { get; set; }
        public string gameName { get; set; }
        public int regionId { get; set; }
        public int platformId { get; set; }

        public Game()
        {

        }
        public Game(int gameid, string gamename, int region, int platform)
        {
            gameId = gameId;
            gameName = gamename;
            regionId = region;
            platformId = platform;
        }

        public override string ToString()
        {
            return gameName + "\nRegion: " + regionId + "\nPlatform: " + platformId;
        }

    }
    public sealed partial class Main : Page
    {
        public Main()
        {
            this.InitializeComponent();
            

            Game SWE1R = new Game(
                1,
                "Star Wars: Episode 1 Racer",
                1, 
                3);

            Game DMC3HD = new Game(
               2,
               "Sly Cooper and the Thievius Raccoonus",
               2,
               2);

            Game SCATR = new Game(
                3,
                "Sly Cooper and the Thievius Raccoonus",
                3,
                1);

           

            textBlock.Text = SWE1R.gameName;

            //<Border BorderBrush="Black" BorderThickness="0,1,0,0" Height="100">
            int teksti = 1;

            Border border = new Border();
            border.Name = "border" + teksti;
            border.BorderThickness = new Thickness(0, 5, 0, 0);

            //border.BorderBrush = new SolidColorBrush((Color)color.GetValue(null));
            //new SolidColorBrush(Color.Black)

            TextBlock txt = new TextBlock();
            txt.Name = "textBox" + teksti;
            txt.Text = SCATR.gameName;
            txt.FontSize = 30;
            txt.TextWrapping = TextWrapping.Wrap;
            teksti++;

            stack1.Children.Add(border);
            border.Child = txt;
            //    stack1.Children.Add(txt);
        }
    }
}
