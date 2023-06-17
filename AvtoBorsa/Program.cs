using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoBorsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            AutoExchange autoexchange = new AutoExchange();
            while (true)
            {
                Console.WriteLine("                            Menu");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Select an option:");
                Console.WriteLine("(1). |Add car|");
                Console.WriteLine("(2). |Print cars|");
                Console.WriteLine("(3). |Add customer|");
                Console.WriteLine("(4). |Print customers|");
                Console.WriteLine("(5). |Print cars by brand or model|");
                Console.WriteLine("(6). |Update car information|");
                Console.WriteLine("(7). |Delete car by brand|");
                Console.WriteLine("(8). |Calculate average car age|");
                Console.WriteLine("(9). |Print newest car|");
                Console.WriteLine("(10). |Print most expensive car|");
                Console.WriteLine("(11). |Print cars within customer budget|");
                Console.WriteLine("(12). |Exit|");
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("Select option: ");
                int option = int.Parse(Console.ReadLine());
                //the task can be done with switch - case or with if statement
                switch (option)
                {
                    case 1:
                        Console.Write("Enter registration number: ");
                        string registrationNumber = Console.ReadLine();
                        Console.Write("Enter engine number: ");
                        string engineNumber = Console.ReadLine();
                        Console.Write("Enter brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Enter model: ");
                        string model = Console.ReadLine();
                        Console.Write("Enter price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter year of production: ");
                        int year = int.Parse(Console.ReadLine());
                        autoexchange.AddCar(registrationNumber, engineNumber, brand, model, price, year);
                        Console.WriteLine("Car successfully added!");
                        break;
                    case 2:
                        Console.WriteLine("Available cars:");
                        autoexchange.PrintCars();
                        break;
                    case 3:
                        Console.Write("Enter customer name: ");
                        string customerName = Console.ReadLine();
                        Console.Write("Enter customer birth year: ");
                        int customerBirthYear = int.Parse(Console.ReadLine());
                        Console.Write("Enter budget: ");
                        decimal customerBuget = decimal.Parse(Console.ReadLine());
                        autoexchange.AddCustomer(customerName, customerBirthYear, customerBuget);
                        Console.WriteLine("Customer successfully added!");
                        break;
                    case 4:
                        Console.WriteLine("Customers:");
                        autoexchange.PrintCustomers();
                        break;
                    case 5:
                        Console.Write("Enter brand or model: ");
                        string searchInput = Console.ReadLine();
                        Console.WriteLine("Matching cars:");
                        autoexchange.PrintCarByBrandOrModel(searchInput);
                        break;
                    case 6:
                        Console.Write("Enter registration number of the car to update: ");
                        string carRegistrationNumber = Console.ReadLine();
                        Console.Write("Enter new brand: ");
                        string newBrand = Console.ReadLine();
                        Console.Write("Enter new model: ");
                        string newModel = Console.ReadLine();
                        Console.Write("Enter new price: ");
                        decimal newPrice = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter new year of production: ");
                        int newYear = int.Parse(Console.ReadLine());
                        autoexchange.UpdateCarInfo(carRegistrationNumber, newBrand, newModel, newPrice, newYear);
                        Console.WriteLine($"{carRegistrationNumber} successfully updated!");
                        break;
                    case 7:
                        Console.Write("Enter brand of the car to delete: ");
                        string carBrand = Console.ReadLine();
                        autoexchange.DeleteCar(carBrand);
                        break;
                    case 8:
                        autoexchange.CalculateAverageCarAge();
                        break;
                    case 9:
                        Console.WriteLine("Newest car:");
                        autoexchange.PrintNewestCar();
                        break;
                    case 10:
                        Console.WriteLine("Most expensive car:");
                        autoexchange.PrintMostExpensiveCar();
                        break;
                    case 11:
                        Console.Write("Enter customer ID: ");
                        int customerID = int.Parse(Console.ReadLine());
                        decimal budget = autoexchange.FindCustomerBudgetByID(customerID);
                        Console.WriteLine("Cars within customer budget:");
                        autoexchange.PrintCarsByBudget(budget);
                        break;
                    case 12:
                        Console.WriteLine("See you later :)");
                        return;
                }
                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
