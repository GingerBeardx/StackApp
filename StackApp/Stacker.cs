using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackApp
{
    class Stacker
    {
        private List<object> Stack { get; set; } = new List<object>();

        public void Push(object item)
        {
            if (item == null)
                throw new InvalidOperationException("Item cannot be null");

            Stack.Add(item);
        }

        public void Pop()
        {
            if (Stack.Count > 0)
            {
                var lastItemInStack = Stack.Count - 1;
                Console.WriteLine(Stack.ElementAt(lastItemInStack));

                Stack.RemoveAt(Stack.Count - 1);
            }
        }

        public void IterateOverStack()
        {
            foreach (var item in Stack)
            {
                Console.WriteLine(item);
            }
        }

        public void Clear()
        {
            Stack.Clear();
            Console.WriteLine("Stack cleared");
        }
    }
}
