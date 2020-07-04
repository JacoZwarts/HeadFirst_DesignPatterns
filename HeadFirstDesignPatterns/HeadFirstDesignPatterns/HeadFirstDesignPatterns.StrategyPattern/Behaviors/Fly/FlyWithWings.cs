using System;
using HeadFirstDesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace HeadFirstDesignPatterns.StrategyPattern.Behaviors.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void performFly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}