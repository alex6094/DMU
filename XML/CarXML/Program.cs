using System.Xml;
using System.Xml.Linq;

namespace DMU.XML.CarXML
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creates new list for cars
            List<Car> cars = new List<Car>();

            //Creates XmlReader, that takes the filepath as parameter
            XmlReader reader = XmlReader.Create("C:\\Users\\Alexander\\RiderProjects\\DMU\\XML\\CarXML\\cars.xml");

            //While there are cars in the list, the reader continues
            while (reader.Read())
            {
                //Checks if the startelement is "car"
                if (reader.IsStartElement("car"))
                {
                    //If the start element is "car", the reader takes the attribute (value) of "name", which in this case is the model name
                    string name = reader.GetAttribute("name");

                    //After the name has been read, ReadToDescendant moves the reader to the next element that is indented
                    reader.ReadToDescendant("cylinders");
                    
                    //When the reader has found the int for cylinders, we use the reader to set the value of cylinders
                    int cylinders = reader.ReadElementContentAsInt();

                    //Here we use ReadToNextSibling to get the next element at the same indentation level
                    reader.ReadToNextSibling("country");
                    string country = reader.ReadElementContentAsString();
                    
                    //Create a new car with the values from the XML file
                    Car car = new Car(name, cylinders, country);
                    
                    //Add the new car to the cars list
                    cars.Add(car);
                }
            }
            reader.Close();
            
            //Create new 
            XElement xCars = new XElement("cars");

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());

                XElement xCar = new XElement("car", new XAttribute("name", $"{car.Name}"),
                                                        new XElement("cylinders", $"{car.Cylinders}"),
                                                        new XElement("country", $"{car.Country}"));
                xCars.Add(xCar);
            }
            string fileName = "C:\\Users\\Alexander\\RiderProjects\\DMU\\XML\\CarXML\\newcars.xml";
            try
            {
                using(FileStream fs = new FileStream(fileName, FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(fs))
                    using (XmlTextWriter xmlWriter = new XmlTextWriter(sw))
                    {
                        xmlWriter.Formatting = Formatting.Indented;
                        xmlWriter.Indentation = 4;
                        
                        //xmlWriter.WriteStartDocument(); Can be used here to write the XML version and UTF encoding in the start of the new XML file
                        
                        xCars.WriteTo(xmlWriter);
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}