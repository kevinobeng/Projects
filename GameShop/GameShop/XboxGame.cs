using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop
{
    public class XboxGame : Game 
    {
        public XboxGame(string gameTitle, string gameDev, Condition condition,
                        decimal originalPrice, DateTime releaseDate)
            : base(gameTitle, gameDev, condition, originalPrice, releaseDate)
        {
            this.console = "XboxGame";
        }
        // this calculation is overriddden in both the inhariting classes
        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;
            // we modify the phones value base on its condition
            if (condition == Condition.mint)
            {
                value = originalPrice * 0.9m; //90% of original value
            }
            else if (condition == Condition.good)
            {
                value = originalPrice * 0.8m; //80% of original value
            }
            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.7m; //70% of original value
            }
            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.5m; //50% of original value 
            }

            // we also take into account the cars age
            int age = CalculateApproximateAgeInYears();

            // we lose another 10% of the value every year - so we keep 90% or 0.9
            for (int i = 0; i < age; i++)
            {
                value = value * 0.9m;
            }
            value = Decimal.Round(value, 0); // round to the nearst pound

            // the shop rounds this down to the nearest £100
            value = value - (value % 1);

            // and then adds £99
            value = value + 0.99m;
            return value;
        }
    }
}