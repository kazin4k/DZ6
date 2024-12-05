using System;
using Military;

class Program
{
    static void Main(string[] args)
    {
        Infantry infantrySoldier = new Infantry("Нурсултан Шамсутдинов", 30, "Сержант", "2-й взвод", 5);
        infantrySoldier.Train();
        infantrySoldier.Deploy();
        infantrySoldier.DisplayInfo();
        infantrySoldier.EngageInCombat();
        infantrySoldier.CompleteMission();

        Pilot pilot = new Pilot("Андрей Дорожан", 28, "Капитан", "Военно-воздушные силы", 100);
        pilot.Train();
        pilot.Deploy();
        pilot.LogFlightHours(10);
        pilot.StartMission();
        pilot.LandAircraft();

        Commander commander = new Commander("Андрей Мингалев", 45, "Генерал", "Штаб-квартира", "1-й дивизион");
        commander.Train();
        commander.Deploy();
        commander.PlanMission();
        commander.GiveOrders();
        commander.ReviewPerformance();

        Console.ReadLine();
    }
}


