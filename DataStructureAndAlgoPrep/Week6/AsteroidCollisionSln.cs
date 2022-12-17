using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week6;

public class AsteroidCollisionSln
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        if (asteroids == null || asteroids.Length == 0) return new int[] { };

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < asteroids.Length; ++i)
        {
            if (stack.Count > 0 && WillCollide(stack.Peek(), asteroids[i]))
            {
                bool asteroidBSurvived = false;
                while (stack.Count > 0 && WillCollide(stack.Peek(), asteroids[i]))
                {
                    asteroidBSurvived = false;
                    int astroidA = stack.Pop();
                    int astoidB = asteroids[i];

                    int absoluteAstroidA = Math.Abs(astroidA);
                    int absoluteAstroidB = Math.Abs(astoidB);

                    if (absoluteAstroidA == absoluteAstroidB)
                    {
                        break;
                    }

                    if (absoluteAstroidA > absoluteAstroidB)
                    {
                        stack.Push(astroidA);
                        break;
                    }
                    else
                    {
                        asteroidBSurvived = true;
                    }
                }

                if (asteroidBSurvived)
                {
                    stack.Push(asteroids[i]);
                }
            }
            else
            {
                stack.Push(asteroids[i]);
            }
        }

        int[] answer = new int[stack.Count];

        for (int i = answer.Length - 1; i > -1; --i)
        {
            answer[i] = stack.Pop();
        }

        return answer;
    }

    public bool WillCollide(int asteroidA, int asteroidB)
    {
        if (asteroidA < 0)
        {
            return false;
        }

        return asteroidA > 0 && asteroidB < 0;
    }
}
