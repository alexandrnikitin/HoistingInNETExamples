using System.Runtime.CompilerServices;

namespace HoistingInDotNetExamples
{
    public class HoistingArg
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public int Run(int a)
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