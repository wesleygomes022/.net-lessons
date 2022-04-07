using System;
using System.Collections.Generic;

namespace TestProj.Services
{
    class CalculationService
    {
        public static T Max<T>(List<T> list) where T : IComparable
        {
            T max = list[0];
            for (int i = 1; i < list.Capacity - 1; i++)
            {
                if (max.CompareTo(list[i]) < 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
