using System;
using System.Runtime.CompilerServices;

namespace HoistingInNetExamples
{
    public class HoistingNotDoWhile
    {
        public int a = 123;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public int Run()
        {
            var sum = 0;

            for (; ShouldContinue(); )
            {
                sum += a;
            }

            return sum;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private bool ShouldContinue()
        {
            return new Random().Next(100) <= 90;
        }
    }
}