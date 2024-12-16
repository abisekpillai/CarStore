using System.ComponentModel.Design;
using CarClassLibrary;

namespace CarStoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Console.WriteLine("Welcome to BeepKart!");
            Console.WriteLine("You can add new cars to the Cars Inventory.");
            Console.WriteLine("You can add cars from the inventory to your Cart");
            Console.WriteLine("You can get the total price of the cars in your cart during Checkout.");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("You have selected " + action);

                switch (action)
                {
                    case 1:
                        Console.WriteLine("You chose to add new cars to the Inventory.");

                        //initialize values for car attributes
                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 0;

                        Console.WriteLine("What is the make of the Car? ");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the model of the Car? ");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the price of the Car? ");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake,carModel,carPrice);

                        s.CarList.Add(newCar);

                        printInventory(s);

                        break;

                    case 2:
                        Console.WriteLine("You chose to buy cars.");
                        printInventory(s);

                        Console.WriteLine("Add car to cart. (number) ");

                        int carChoice = 0;
                        carChoice = int.Parse(Console.ReadLine()) - 1;

                        s.ShoppingList.Add(s.CarList[carChoice]);

                        printCart(s);

                        break;

                    case 3:
                        printCart(s);
                        carCheckout(s);
                        s.ShoppingList.Clear();
                        break;
                }

                action = chooseAction();
            }

            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }

        private static void carCheckout(Store s)
        {
            decimal totalCost = 0;
            foreach (Car c in s.ShoppingList)
            {
                totalCost += c.Price;
            }
            Console.WriteLine("The total cost is Rs" + totalCost);
        }

        private static void printCart(Store s)
        {
            Console.WriteLine("Cart");
            Console.WriteLine("=============");
            int i = 1;
            foreach (Car c in s.ShoppingList)
            {
                Console.WriteLine(i + ") " + c);
                i++;
            }
            Console.WriteLine("=============");
        }

        static void printInventory(Store s)
        {
            Console.WriteLine("Inventory");
            Console.WriteLine("=============");
            int i = 1;
            foreach (Car c in s.CarList)
            {
                Console.WriteLine(i + ") " + c);
                i++;
            }
            Console.WriteLine("=============");
        }

        static int chooseAction()
        {
            int attempt = 0;
            int maxAttempt = 3;

            while (attempt < maxAttempt)
            {
                try
                {
                    Console.WriteLine("MENU");
                    Console.WriteLine("{1} To Add Cars to the Inventory");
                    Console.WriteLine("{2} To Add Cars to the Cart");
                    Console.WriteLine("{3} To Checkout");
                    Console.WriteLine("{0} To Quit");
                    Console.WriteLine("Choose an action....");

                    int choice = int.Parse(Console.ReadLine());
                    return choice;
                }
                catch (FormatException)
                {
                    attempt++;
                    Console.WriteLine("Invalid action. Choose a valid action.");
                    if (attempt >= maxAttempt)
                    {
                        Console.WriteLine("Too many failed attempts.");
                        Console.WriteLine("Exiting....");
                        return 0;
                    }
                    
                }
            }
            return 0;
        }
    }
}
