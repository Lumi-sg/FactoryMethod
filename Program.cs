using System;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What kind of hamburger do you want?");
                Console.WriteLine("beef / cheese / veggie / chicken | q to exit");
                string burgerType = Console.ReadLine();
                var burgerFactory = BorgerFactory.CreateBorger(burgerType);

                MakeBorger(burgerType, burgerFactory);
            }
        }

        public static void MakeBorger(string burgerType, IBbqGrill burgerFactory)
        {
            burgerFactory.Cook();
        }
    }
}

    