using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class BorgerFactory
    {
        public static IBbqGrill CreateBorger(string burgerType)
        {
            IBbqGrill borger = null;
            switch (burgerType)
            {
                case "beef":
                    borger = new Beefburger();
                    break;
                case "cheese":
                    borger = new Cheeseburger();
                    break;
                case "veggie":
                    borger = new Veggieburger();
                    break;
                case "chicken":
                    borger = new Chickenburger();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
            }

            return borger;
        }
    }
}
    