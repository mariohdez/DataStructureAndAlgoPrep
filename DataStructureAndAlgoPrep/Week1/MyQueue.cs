using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week1
{
    public class MyQueue
    {
        public int Front { get; set; }

        public Stack<int> Stack1 { get; set; }

        public Stack<int> Stack2 { get; set; }


        public MyQueue()
        {
            this.Stack1 = new Stack<int>();
            this.Stack2 = new Stack<int>();
        }

        public void Push(int x)
        {
            if (this.Stack1.Count == 0)
            {
                this.Front = x;
            }

            this.Stack1.Push(x);
        }

        public int Pop()
        {
            if (this.Stack2.Count == 0)
            {
                while (this.Stack1.Count > 0)
                {
                    this.Stack2.Push(this.Stack1.Pop());
                }
            }

            return this.Stack2.Pop();
        }

        public int Peek()
        {
            if (this.Stack2.Count == 0)
            {
                return this.Front;
            }
            else
            {
                return this.Stack2.Peek();
            }
        }

        public bool Empty()
        {
            return this.Stack1.Count == 0 && this.Stack2.Count == 0;
        }
    }
}
