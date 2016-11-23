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
using System.Windows.Data;

namespace Chapter14.HelloSilverlight.DataBinding
{
    public partial class DataBindingTest : UserControl
    {
       

        public List<Movie> MoviesList = new List<Movie>();

        public DataBindingTest()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(DataBindingTest_Loaded);
        }

        void DataBindingTest_Loaded(object sender, RoutedEventArgs e)
        {

            //Create items for binding
            PopulateItems();

            //Create binding programmatically
            CreateBinding_programmatically();

            //Set binding declaratively
            txtDeclaration.DataContext = MoviesList[0];

            this.cmdChangeTitle.Click += new RoutedEventHandler(cmdChangeTitle_Click);

            //Set up two way binding
            txtTwoWay.DataContext = MoviesList[0];

            //Bind listbox
            lstItems.ItemsSource = MoviesList;

            //Bind listbox with template
            lstItemsWithTemplate.ItemsSource = MoviesList;

            dgSimple.ItemsSource = MoviesList;

            dgSpecify.ItemsSource = MoviesList;

        }

        public void PopulateItems()
        {
            //Create a list of items
            Movie Movie1 = new Movie();
            Movie Movie2 = new Movie();
            Movie Movie3 = new Movie();

            Movie1.Title = "Terminator";
            Movie1.Length = "120";

            Movie2.Title = "Conan the barbarian";
            Movie2.Length = "124";

            Movie3.Title = "Robocop";
            Movie3.Length = "130";

            MoviesList.Add(Movie1);
            MoviesList.Add(Movie2);
            MoviesList.Add(Movie3);
        }

        public void CreateBinding_programmatically()
        {
            //Creates a binding programmatically
            Binding NewBinding = new Binding("Now");
            NewBinding.Source = System.DateTime.Now;
            NewBinding.Mode = BindingMode.OneWay;
            txtBoundProgrammatically.SetBinding(TextBox.TextProperty, NewBinding);
        }


        void cmdChangeTitle_Click(object sender, RoutedEventArgs e)
        {
            //Change an item in the list 
            MoviesList[0].Title = "Title Changed";
        }  


        public class Movie : System.ComponentModel.INotifyPropertyChanged
        {

            // implement the required event for the interface        
            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
            private string _title;
            private string _length;

            public string Title
            {
                get
                {
                    return _title;
                }

                set
                {
                    _title = value;
                    //Tell Silverlight Title property has changed
                    NotifyChanged("Title");
                }

            }
            public string Length
            {
                get
                {
                    return _length;
                }

                set
                {
                    _length = value;
                    //Tell Silverlight Length property has changed
                    NotifyChanged("Length");
                }

            }


            //This procedure raises the event Property changed so Silverlight knows when a value has changed       
            public void NotifyChanged(string PropertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(PropertyName));
                }
            }
        }

    }
}
