using System;

namespace FactoryMethod
{
    internal class Cheeseburger : IBbqGrill
    {
        public void Cook()
        {
            Console.WriteLine("Making Cheeseburger");
        }
    }
}