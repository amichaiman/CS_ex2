using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfApp3
{
    internal class XmlManager
    {
        public string Filename { get; set; }
        public XmlManager(string file)
        {
            Filename = file;
        }
        public SortedDictionary<Pair, Movie> Read()
        {
            SortedDictionary<Pair, Movie> movieList =
                new SortedDictionary<Pair , Movie>();

            XmlTextReader reader = new XmlTextReader(Filename);
            reader.WhitespaceHandling = WhitespaceHandling.None;

            while (reader.Name != "Movie")
            {
                reader.Read();
            }

            while (reader.Name == "Movie")
            {
                reader.ReadStartElement("Movie");
                string title = reader.ReadElementString("Title");
                int year = Convert.ToInt32(reader.ReadElementString("Year"));
                string director = reader.ReadElementString("Director");
                string actors = reader.ReadElementString("Actors");
                Movie movie = new Movie()
                {
                    Title = title,
                    Year = year,
                    Director = director,
                    Actors = actors.Split(','),
                };
                movieList.Add(movie.ToPair(), movie);
                reader.ReadEndElement();
            }
            reader.Close();
            return movieList;
        }
        public void Write(SortedDictionary<Pair, Movie> movieList)
        {
            XmlTextWriter writer = new XmlTextWriter(Filename, Encoding.Unicode);
            writer.Formatting = Formatting.Indented;

            // start the document
            writer.WriteStartDocument();
            writer.WriteStartElement("Movies");

            // write the data
            foreach (Movie movie in movieList.Values)
            {
                writer.WriteStartElement("Movie");
                writer.WriteElementString("Title", movie.Title);
                writer.WriteElementString("Year", movie.Year.ToString());
                writer.WriteElementString("Director", movie.Director);
                writer.WriteElementString("Actors", string.Join(",",movie.Actors));
                writer.WriteEndElement();
            }

            // end the document
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
