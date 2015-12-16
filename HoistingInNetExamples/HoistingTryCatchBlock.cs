using System.Runtime.CompilerServices;

namespace HoistingInNetExamples
{
    public class HoistingTryCatchBlock
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public int Run(int a)
        {
            var sum = 0;

            for (var i = 0; i < 11; i++)
            {
                try
                {
                    sum += a;
                }
                catch { }
            }

            return sum;
        }
    }
}