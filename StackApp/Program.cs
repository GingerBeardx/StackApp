using System;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stacker();

            stack.Push(3);
            stack.Push("Eric");
            stack.Push(null);

            Console.ReadLine();
        }
    }
}
