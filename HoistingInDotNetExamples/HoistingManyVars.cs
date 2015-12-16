using System.Runtime.CompilerServices;

namespace HoistingInDotNetExamples
{
    public class HoistingManyVars
    {
        public int a = 123;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public int Run(
            int x1,
            int x2,
            int x3,
            int x4,
            int x5,
            int x6,
            int x7,
            int x8,
            int x9,
            int x10)
        {
            var sum = 0;

            for (var i = 0; i < 11; i++)
            {
                sum += x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + a;
            }

            return sum;
        }
    }
}