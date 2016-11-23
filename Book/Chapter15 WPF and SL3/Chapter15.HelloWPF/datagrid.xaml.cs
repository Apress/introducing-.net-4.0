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

namespace Chapter15.HelloWPF
{
    /// <summary>
    /// Interaction logic for datagrid.xaml
    /// </summary>
    public partial class datagrid : Page
    {
        public datagrid()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(datagrid_Loaded);
        }

        void datagrid_Loaded(object sender, RoutedEventArgs e)
        {

            var array = new List<Person>();

            array.Add(new Person{FirstName= "Alex", LastName= "Mackey"});
            array.Add(new Person{FirstName= "Bob", LastName= "Mackey"});
            array.Add(new Person{FirstName= "Jim", LastName= "Mackey"});
            array.Add(new Person { FirstName = "Phil", LastName = "Mackey" });
         
            dataGrid1.ItemsSource = array;
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
