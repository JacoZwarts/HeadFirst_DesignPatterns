namespace StrategyPatternAdvanced.DiscountRates
{
    public class DiamondDiscountRate : DiscountRate
    {
        protected override double DiscountRatePercentage => 0.2;

        public override double CalculateDiscount(double value)
        {
            return value * DiscountRatePercentage;
        }
    }
}