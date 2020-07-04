using HeadFirstDesignPatterns.StrategyPattern.Behaviors.Interfaces;
using System;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.performFly();
        }

        public void PerformQuack()
        {
            _quackBehavior.PerformQuack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}