using System;

namespace Polymorphism___overloading
{
    class ElectricEngine:Engine
    {
        public string batteryType;
        public ElectricEngine():base(){}
        public ElectricEngine(string pBatteryType, int horsePower, int energyStoreMaxSize):base(horsePower, energyStoreMaxSize)
        {
            batteryType = pBatteryType;
        }
        public override void Rev()
        {
            if (currentEnergyStore <= 0)
                Console.WriteLine("FLAT BATTERY");
            else
            {
                Console.WriteLine("SWWIIIISSSSHHH!");
                currentEnergyStore--;
            }
        }
        public override void Rev(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                if (currentEnergyStore <= 0)
                {
                    Console.WriteLine("FLAT BATTERY");
                }
                else
                {
                    Console.WriteLine("SWWIIIISSSSHHH!");
                    currentEnergyStore--;
                }
            }
        }
        public override void Refuel()
        {
            currentEnergyStore = energyStoreMaxSize;
            Console.WriteLine("RECHARGED TO FULL");
        }
        public override void Refuel(int i)
        {
            currentEnergyStore += i;
            if (currentEnergyStore > energyStoreMaxSize)
                currentEnergyStore = energyStoreMaxSize;
            Console.WriteLine($"RECHARGED {i} AMP HOURS");
        }
    }
}