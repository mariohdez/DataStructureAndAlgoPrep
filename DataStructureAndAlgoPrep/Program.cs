using System;
using System.Collections.Generic;
using DataStructureAndAlgoPrep.Week1;
using DataStructureAndAlgoPrep.Week6;

namespace DataStructureAndAlgoPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] asteroids = new int[] { 60, 45, 20, -40, -50 };

            var test = new AsteroidCollisionSln();

            var result = test.AsteroidCollision(asteroids);
        }
    }
}
