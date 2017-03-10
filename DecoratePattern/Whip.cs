using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePattern
{
    /// <summary>
    /// 奶泡
    /// </summary>
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        string description = string.Empty;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get
            {
                return beverage.Description + this.description;
            }
            set
            {
                this.description = value + ", Whip";
            }
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }
}