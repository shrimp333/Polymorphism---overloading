using System;

namespace Polymorphism___overloading
{
    public abstract class Engine
    {
        public int horsePower { get; set;}
        public int energyStoreMaxSize { get; set; }
        public int currentEnergyStore { get; set; }
        
        public Engine(){}
        public Engine(int hp, int max)
        {
            horsePower = hp;
            energyStoreMaxSize = max;
            currentEnergyStore = max;
        }
        public abstract void Rev();
        public abstract void Rev(int i);
        public abstract void Refuel();
        public abstract void Refuel(int i);
    }
}