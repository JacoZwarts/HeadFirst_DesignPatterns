namespace StrategyPatternAdvanced.DiscountRates
{
    public class StandardDiscountRate: DiscountRate
    {
        protected override double DiscountRatePercentage => 0.0;
        public override double CalculateDiscount(double value)
        {
            return value * DiscountRatePercentage;
        }
    }
}