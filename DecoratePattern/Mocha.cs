using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePattern
{
    /// <summary>
    /// 摩卡
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        string description = string.Empty;
        public Mocha(Beverage beverage)
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
                this.description = value + ", Mocha";
            }
        }

        public override double cost()
        {
            return 0.20 + beverage.cost();
        }
    }
}