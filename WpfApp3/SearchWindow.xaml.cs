using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        public delegate string GetMovieFieldDelegate(Movie m);        //Returns string with requested field. movie year returned as string as well
        private  GetMovieFieldDelegate getMovieField = m => m.Title;  //Title is default search critiria

        public delegate IEnumerable<string> SearchMovieDelegate(GetMovieFieldDelegate movie, string toSearch);
        public event SearchMovieDelegate SearchMovieEvent;

        private string stringToSearch;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stringToSearch = getStringToSearch();
            if (!string.IsNullOrEmpty(stringToSearch))
            {
                SearchResultListView.ItemsSource = SearchMovieEvent(getMovieField, stringToSearch).ToList();
            }
 
        }

        private string getStringToSearch()
        {
            if (MovieTitleRadioButton.IsChecked == true)
            {
                return MovieTitleTextBox.Text;
            }
            if (MovieYearRadioButton.IsChecked == true)
            {
                if (!Regex.IsMatch(MovieStartYearTextBox.Text, @"^[0-9]{4}$") || !Regex.IsMatch(MovieStartYearTextBox.Text, @"^[0-9]{4}$"))
                {
                    MessageBox.Show("Invlid year", "Notice");
                    return null;
                }
                return MovieStartYearTextBox.Text + ":" + MovieEndYearTextBox.Text;
            }
            if (MovieDirectorRadioButton.IsChecked == true)
            {
                return MovieDirectorTextBox.Text;
            }
            if (MovieActorRadioButton.IsChecked == true)
            {
                return MovieActorTextBox.Text;
            }
            MessageBox.Show("No search critiria selected", "Notice");
            return null;   
        }

        private void MovieTitleRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            getMovieField = m => m.Title;
        }

        private void MovieYearRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            getMovieField = m => m.Year.ToString();
        }

        private void MovieDirectorRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            getMovieField = m => m.Director;
        }

        private void MovieActorRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            getMovieField = m => string.Join(" ", m.Actors);
        }
    }
}
