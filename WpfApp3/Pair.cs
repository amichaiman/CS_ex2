using System;

namespace WpfApp3
{
    internal class Pair : IComparable
    {
        public string Title { set; get; }
        public int Year { set; get; }

        public Pair(string title, int year)
        {
            this.Title = title;
            this.Year = year;
        }

        public override bool Equals(object obj)
        { 
            Pair rhs = obj as Pair;
            return rhs.Year == Year && rhs.Title.Equals(Title);
        }

        public override int GetHashCode()
        {
            return Year+Title.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Pair rhs = obj as Pair;

            return Year < rhs.Year ? -1 : Year > rhs.Year ? 1 : Title.CompareTo(rhs.Title); 
        }
    }
}