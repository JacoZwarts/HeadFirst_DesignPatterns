using System;
using System.Collections.Generic;
using System.Text;
using HeadFirstDesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace HeadFirstDesignPatterns.StrategyPattern.Behaviors.Quack
{
    public class Quack: IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("Quack");
        }
    }
}
