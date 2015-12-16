using System.Runtime.CompilerServices;

namespace HoistingInNetExamples
{
    public class HoistingStruct
    {
        public struct MyStruct
        {
            public int Value;

            public MyStruct(int value)
            {
                Value = value;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public int Run(MyStruct n)
        {
            var sum = 0;

            for (var i = 0; i < 11; i++)
            {
                sum += n.Value;
            }

            return sum;
        }

    }
}