namespace StrategyPatternAdvanced.DiscountRates
{
    public class PremiumDiscountRate: DiscountRate
    {
        protected override double DiscountRatePercentage => 0.1;
        public override double CalculateDiscount(double value)
        {
            return value * DiscountRatePercentage;
        }
    }
}