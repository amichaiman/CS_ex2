
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public delegate void AddMovieDelegate(Movie movie);
        public event AddMovieDelegate AddMovieEvent;

        public AddWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddMovieEvent(new Movie()
                {
                    Title = MovieTitleTextBox.Text,
                    Year = Convert.ToInt32(MovieYearTextBox.Text),
                    Director = MovieDirectorTextBox.Text,
                    Actors = (new string[] { MovieActor1TextBox.Text, MovieActor2TextBox.Text, MovieActor3TextBox.Text, MovieActor4TextBox.Text })
                    .Where(x => !string.IsNullOrEmpty(x)).ToArray()                    
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Notice");
            }
        }
    }
}
