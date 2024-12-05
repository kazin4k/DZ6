using System;

namespace Military
{
    public abstract class Soldier
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Rank { get; set; }
        public string Unit { get; set; }

        public abstract void Train();
        public abstract void Deploy();
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Звание: {Rank}, Подразделение: {Unit}");
        }
        public void Promote( string NewRank)
        {
            Rank = NewRank;
        }
        public void ChangeUnit( string NewUnit)
        {
            Unit = NewUnit;
        }

    }
}
