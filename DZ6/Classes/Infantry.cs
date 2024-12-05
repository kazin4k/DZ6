using System;

namespace Military
{
    public class Infantry : Soldier
    {
        public int Experience { get; set; }
        public string WeaponType { get; set; }
        public bool IsInCombat { get; set; }
        public int MissionsCompleted { get; set; }

        public Infantry(string name, int age, string rank, string unit, int experience)
        {
            Name = name;
            Age = age;
            Rank = rank;
            Unit = unit;
            Experience = experience;
        }

        public Infantry(string name, int age, string rank, string unit)
        {
            Name = name;
            Age = age;
            Rank = rank;
            Unit = unit;
            Experience = 0;
        }

        public override void Train()
        {
            Console.WriteLine($"{Name} проходит подготовку в качестве пехотинца");
        }

        public override void Deploy()
        {
            Console.WriteLine($"{Name} развертывается на местах");
        }

        public void EngageInCombat()
        {
            IsInCombat = true;
            Console.WriteLine($"{Name} сейчас находится в бою");
        }

        public void CompleteMission()
        {
            MissionsCompleted++;
            IsInCombat = false;
            Console.WriteLine($"{Name} выполнил миссию");
        }

        public void GainExperience(int additionalExperience)
        {
            Experience += additionalExperience;
        }
    }
}
