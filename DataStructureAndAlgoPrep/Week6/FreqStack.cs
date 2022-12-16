using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class FreqStack
{
    private int maxCount;
    private readonly IDictionary<int, int> valueToCountDictionary;
    private readonly IDictionary<int, Stack<int>> countToStackDictionary;

    public FreqStack()
    {
        this.maxCount = 0;
        this.valueToCountDictionary = new Dictionary<int, int>();
        this.countToStackDictionary = new Dictionary<int, Stack<int>>();
    }

    public void Push(int val)
    {
        if (!this.valueToCountDictionary.ContainsKey(val))
        {
            this.valueToCountDictionary.Add(val, 0);
        }

        this.valueToCountDictionary[val] = this.valueToCountDictionary[val] + 1;

        if (this.valueToCountDictionary[val] > this.maxCount)
        {
            this.maxCount = this.valueToCountDictionary[val];
        }

        if (!this.countToStackDictionary.ContainsKey(this.maxCount))
        {
            this.countToStackDictionary.Add(this.maxCount, new Stack<int>());
        }

        this.countToStackDictionary[this.valueToCountDictionary[val]].Push(val);
    }

    public int Pop()
    {
        int value = this.countToStackDictionary[this.maxCount].Pop();

        if (this.countToStackDictionary[this.maxCount].Count == 0)
        {
            this.maxCount--;
        }

        this.valueToCountDictionary[value]--;

        return value;
    }
}
