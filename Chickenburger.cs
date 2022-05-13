using System;

namespace FactoryMethod
{
    internal class Chickenburger : IBbqGrill
    {
        public void Cook()
        {
            Console.WriteLine("Making Chickenburger");
        }
    }
}