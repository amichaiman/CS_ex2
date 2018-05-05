using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = movieDictionary;
        }

        private ObservableDictionary<Pair,Movie> movieDictionary = new ObservableDictionary<Pair,Movie>();

        private void AddMovieButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addMovieWindow = new AddWindow();
            addMovieWindow.AddMovieEvent += AddMovie; 
            addMovieWindow.Show();
        }


        public void AddMovie(Movie movie)
        {
            movieDictionary.Add(new Pair(movie.Title, movie.Year), movie);
        }

        private void DeleteMovieButton_Click(object sender, RoutedEventArgs e)
        {
            if (MovieListListBox.SelectedItem == null)
            {
                MessageBox.Show("No movie selected", "Notice");
            }
            else
            {
                movieDictionary.Remove(((Movie)MovieListListBox.SelectedItem).ToPair());
            }
        }

        private void SearchMovieButton_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchMovieWindow = new SearchWindow();
            searchMovieWindow.SearchMovieEvent += SearchMovies;
            searchMovieWindow.Show();
        }

        private IEnumerable<string> SearchMovies(SearchWindow.GetMovieFieldDelegate getMovieField, string stringToSearch)
        {
            if (stringToSearch.Contains(":"))
            {
                int startYear = Convert.ToInt32(stringToSearch.Split(':')[0]);
                int endYear = Convert.ToInt32(stringToSearch.Split(':')[1]);

                foreach (var movie in movieDictionary.Dictionary.Values)
                {
                    if (Convert.ToInt32(getMovieField(movie)) >= startYear && Convert.ToInt32(getMovieField(movie)) <= endYear)
                    {
                        yield return movie.Title;
                    }
                }
            } 
            else
            {
                foreach (var movie in movieDictionary.Dictionary.Values)
                {
                    if (getMovieField(movie).Contains(stringToSearch))
                    {
                        yield return movie.Title;
                    }
                }
            }
        }
        string path = @"..\..\movies.xml";
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (movieDictionary.Dictionary.Count > 0)
            {
                XmlManager xmlConnection = new XmlManager(path);
                xmlConnection.Write(movieDictionary.Dictionary);
            }
            else
            {
                File.Delete(path);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists(path))
            {
                XmlManager xmlConnection = new XmlManager(path);
                movieDictionary.Dictionary = null;
                movieDictionary.Dictionary = xmlConnection.Read();
            }

        }
    }
}
