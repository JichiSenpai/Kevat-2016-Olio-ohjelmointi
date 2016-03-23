using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Resources;
using Windows.Media;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Harjoitustyo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public class Game
    {
        public string Name { get; set; }
        public int Release { get; set; }
        public string Platform { get; set; }

        public Game()
        {

        }
        public Game(string name, int release, string platform)
        {
            Name = name;
            Release = release;
            Platform = platform;
        }

        public override string ToString()
        {
            return Name + "\nReleased: " + Release + "\nPlatforms: " + Platform;
        }

    }

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Game SWE1R = new Game("Star Wars: Episode 1 Racer", 1999, "PC, N64, Dreamcast");
            Game SCATR = new Game("Sly Cooper and the Thievius Raccoonus", 2002, "PS2, PS3");

            textBlock.Text = SWE1R.Name;

            //<Border BorderBrush="Black" BorderThickness="0,1,0,0" Height="100">
            int teksti = 1;

            Border border = new Border();
            border.Name = "border" + teksti;
            border.BorderThickness = new Thickness(0, 5, 0, 0);
            //border.BorderBrush = new SolidColorBrush(Color.Black);
            
            TextBlock txt = new TextBlock();
            txt.Name = "textBox" + teksti;
            txt.Text = SCATR.Name;
            txt.FontSize = 30;
            txt.TextWrapping = TextWrapping.Wrap;
            teksti++;

            stack1.Children.Add(border);
            border.Child = txt;
        //    stack1.Children.Add(txt);
        }


    }
}