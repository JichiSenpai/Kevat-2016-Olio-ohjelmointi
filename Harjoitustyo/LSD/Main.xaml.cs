using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public string platformId { get; set; }

        public Game()
        {

        }
        public Game(string gamename, int region, string platform)
        {
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

            Game SWE1R = new Game("Star Wars: Episode 1 Racer", 1999, "PC, N64, Dreamcast");
            Game SCATR = new Game("Sly Cooper and the Thievius Raccoonus", 2002, "PS2, PS3");

            textBlock.Text = SWE1R.gameName;

            //<Border BorderBrush="Black" BorderThickness="0,1,0,0" Height="100">
            int teksti = 1;

            Border border = new Border();
            border.Name = "border" + teksti;
            border.BorderThickness = new Thickness(0, 5, 0, 0);
            //border.BorderBrush = new SolidColorBrush(Color.Black);

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
