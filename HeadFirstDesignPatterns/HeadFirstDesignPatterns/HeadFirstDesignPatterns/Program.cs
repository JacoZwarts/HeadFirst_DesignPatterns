using HeadFirstDesignPatterns.StrategyPattern.Behaviors.Fly;
using HeadFirstDesignPatterns.StrategyPattern.Behaviors.Quack;
using HeadFirstDesignPatterns.StrategyPattern.DuckTypes;
using StrategyPatternAdvanced;
using StrategyPatternAdvanced.Enums;
using System;

namespace HeadFirstDesignPatterns
{
    public class Program
    {
        private static void Main(string[] args)
        {
            StrategyPatternAdvanced();
        }

        public static void StrategyPatternBasic()
        {
            // Strategy Pattern Definition:
            // Defines a family of algorithms encapsulates each one, and make them interchangeable
            // Strategy lets the algorithm vary independently from the clients that use them.
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
        }

        public static void StrategyPatternAdvanced()
        {
            var standardOrder = new PurchaseOrder(new User("Jaco Zwarts", UserTypes.STANDARD), 1000);
            Console.WriteLine(standardOrder.CalculateOrderPrice());
            var premiumOrder = new PurchaseOrder(new User("Jaco Zwarts", UserTypes.PREMIUM), 1000);
            Console.WriteLine(premiumOrder.CalculateOrderPrice());
            var diamondOrder = new PurchaseOrder(new User("Jaco Zwarts", UserTypes.DIAMOND), 1000);
            Console.WriteLine(diamondOrder.CalculateOrderPrice());
        }
    }
}