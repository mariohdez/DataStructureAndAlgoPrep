using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week4
{
    public class MedianFinder
    {
        private PriorityQueue<int, int> smallHeap;
        private PriorityQueue<int, int> largeHeap;

        public MedianFinder()
        {
            this.smallHeap = new PriorityQueue<int, int>(new MaxHeapComparer());
            this.largeHeap = new PriorityQueue<int, int>(new MinHeapComparer());
        }

        public void AddNum(int num)
        {
            this.smallHeap.Enqueue(num, num);
            int value = -1;

            while (Math.Abs(this.smallHeap.Count - this.largeHeap.Count) > 1 || this.smallHeap.Count > 0 && this.largeHeap.Count > 0 && this.smallHeap.Peek() > this.largeHeap.Peek())
            {
                if (Math.Abs(this.smallHeap.Count - this.largeHeap.Count) > 1)
                {
                    if (this.smallHeap.Count > this.largeHeap.Count)
                    {
                        value = this.smallHeap.Dequeue();
                        this.largeHeap.Enqueue(value, value);
                    }
                    else
                    {
                        value = this.largeHeap.Dequeue();
                        this.smallHeap.Enqueue(value, value);
                    }
                }

                if (this.smallHeap.Count > 0 && this.largeHeap.Count > 0 && this.smallHeap.Peek() > this.largeHeap.Peek())
                {
                    value = this.smallHeap.Dequeue();
                    this.largeHeap.Enqueue(value, value);
                }
            }
        }

        public double FindMedian()
        {
            if (this.smallHeap.Count == this.largeHeap.Count)
            {
                return ((double)this.smallHeap.Peek() + (double)this.largeHeap.Peek()) / 2.0;
            }
            else if (this.smallHeap.Count > this.largeHeap.Count)
            {
                return (double)this.smallHeap.Peek();
            }
            else
            {
                return (double)this.largeHeap.Peek();
            }
        }

    }

    public class MaxHeapComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }

    public class MinHeapComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }
}
