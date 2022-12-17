using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class HitCounter
{
    private readonly Queue<int> timeStampQueue;
    public HitCounter()
    {
        this.timeStampQueue = new Queue<int>();
    }

    public void Hit(int timestamp)
    {
        this.timeStampQueue.Enqueue(timestamp);
    }

    public int GetHits(int timestamp)
    {
        while (this.timeStampQueue.Count > 0 && timestamp - this.timeStampQueue.Peek() >= 300)
        {
            this.timeStampQueue.Dequeue();
        }

        return this.timeStampQueue.Count;
    }
}
