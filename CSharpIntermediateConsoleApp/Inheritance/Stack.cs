using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Inheritance
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
            if (obj is null)
                throw new InvalidOperationException("parameter cannot be null");

            arrayList.Add(obj);
        }

        public object Pop()
        {
            if (arrayList.Count == 0)
                throw new InvalidOperationException("Cannot perform this operation on empty list");

            var lastElement = arrayList[arrayList.Count - 1];
            arrayList.Remove(lastElement);

            return lastElement;
        }

        public void Clear()
        {
            arrayList.Clear();
        }
    }
}
