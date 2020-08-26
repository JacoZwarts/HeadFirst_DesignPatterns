using StrategyPatternAdvanced.Attributes;
using StrategyPatternAdvanced.DiscountRates;

namespace StrategyPatternAdvanced.Enums
{
    public enum UserTypes
    {
        [UserType(typeof(StandardDiscountRate))]
        STANDARD,

        [UserType(typeof(PremiumDiscountRate))]
        PREMIUM,

        [UserType(typeof(DiamondDiscountRate))]
        DIAMOND
    }
}