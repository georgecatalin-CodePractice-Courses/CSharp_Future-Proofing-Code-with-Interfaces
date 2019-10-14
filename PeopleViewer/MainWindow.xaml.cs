using Common;
using People.Library;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        PersonRepository repository = new PersonRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            List<Person> person = repository.GetPeople();
            //foreach (var item in person)
            //{
            //    PersonListBox.Items.Add(item);
            //}
            PersonListBox.ItemsSource = person;

        }

        private void AbstractFetchButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Person> person = repository.GetPeople();
            //foreach (var item in person)
            //{
            //    PersonListBox.Items.Add(item);
            //}
            PersonListBox.ItemsSource = person;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            //    PersonListBox.Items.Clear();
            PersonListBox.ItemsSource = null;
        }
    }
}
