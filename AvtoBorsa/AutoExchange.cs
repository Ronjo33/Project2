using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoBorsa
{
    internal class AutoExchange
    {
        private List<Car> cars;
        private List<Customer> customers;
        public AutoExchange()
        {
            cars = new List<Car>();
            customers = new List<Customer>();
        }
        public void AddCar(string registrationNumber, string engineNumber, string brand, string model, decimal price, int year)
        {
            Car car = new Car(registrationNumber, engineNumber, brand, model, price, year);
            cars.Add(car);
        }
        public void PrintCars()
        {
            foreach (var item in cars)
            {
                item.DisplayCars();
            }
        }
        public void AddCustomer(string name, int birthYear, decimal budget)
        {
            Customer customer = new Customer(name, birthYear, budget);
            customers.Add(customer);
        }
        public decimal FindCustomerBudgetByID(int id)
        {
            Customer customer = customers.Find(c => c.ID == id);
            if (customer != null)
            {
                return customer.Buget;
            }
            else
            {
                return 0;
            }
        }
        public void PrintCustomers()
        {
            foreach (var item in customers)
            {
                item.DisplayCustomers();
            }
        }
        public void PrintCarByBrandOrModel(string brandOrModel)
        {
            List<Car> matchingCars = cars.Where(car => car.Brand.ToLower() == brandOrModel.ToLower() || car.Model.ToLower() == brandOrModel.ToLower()).ToList();

            foreach (Car car in matchingCars)
            {
                car.DisplayCars();
            }
        }
        public void UpdateCarInfo(string registrationNumber, string brand, string model, decimal price, int year)
        {
            Car car = cars.Find(c => c.RegistrationNumber.ToLower() == registrationNumber.ToLower());
            if (car != null)
            {
                car.Brand = brand;
                car.Model = model;
                car.Price = price;
                car.Year = year;
                Console.WriteLine("Car information updated successfully.");
            }
            else
            {
                Console.WriteLine("Car not found.");
            }
        }
        public void DeleteCar(string brand)
        {
            List<Car> matchingCars = cars.Where(car => car.Brand.ToLower() == brand.ToLower()).ToList();

            foreach (Car car in matchingCars)
            {
                cars.Remove(car);
            }

            Console.WriteLine("Car(s) deleted successfully.");
        }
        public void CalculateAverageCarAge()
        {
            int currentYear = DateTime.Now.Year; //DateTime - използва се за действия с дати и часово време
            int totalAge = cars.Sum(car => currentYear - car.Year);
            double averageAge = totalAge / (double)cars.Count;
            Console.WriteLine($"Average car age: {averageAge:F2} years");
        }
        public void PrintNewestCar()
        {
            Car newestCar = cars.OrderByDescending(car => car.Year).FirstOrDefault(); //FirstOrDefault -връща първия елемент от последователност или стойност по подразбиране, ако последователността не съдържа елементи

            if (newestCar != null)
            {
                newestCar.DisplayCars();
            }
            else
            {
                Console.WriteLine("No cars available.");
            }
        }
        public void PrintMostExpensiveCar()
        {
            Car mostExpensiveCar = cars.OrderByDescending(car => car.Price).FirstOrDefault();

            if (mostExpensiveCar != null)
            {
                mostExpensiveCar.DisplayCars();
            }
            else
            {
                Console.WriteLine("No cars available.");
            }
        }
        public void PrintCarsByBudget(decimal budget)
        {
            List<Car> affordableCars = cars.Where(car => car.Price <= budget).ToList();
            affordableCars = affordableCars.OrderBy(car => car.Price).ToList();

            foreach (Car car in affordableCars)
            {
                car.DisplayCars();
            }
        }
    }
}
