using System;

namespace Tumakov.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 7.1
            Console.WriteLine("Упраднение 7.1\n");

            BankAccount myAccount1 = new BankAccount(/*"7654321", */20000000.00m, TypeAccount.Check);

            myAccount1.DisplayInfo();


            //Упражнение 7.2
            Console.WriteLine("Упражнение 7.2\n");

            BankAccount myAccount2 = new BankAccount(340000.00m, TypeAccount.Credit);

            myAccount2.DisplayInfo();


            //Упражнение 7.3
            Console.WriteLine("Упражнение 7.3");

            myAccount2.DisplayInfo();

            myAccount2.Refill(2000.00m);
            myAccount2.Withdraw(1000.00m);

            myAccount2.DisplayInfo();


            //Домашнее задание 7.1
            Console.WriteLine("Домашнее задание 7.1");

            Building build1 = new Building(50.0,10,200,2);
            build1.DisplayInfo();

            Console.WriteLine($"Высота этажа: {build1.CalculatedHeight()}");
            Console.WriteLine($"Квартир в подъезде: {build1.CalculatedFlat()}");
            Console.WriteLine($"Квартир на этаже: {build1.CalculatedFloors()}");

            Building building2 = new Building(75.0, 15, 150, 3);
            building2.DisplayInfo();

        }
    }
}
