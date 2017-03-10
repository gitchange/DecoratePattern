using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePattern
{
    /// <summary>
    /// 牛奶
    /// </summary>
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        string description = string.Empty;
        public Milk(Beverage beverage)
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
                this.description = value + ", Milk";
            }
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }
}