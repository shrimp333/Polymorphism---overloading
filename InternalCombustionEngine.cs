using System;

namespace Polymorphism___overloading
{
    public class InternalCombustionEngine:Engine
    {
        public string fuelType;
        public InternalCombustionEngine():base(){}
        public InternalCombustionEngine(string pFuelType, int horsePower, int energyStoreMaxSize):base(horsePower, energyStoreMaxSize)
        {
            fuelType = pFuelType;
        }
        public override void Rev()
        {
            if (currentEnergyStore <= 0)
                Console.WriteLine("OUT OF FUEL");
            else
            {
                Console.WriteLine("VROOOOMMMM!");
                currentEnergyStore--;
            }
        }
        public override void Rev(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                if (currentEnergyStore <= 0)
                {
                    Console.WriteLine("OUT OF FUEL");
                }
                else
                {
                    Console.WriteLine("VROOOOMMMM!");
                    currentEnergyStore--;
                }
            }
        }
        public override void Refuel()
        {
            currentEnergyStore = energyStoreMaxSize;
            Console.WriteLine("REFUELED TO FULL");
        }
        public override void Refuel(int i)
        {
            currentEnergyStore += i;
            if (currentEnergyStore > energyStoreMaxSize)
                currentEnergyStore = energyStoreMaxSize;
            Console.WriteLine($"REFUELLED {i} LITRES");
        }
    }
}