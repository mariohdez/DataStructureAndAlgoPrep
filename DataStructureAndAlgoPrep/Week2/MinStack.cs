using System;
using System.Collections.Generic;
namespace DataStructureAndAlgoPrep.Week2
{
    public class MinStack
    {
        private Stack<int> mainStack;
        private Stack<int> minStack;

        public MinStack()
        {
            this.mainStack = new Stack<int>();
            this.minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            this.mainStack.Push(val);

            if (this.minStack.Count == 0 || this.minStack.Peek() >= val)
            {
                this.minStack.Push(val);
            }
        }

        public void Pop()
        {
            int value = this.mainStack.Pop();

            if (this.minStack.Peek() == value)
            {
                this.minStack.Pop();
            }
        }

        public int Top()
        {
            return this.mainStack.Peek();
        }

        public int GetMin()
        {
            return this.minStack.Peek();
        }
    }
}
