using StrategyPatternAdvanced.DiscountRates;

namespace StrategyPatternAdvanced
{
    public class PurchaseOrder
    {
        public PurchaseOrder(User user, double value)
        {
            User = user;
            Value = value;
        }

        public double Value { get; set; }
        public User User { get; set; }

        private DiscountRate _discountRate => User.GetDiscountRate();

        public double CalculateOrderPrice() => Value - _discountRate.CalculateDiscount(Value);
    }
}