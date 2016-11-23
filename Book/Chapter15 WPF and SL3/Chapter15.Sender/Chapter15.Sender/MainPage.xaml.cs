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
using System.Windows.Messaging;

namespace Chapter15.Sender
{
    public partial class MainPage : UserControl
    {
      

        LocalMessageSender Channel1 = new LocalMessageSender("Channel1");

        public MainPage()
        {
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
            Channel1.SendCompleted += new EventHandler<SendCompletedEventArgs>(Channel1_SendCompleted);
            InitializeComponent();
        }

        void Channel1_SendCompleted(object sender, SendCompletedEventArgs e)
        {
            //Code to run after message is sent
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.cmdSendMessage.Click += new RoutedEventHandler(cmdSendMessage_Click);
        }

        void cmdSendMessage_Click(object sender, RoutedEventArgs e)
        {
            Channel1.SendAsync("Hello from sender project");
        }

      

    }
}
