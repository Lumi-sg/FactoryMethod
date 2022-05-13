using System;

namespace FactoryMethod
{
    internal class Veggieburger : IBbqGrill
    {
        public void Cook()
        {
            Console.WriteLine("Making Veggieburger");
        }
    }
}