
    using System;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Ink;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;

    namespace Chapter14.HelloSilverlight
    {
        public class PageNavigator
        {
            private static Grid RootLayoutElement;

            static PageNavigator()
            {
                RootLayoutElement = Application.Current.RootVisual as Grid;
            }

            public static void LoadPage(UserControl NewControl)
            {

                //Get reference to old control
                UserControl OldUserControl = RootLayoutElement.Children[0] as UserControl;

                //Add new control
                RootLayoutElement.Children.Add(NewControl);

                //Remove old control
                RootLayoutElement.Children.Remove(OldUserControl);
            }
        }
    }
