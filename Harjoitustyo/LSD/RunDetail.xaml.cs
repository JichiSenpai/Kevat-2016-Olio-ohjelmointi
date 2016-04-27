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
using LSD.DB;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LSD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RunDetail : Page
    {

        public RunDetail()
        {
            this.InitializeComponent();

            
        }

        //sivulle tullessa kaiken datan valmistelu
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Run run = e.Parameter as Run;

            
                time.Text = "Run Time: " + run.runTime;
                platform.Text = "Platform: " + run.gamePlatform;
                region.Text = "Region: " + run.gameRegion;
                runner.Text = "Runner: " + run.runRunner;
                comment.Text = "Runner Comment:\n" + run.runComment;
        }

        //takaisin pääsivulle
        private void BackToMain(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Main), null);

        }
    }
}
