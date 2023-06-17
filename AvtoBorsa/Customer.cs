using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoBorsa
{
    internal class Customer
    {
        private static int id = 1;
        private string name;
        private int birthYear;
        private decimal buget;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID { get; }
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        public decimal Buget
        {
            get { return buget; }
            set { buget = value; }
        }
        public Customer(string name, int birthYear, decimal buget)
        {
            this.ID = id++;
            this.Name = name;
            this.BirthYear = birthYear;
            this.Buget = buget;
        }
        public void DisplayCustomers()
        {
            Console.WriteLine($"ID: {this.ID}| Name: {this.Name}| Birth Year: {this.BirthYear}| Buget: ${this.Buget}|");
        }
    }
}
