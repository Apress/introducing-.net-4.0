using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Shell;

namespace Chapter15.Windows7
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
          
        public App()
        {
           
        }

       

        private void CreateJumpList()
        {

            JumpList appJumpList = new JumpList();

            //Configure a JumpTask
            JumpTask jumpTask1 = new JumpTask();
            jumpTask1.ApplicationPath = @"C:\Program Files (x86)\Internet Explorer\iexplore.exe";
            jumpTask1.IconResourcePath = @"C:\Program Files (x86)\Internet Explorer\iexplore.exe";
          
            jumpTask1.Title = "IE";
            jumpTask1.Description = "Open IE";

            JumpTask jumpTask2 = new JumpTask();
            jumpTask2.ApplicationPath = @"C:\Windows\System32\notepad.exe";
            jumpTask2.IconResourcePath = @"C:\Windows\System32\notepad.exe";
          
            jumpTask2.Title = "Calculator";
            jumpTask2.Description = "Open Calc";
         
            appJumpList.JumpItems.Add(jumpTask1);
            appJumpList.JumpItems.Add(jumpTask2);

            JumpList.SetJumpList(App.Current, appJumpList);
        }
    }

     

}
