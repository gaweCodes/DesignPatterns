using System;
using System.Collections.Generic;

namespace Composite
{
    internal class Program
    {
        private static void Main()
        {
            var warehouseProcess = new BpmSequence(1);
            var checkProcess = new BpmSequence(3);
            BpmComponent output = new BpmConsoleOutput(2, "There are new goods");
            warehouseProcess.Add(output);
            
            BpmComponent informLabor = new BpmConsoleOutput(4,"Please check the goods.");
            checkProcess.Add(informLabor);
            warehouseProcess.Add(checkProcess);
            warehouseProcess.Start();
            Console.ReadLine();
        }
    }
}
