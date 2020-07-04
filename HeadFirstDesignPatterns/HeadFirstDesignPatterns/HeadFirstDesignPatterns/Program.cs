using System;
using HeadFirstDesignPatterns.StrategyPattern.Behaviors.Fly;
using HeadFirstDesignPatterns.StrategyPattern.Behaviors.Quack;
using HeadFirstDesignPatterns.StrategyPattern.DuckTypes;

namespace HeadFirstDesignPatterns
{
    public class Program
    {
        private static void Main(string[] args)
        {
            #region Strategy Pattern
            // Strategy Pattern Definition:
            // Defines a family of algorithms encapsulates each one, and make them interchangeable
            // Strategy lets the algorithm vary independently from the user that use them.
            var mallardDuck = new MallardDuck(new FlyWithWings(), new Quack());
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();

            Console.WriteLine("\nNew Duck: \n");

            var rubberDuck = new RubberDuck(new FlyNoWay(), new Squeak());
            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();
            rubberDuck.Swim();

            #endregion Strategy Pattern
        }
    }
}