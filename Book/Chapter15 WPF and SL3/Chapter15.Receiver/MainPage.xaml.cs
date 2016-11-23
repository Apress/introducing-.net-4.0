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

namespace Chapter15.Receiver
{
    public partial class MainPage : UserControl
    {
       

        LocalMessageReceiver Channel1Receiver = new LocalMessageReceiver("Channel1");

        public MainPage()
        {

            Channel1Receiver.MessageReceived += new EventHandler<MessageReceivedEventArgs>(Channel1Receiver_MessageReceived);
            Channel1Receiver.Listen();
            InitializeComponent();
        }

        void Channel1Receiver_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            txtMessage.Text = "" + e.Message.ToString();
        }

    }
}
