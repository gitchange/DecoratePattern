using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Espresso();
            Console.WriteLine(beverage1.Description + "$ " + beverage1.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + "$ " + beverage2.cost());

            Beverage beverage3 = new HourseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + "$ " + beverage3.cost());

            Console.ReadLine();
        }
    }
}
