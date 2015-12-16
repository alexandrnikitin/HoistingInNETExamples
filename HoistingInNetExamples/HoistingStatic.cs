using System.Runtime.CompilerServices;

namespace HoistingInNetExamples
{
    public class HoistingStatic
    {
        public static int a = 123;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public int Run()
        {
            var sum = 0;

            for (var i = 0; i < 11; i++)
            {
                sum += a;
            }

            return sum;
        }
    }
}