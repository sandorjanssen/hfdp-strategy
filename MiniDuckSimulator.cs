using MiniDuckSimulator;

namespace MiniDuckSimulator
{
    public static class MiniDuckSimulator
    {
        static void Main()
        {
            Duck mallard = new MallardDuck();

            mallard.Display();
            
            mallard.PerformFly();
            
            mallard.PerformQuack();
        }
    }
}