using System;

namespace MiniDuckSimulator
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new NormalQuack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}