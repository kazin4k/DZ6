using System;

namespace Military
{
    public class Commander : Soldier
    {
        public string CommandUnit { get; set; }
        public int YearsOfService { get; set; }
        public int NumberOfSubordinates { get; set; }
        public string Strategy { get; set; }

        public Commander(string name, int age, string rank, string unit, string commandUnit)
        {
            Name = name;
            Age = age;
            Rank = rank;
            Unit = unit;
            CommandUnit = commandUnit;
        }

        public override void Train()
        {
            Console.WriteLine($"{Name} проходит подготовку в качестве командира");
        }

        public override void Deploy()
        {
            Console.WriteLine($"{Name} развертывается для командования войсками");
        }

        public void PlanMission()
        {
            Console.WriteLine($"{Name} планирует миссию");
        }

        public void GiveOrders()
        {
            Console.WriteLine($"{Name} отдает приказы подчиненным");
        }

        public void ReviewPerformance()
        {
            Console.WriteLine($"{Name} проверяет эффективность работы подчиненных");
        }
    }
}
