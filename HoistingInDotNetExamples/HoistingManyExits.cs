using System.Runtime.CompilerServices;

namespace HoistingInNetExamples
{
    public class HoistingManyExits
    {
        public int a = 123;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public int Run()
        {
            var sum = 0;

            for (var i = 0; i < 11; i++)
            {
                if (sum > 123) return sum;
                sum += a;
            }

            return sum;
        }
    }
}