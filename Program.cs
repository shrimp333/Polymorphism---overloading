using System;

namespace Polymorphism___overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine e1 = new ElectricEngine("lithium",100,100);
            Engine e2 = new InternalCombustionEngine("diesel",100,100);
            e1.Rev();
            e2.Rev();
            e1.Rev(3);
            e2.Rev(3);
            e1.Refuel(1);
            e2.Refuel(1);
            e1.Refuel();
            e2.Refuel();
        }
    }
}
