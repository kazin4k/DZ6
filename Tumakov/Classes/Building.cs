using System;

namespace Tumakov.Classes
{
    public class Building
    {
        private static int lastNumber;
        private int number;
        private double height;
        private int floors;
        private int flat;
        private int section;

        private int GenerateNumber()
        {
            lastNumber++;
            return lastNumber;
        }

        public Building(double height, int floors, int flat, int section)
        {
            this.number = GenerateNumber();
            this.height = height;
            this.floors = floors;
            this.flat = flat;
            this.section = section;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Номер здания: {number}");
            Console.WriteLine($"Высота здания: {height}");
            Console.WriteLine($"Количество этажей: {floors}");
            Console.WriteLine($"Количество квартир: {flat}");
            Console.WriteLine($"Количество подъездов: {section}");
        }

        public double CalculatedHeight()
        {
            return height / floors;
        }

        public int CalculatedFlat()
        {
            return flat / section;
        }

        public int CalculatedFloors()
        {
            return flat / floors;
        }

    }
}
