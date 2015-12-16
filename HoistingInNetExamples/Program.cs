using System;

namespace HoistingInNetExamples
{
    class Program
    {
        static void Main()
        {
            new HoistingArray().Run(new int[11]);
            new HoistingStatic().Run();
            new HoistingStruct().Run(new HoistingStruct.MyStruct(1));
            new HoistingJitHelperMethod<object>().Run();
            new HoistingTryCatchBlock().Run(11);
            new HoistingField().Run();
            new HoistingArg().Run(1);
            new HoistingManyExits().Run();
            new HoistingManyVars().Run(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            new HoistinMath().Run(1);
            new HoistingNotDoWhile().Run();

            Console.WriteLine("Finished!");
            Console.ReadKey();
        }
    }
}