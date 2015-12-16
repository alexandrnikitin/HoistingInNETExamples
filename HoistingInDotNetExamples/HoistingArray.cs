using System.Runtime.CompilerServices;

namespace HoistingInNetExamples
{
    public class HoistingArray
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public int Run(int[] arr)
        {
            var sum = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[1] + arr[i];
            }

            return sum;
        }
    }
}