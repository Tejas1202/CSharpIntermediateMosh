using System;
using System.Collections;

namespace CSharpIntermediateConsoleApp.Inheritance.Exercise
{
    //Exercise part
    class Stack
    {
        private readonly ArrayList arrayList;

        public Stack()
        {
            arrayList = new ArrayList();
        }

        public void Push(object obj)
        {
            // Defensive programming: Our class should always be in a valid state
            if (obj is null)
                throw new ArgumentException("parameter cannot be null");

            arrayList.Add(obj);
        }

        public object Pop()
        {
            if (arrayList.Count == 0)
                throw new InvalidOperationException("Cannot perform this operation on empty list");

            int lastIndex = arrayList.Count - 1;
            var lastElement = arrayList[lastIndex];
            arrayList.RemoveAt(lastIndex);

            return lastElement;
        }

        public void Clear()
        {
            arrayList.Clear();
        }
    }
}
