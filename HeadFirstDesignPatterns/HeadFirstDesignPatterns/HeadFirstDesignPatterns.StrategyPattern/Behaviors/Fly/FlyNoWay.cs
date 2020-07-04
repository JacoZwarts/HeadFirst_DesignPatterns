using System;
using HeadFirstDesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace HeadFirstDesignPatterns.StrategyPattern.Behaviors.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void performFly()
        {
            Console.WriteLine("I can't fly!!");
        }
    }
}