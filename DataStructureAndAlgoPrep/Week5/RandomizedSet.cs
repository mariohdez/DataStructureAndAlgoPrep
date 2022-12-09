using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week5
{
    public class RandomizedSet
    {
        private readonly IDictionary<int, int> valueToIndexMap;
        private readonly IList<int> values;
        private readonly Random random;

        public RandomizedSet()
        {
            this.valueToIndexMap = new Dictionary<int, int>();
            this.values = new List<int>();
            this.random = new Random();
        }

        public bool Insert(int val)
        {
            if (this.valueToIndexMap.ContainsKey(val))
            {
                return false;
            }

            int index = this.values.Count;
            this.values.Insert(index, val);
            this.valueToIndexMap.Add(val, index);

            return true;
        }

        public bool Remove(int val)
        {
            if (!this.valueToIndexMap.ContainsKey(val))
            {
                return false;
            }

            int lastElement = this.values[this.values.Count - 1];
            int idx = this.valueToIndexMap[val];
            this.values[idx] = lastElement;
            this.valueToIndexMap[lastElement] = idx;


            this.values.RemoveAt(this.values.Count - 1);
            this.valueToIndexMap.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            return this.values[this.random.Next(this.values.Count)];
        }
    }
}

