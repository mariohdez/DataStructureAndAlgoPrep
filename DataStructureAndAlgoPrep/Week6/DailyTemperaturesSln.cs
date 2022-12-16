using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class DailyTemperaturesSln
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        if (temperatures == null || temperatures.Length == 0) return new int[] {};

        int[] answer = new int[temperatures.Length];
        Stack<(int temperature, int index)> stack = new Stack<(int temperature, int index)>();

        // init algorithm:
        stack.Push((temperatures[0], 0));

        for (int i = 1; i < temperatures.Length; ++i)
        {
            int currentTemperature = temperatures[i];
            int j = i;

            while (stack.Count > 0 && currentTemperature > stack.Peek().temperature)
            {
                (int temperature, int index) previousTemperature = stack.Pop();
                answer[previousTemperature.index] = i - previousTemperature.index;
            }

            stack.Push((currentTemperature, i));
        }

        return answer;
    }
}
