using System;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stacker();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push("Eric");

            stack.Pop();
            stack.Pop();

            stack.Clear();

            stack.IterateOverStack();

            Console.ReadLine();
        }
    }
}
