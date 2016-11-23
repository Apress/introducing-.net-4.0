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

namespace Chapter14.HelloSilverlight.Animation
{
    public partial class Animation : UserControl
    {
       
        Storyboard StoryBoard = new Storyboard();
        Storyboard StoryBoard2 = new Storyboard();

        int Count = 0;

        public Animation()
        {
            this.Loaded += new RoutedEventHandler(Animation_Loaded);
            StoryBoard.Completed += new EventHandler(StoryBoard_Completed);
            

            InitializeComponent();
        }

        public void Animation_Loaded(object sender, RoutedEventArgs e)
        {
            StoryBoard.Duration = TimeSpan.FromMilliseconds(10);
            StoryBoard.Begin();

            rectAnimation.MouseLeftButtonDown += new MouseButtonEventHandler(rectAnimation_MouseLeftButtonDown);
        }

        void StoryBoard_Completed(object sender, EventArgs e)
        {
            Canvas.SetTop(rectAnimation, Count);
            Canvas.SetLeft(rectAnimation, Count);
            rectAnimation.Opacity = 0.01 * Convert.ToDouble(Count);
            Count += 1;

            StoryBoard.Begin();

            if (Count == 100) 
                StoryBoard.Stop(); 
        }

       

        void rectAnimation_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rectAnimation.Fill = new SolidColorBrush(Colors.Yellow);
            rectAnimation.Opacity = 1;
            StoryBoard.Stop();

            StoryBoard2.Completed += new EventHandler(StoryBoard2_Completed);
            StoryBoard2.Duration = TimeSpan.FromMilliseconds(10);
            StoryBoard2.Begin();
        }
        void StoryBoard2_Completed(object sender, EventArgs e)
        {
            Canvas.SetLeft(rectAnimation, Count);
            Count += 1;
            StoryBoard2.Begin();
        }
    }
}
