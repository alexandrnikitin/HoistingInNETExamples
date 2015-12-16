using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace HoistingInNetExamples
{
    public class HoistingJitHelperMethod<T>
    {
        private List<T> _list = new List<T>();

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Run()
        {
            for (var i = 0; i < 11; i++)
            {
                if (_list.Any())
                {
                    return;
                }
            }
        }
    }
}