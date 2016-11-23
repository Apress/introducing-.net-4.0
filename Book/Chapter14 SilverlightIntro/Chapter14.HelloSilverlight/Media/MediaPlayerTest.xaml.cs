using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Chapter14.HelloSilverlight.Media
{
    public partial class MediaPlayerTest : UserControl
    {
        public MediaPlayerTest()
        {

            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MediaTest_Loaded);
        }

        void MediaTest_Loaded(object sender, RoutedEventArgs e)
        {
            this.cmdPlay.Click += new RoutedEventHandler(cmdPlay_Click);
            this.cmdStop.Click += new RoutedEventHandler(cmdStop_Click);
            this.cmdPause.Click += new RoutedEventHandler(cmdPause_Click);
        }

        void cmdPause_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Pause();
        }


        void cmdStop_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Stop();
        }

        void cmdPlay_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Play();
        }

    }
}
