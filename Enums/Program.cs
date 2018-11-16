using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon = new Dragon()
            {
                BreathesFire = true,
                IsScary = false,
                AmountOfGold = 2000,
                TypeOfDragon = DragonType.Red,
            };

            Console.WriteLine("What type of dragon do you want?\n" +
                "Red\n" +
                "Gold\n" +
                "Elder\n" +
                "Frost\n" +
                "Blue");
            var dragonInput = Console.ReadLine();
            switch (dragonInput)
            {
                case "Red":
                    dragon.TypeOfDragon = DragonType.Red;
                    break;
                case "Frost":
                    dragon.TypeOfDragon = DragonType.Frost;
                    break;
                case "Elder":
                    dragon.TypeOfDragon = DragonType.Elder;
                    break;
                case "Blue":
                    dragon.TypeOfDragon = DragonType.Blue;
                    break;
                case "Gold":
                    dragon.TypeOfDragon = DragonType.Gold;
                    break;
                default:
                    break;
            }

        }
    }
}
