using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Chapter15.Windows7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            TaskbarItemInfo taskBarItemInfo = new TaskbarItemInfo();

            taskBarItemInfo.ProgressState = TaskbarItemProgressState.Normal;
            this.TaskbarItemInfo = taskBarItemInfo;
            taskBarItemInfo.ProgressValue = 0.5d;
 
        }

       

        private void ConfigureProgressBar()
        {
           
        }
    }
}
