using System;

namespace Military
{
    public class Pilot : Soldier
    {
        public int FlightHours { get; set; }
        public string AircraftType { get; set; }
        public bool IsOnMission { get; set; }
        public int TotalMissions { get; set; }

        public Pilot(string name, int age, string rank, string unit, int flightHours)
        {
            Name = name;
            Age = age;
            Rank = rank;
            Unit = unit;
            FlightHours = flightHours;
        }

        public Pilot(string name, int age, string rank, string unit)
        {
            Name = name;
            Age = age;
            Rank = rank;
            Unit = unit;
            FlightHours = 0;
        }

        public override void Train()
        {
            Console.WriteLine($"{Name} проходит обучение в качестве пилота");
        }

        public override void Deploy()
        {
            Console.WriteLine($"{Name} развертывается для выполнения полетного задания\"");
        }

        public void LogFlightHours(int hours)
        {
            FlightHours += hours;
            Console.WriteLine($"{Name} летал {hours} часов");
        }

        public void StartMission()
        {
            IsOnMission = true;
            Console.WriteLine($"{Name} начал миссию");
        }

        public void LandAircraft()
        {
            IsOnMission = false;
            Console.WriteLine($"{Name} посадил самолет");
        }
    }
}
