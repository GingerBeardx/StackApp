using System;
using System.Collections.Generic;

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
            Console.WriteLine("Item added");
        }
    }
}
