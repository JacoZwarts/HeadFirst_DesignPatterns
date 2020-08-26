using StrategyPatternAdvanced.DiscountRates;
using StrategyPatternAdvanced.Enums;
using StrategyPatternAdvanced.ExtensionMethods;

namespace StrategyPatternAdvanced
{
    public class User
    {
        public User(string name, UserTypes userType)
        {
            Name = name;
            Type = userType;
        }

        public string Name { get; set; }
        public UserTypes Type { get; set; }

        public DiscountRate GetDiscountRate()
        {
            return Type.GetDiscountRateImplementation();
        }
    }
}