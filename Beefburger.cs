using System;

namespace FactoryMethod
{
    internal class Beefburger : IBbqGrill
    {
        public void Cook()
        {
            Console.WriteLine("Making Beefburger");
        }
    }
}

