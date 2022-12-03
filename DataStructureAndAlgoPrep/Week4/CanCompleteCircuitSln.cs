using System;
namespace DataStructureAndAlgoPrep.Week4
{
    public class CanCompleteCircuitSln
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int sumOfGas = 0;
            int sumOfCost = 0;
            for (int i = 0; i < gas.Length; ++i)
            {
                sumOfGas += gas[i];
                sumOfCost += cost[i];
            }

            if (sumOfGas < sumOfCost) return -1;

            int total = 0;
            int startingIndex = 0;

            for (int i = 0; i < gas.Length; ++i)
            {
                total += gas[i] - cost[i];
                if (total < 0)
                {
                    total = 0;
                    startingIndex = i + 1;
                }
            }

            return startingIndex;
        }
    }
}
