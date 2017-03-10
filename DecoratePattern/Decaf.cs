using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 低咖啡因
    /// </summary>
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override double cost()
        {
            return 1.05;
        }
    }
}
