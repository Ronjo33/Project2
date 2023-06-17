using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoBorsa
{
    internal class Car
    {
        private string registrationNumber;
        private string engineNumber;
        private string brand;
        private string model;
        private decimal price;
        private int year;
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        public string EngineNumber
        {
            get { return engineNumber; }
            set { engineNumber = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Car(string registrationNumber, string engineNumber, string brand, string model, decimal price, int year)
        {
            this.RegistrationNumber = registrationNumber;
            this.EngineNumber = engineNumber;
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
            this.Year = year;
        }
        public void DisplayCars()
        {
            Console.WriteLine($"| Registration number: {this.RegistrationNumber} | Engine number: {this.EngineNumber} | Brand: {this.Brand} | Model: {this.Model} | Year: {this.Year} | Price: {this.Price} |");
        }
    }
}
