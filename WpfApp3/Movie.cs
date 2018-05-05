using System;
using System.Text.RegularExpressions;

namespace WpfApp3
{
    public class Movie
    {
        private string _title;
        private int _year;
        private string _director;
        private string[] _actors;

        public string Title
        {
            get => _title;
            set
            {
                if (!Regex.IsMatch(value.Replace(" ", string.Empty), @"^[a-zA-Z,0-9]{1,50}$"))
                {
                    throw new InvalidInputException("Invalid movie title");
                }
                _title = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value < 1990 || value > 2018)
                {
                    throw new InvalidInputException("Invalid movie year");
                }
                _year = value;
            }
        }

        public string Director
        {
            get => _director;
            set
            {
                if (!Regex.IsMatch(value, @"[a-zA-Z]+"))
                {
                    throw new InvalidInputException("Invalid movie director");
                }
                _director = value;
            }
        }

        public string[] Actors
        {
            get => _actors;
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new InvalidInputException("No actors inputted");
                }
                foreach(string actor in value)
                {
                    if (!Regex.IsMatch(actor, @"[a-zA-Z]+"))
                    {
                        throw new InvalidInputException($"{actor} is an invalid actor name");
                    }
                }
                _actors = value;
            }
        }

        internal Pair ToPair()
        {
            return new Pair(Title,Year);
        }

        public override string ToString()
        {
            return $"{Title}, {Year}, Director: {Director}, Actors: {string.Join(", ",Actors)}";
        }
    }
}