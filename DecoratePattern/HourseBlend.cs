using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 綜合
    /// </summary>
    public class HourseBlend : Beverage
    {
        public HourseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double cost()
        {
            return 0.89;
        }
    }
}
