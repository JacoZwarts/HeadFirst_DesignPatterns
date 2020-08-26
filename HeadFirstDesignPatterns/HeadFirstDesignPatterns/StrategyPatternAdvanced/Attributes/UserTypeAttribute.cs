using StrategyPatternAdvanced.DiscountRates;
using System;

namespace StrategyPatternAdvanced.Attributes
{
    public class UserTypeAttribute : Attribute
    {
        private Type _discountRate { get; }

        public DiscountRate InstantiateDiscountRate => (DiscountRate)Activator.CreateInstance(_discountRate);

        public UserTypeAttribute(Type discountRate)
        {
            _discountRate = discountRate;
        }
    }
}