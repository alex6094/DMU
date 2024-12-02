
using System.Xml;

namespace DMU.XML.CarXML
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:\\Users\\alexa\\OneDrive\\Desktop\\Exam\\CarXML\\cars.xml";
            string newFilename = "C:\\Users\\alexa\\OneDrive\\Desktop\\Exam\\CarXML\\newcars.xml";

            try {
                XmlReader reader = XmlReader.Create(filename);

                ReadXml(reader);

                reader.Close();
            }
            catch (IOException) {
                Console.WriteLine("Could not open file: " + filename);
            }
        }
        public static void ReadXml(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.ReadToDescendant("car", "http://www.fkj.dk/cars.xml"))
                {
                    do
                    {
                        reader.Read();
                        Console.WriteLine(reader.ReadContentAsString());
                    } while (reader.ReadToNextSibling("car", "http://www.fkj.dk/cars.xml"));
                }
            }
        }

    }
}
