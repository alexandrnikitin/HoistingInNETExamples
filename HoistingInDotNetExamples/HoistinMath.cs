using System;
using System.Runtime.CompilerServices;

namespace HoistingInDotNetExamples
{
    public class HoistinMath
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public double Run(int a)
        {
            var sum = 0d;

            for (var i = 0; i < 11; i++)
            {
                sum += Math.Abs(a) + Math.Pow(2, 2);
            }

            return sum;
        }
    }
}