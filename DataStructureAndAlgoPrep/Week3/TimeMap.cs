using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week3
{
    public class TimeMap
    {
        Dictionary<string, List<Tuple<int, string>>> keyToValueTimeMap;

        public TimeMap()
        {
            this.keyToValueTimeMap = new Dictionary<string, List<Tuple<int, string>>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            List<Tuple<int, string>> valueTimeList;
            if (!this.keyToValueTimeMap.ContainsKey(key))
            {
                this.keyToValueTimeMap.Add(key, new List<Tuple<int, string>>());
            }

            valueTimeList = this.keyToValueTimeMap[key];
            valueTimeList.Add(new Tuple<int, string>(timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            if (!this.keyToValueTimeMap.ContainsKey(key))
            {
                return string.Empty;
            }

            List<Tuple<int, string>> timeStampValueList = this.keyToValueTimeMap[key];

            if (timestamp < timeStampValueList[0].Item1)
            {
                return string.Empty;
            }

            int left = 0;
            int right = timeStampValueList.Count;
            int mid = 0;

            while (left < right)
            {
                mid = (right + left) / 2;

                if (timeStampValueList[mid].Item1 <= timestamp)
                {
                    left = mid + 1;
                }
                else
                {
                    left = mid;
                }
            }

            if (right == 0)
                return string.Empty;

            return timeStampValueList[right - 1].Item2;
        }
    }
}
