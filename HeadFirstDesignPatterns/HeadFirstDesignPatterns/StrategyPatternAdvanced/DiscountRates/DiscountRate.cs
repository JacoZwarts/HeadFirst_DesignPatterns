namespace StrategyPatternAdvanced.DiscountRates
{
    public abstract class DiscountRate
    {
        protected abstract double DiscountRatePercentage { get; }

        public abstract double CalculateDiscount(double value);
    }
}