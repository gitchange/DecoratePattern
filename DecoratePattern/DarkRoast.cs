using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 深度烘焙
    /// </summary>
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast";
        }

        public override double cost()
        {
            return 0.99;
        }
    }
}
