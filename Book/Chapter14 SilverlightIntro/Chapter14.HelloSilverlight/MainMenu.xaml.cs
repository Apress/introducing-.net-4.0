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

namespace Chapter14.HelloSilverlight
{
    public partial class MainMenu : UserControl
    {
     
        public MainMenu()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainMenu_Loaded);
          
            //string XAMLContent = @"<TextBlock  xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""  Canvas.Left=""200"" Canvas.Top=""100"" Text=""Hello""></TextBlock>";
            //TextBlock TextBlock = (TextBlock)System.Windows.Markup.XamlReader.Load(XAMLContent);
            //LayoutRoot.Children.Add(TextBlock);
        }

        void MainMenu_Loaded(object sender, RoutedEventArgs e)
        {
            this.cmdStackPanel.Click += new RoutedEventHandler(cmdStackPanel_Click);
            this.cmdGrid.Click += new RoutedEventHandler(cmdGrid_Click);
            this.cmdAnimation.Click += new RoutedEventHandler(cmdAnimation_Click);
            this.cmdCallJS.Click += new RoutedEventHandler(cmdCallJavaScript_Click);
            this.cmdMediaTest.Click += new RoutedEventHandler(cmdMediaTest_Click);
            this.cmdDataBind.Click += new RoutedEventHandler(cmdDataBind_Click);
        }

        void cmdStackPanel_Click(object sender, RoutedEventArgs e)
        {
            PageNavigator.LoadPage(new Layout.StackPanelTest());
        }

        void cmdGrid_Click(object sender, RoutedEventArgs e)
        {
            PageNavigator.LoadPage(new Layout.GridTest());
        }

        void cmdAnimation_Click(object sender, RoutedEventArgs e)
        {
            PageNavigator.LoadPage(new Animation.Animation());
        }


        void cmdCallJavaScript_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Browser.HtmlPage.Window.Invoke("ShowMessage", "This function was called from Silverlight");
            System.Windows.Browser.HtmlPage.Document
            .GetElementById("txtHelloFromSilverlight")
            .SetProperty("value", "Hello from Silverlight");
        }

        [System.Windows.Browser.ScriptableMember()]
        public string CallMeFromJS()
        {
            return "Silverlight function called from JS";
        }

        void cmdMediaTest_Click(object sender, RoutedEventArgs e)
        {
            PageNavigator.LoadPage(new Media.MediaPlayerTest());
        }

        void cmdDataBind_Click(object sender, RoutedEventArgs e)
        {
            PageNavigator.LoadPage(new DataBinding.DataBindingTest());
        }


    }
}
