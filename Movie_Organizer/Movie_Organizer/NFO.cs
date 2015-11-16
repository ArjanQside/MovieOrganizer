using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Movie_Organizer
{
    class NFO
    {
        public static void WriteMovieNFO(Movie m)
        {
            // where does the file need to go?
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<movie>");
            sb.AppendLine("<title>" + m.title + "</title>");
            sb.AppendLine("<year>" + m.year + "</year>");
            sb.AppendLine("<outline>" + m.summary + "</outline>");
            sb.AppendLine("<filenameandpath>" + m.filePath + "</filenameandpath>");
            foreach (string genre in m.genre)
                sb.AppendLine("<genre>" + genre + "</genre>");
            sb.AppendLine("<id>" + m.id + "</id>");
            sb.AppendLine("</movie>");


            // write the file
            System.IO.File.WriteAllText(m.filePath + "\\movie.nfo", sb.ToString());
        }
        public static Movie ReadMovieNFO(string folder)
        {
            Movie m = new Movie();

            // read the movie file
            XmlDocument xmldoc = new XmlDocument();
            XmlNode xmlnodeMovie;

            FileStream fs = new FileStream(folder, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnodeMovie = xmldoc.ChildNodes[0];

            XmlNode xmlnodeTitle = xmlnodeMovie.SelectSingleNode("title");
            m.title = xmlnodeTitle.InnerText;

            XmlNode xmlnodeYear = xmlnodeMovie.SelectSingleNode("year");
            m.year = xmlnodeYear.InnerText;

            XmlNode xmlnodeId = xmlnodeMovie.SelectSingleNode("id");
            m.id = int.Parse(xmlnodeId.InnerText);

            XmlNode xmlnodePath = xmlnodeMovie.SelectSingleNode("filenameandpath");
            m.filePath = xmlnodePath.InnerText;

            XmlNode xmlnodeSummary = xmlnodeMovie.SelectSingleNode("outline");
            m.summary = xmlnodeSummary.InnerText;


            // return the new movie object
            return m;
        }
    }
}
