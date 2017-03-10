using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratePattern
{
    /// <summary>
    /// 豆漿
    /// </summary>
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        string description = string.Empty;
        public Soy(Beverage beverage)
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
                this.description = value + ", Soy";
            }
        }

        public override double cost()
        {
            return 0.15 + beverage.cost();
        }
    }
}