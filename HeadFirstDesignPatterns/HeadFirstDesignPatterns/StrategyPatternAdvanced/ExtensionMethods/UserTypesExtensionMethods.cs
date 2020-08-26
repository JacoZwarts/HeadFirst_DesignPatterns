using StrategyPatternAdvanced.Attributes;
using StrategyPatternAdvanced.DiscountRates;
using StrategyPatternAdvanced.Enums;
using System;
using System.Linq;

namespace StrategyPatternAdvanced.ExtensionMethods
{
    public static class UserTypesExtensionMethods
    {
        public static DiscountRate GetDiscountRateImplementation(this Enum userType)
        {
            var fields = typeof(UserTypes).GetFields();
            var attribute = typeof(UserTypes).GetFields()
                .FirstOrDefault(f => f.Name == userType.ToString())
                ?.GetCustomAttributes(false).First() as UserTypeAttribute;

            if (attribute != null)
                return attribute.InstantiateDiscountRate;

            throw new NotImplementedException();
        }
    }
}