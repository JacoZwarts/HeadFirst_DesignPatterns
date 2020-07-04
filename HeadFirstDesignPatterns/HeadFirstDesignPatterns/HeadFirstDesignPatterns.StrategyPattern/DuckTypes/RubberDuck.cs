using HeadFirstDesignPatterns.StrategyPattern.Behaviors.Interfaces;
using System;

namespace HeadFirstDesignPatterns.StrategyPattern.DuckTypes
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}