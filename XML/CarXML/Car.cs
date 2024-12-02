namespace DMU.XML.CarXML
{
    public class Car
    {
        public string Name { get; set; }
        public int Cylinders { get; set; }
        public string Country { get; set; }

        public Car(string name, int cylinders, string country)
        {
            this.Name = name;
            this.Cylinders = cylinders;
            this.Country = country;
        }

        public override string ToString()
        {
            string info = $"Name: {Name}, cylinders: {Cylinders}, country: {Country}";
            return info;
        }
    }
}