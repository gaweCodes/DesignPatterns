using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main()
        {
            var engine = new WorkflowEngine();
            var smallOutput = new WorkflowObjectOutput("1", "small output");
            engine.AddWorkflowObject(smallOutput);
            var bigOutput = new WorkflowAdapterOutputBig("2", "big output");
            engine.AddWorkflowObject(bigOutput);
            var bigOutputWithChild = new WorkflowAdapterOutputBig("3", "big output 2");
            var childTask = new WorkflowObjectOutput("4", "small sub output");
            bigOutputWithChild.AddWorkflowObject(childTask);
            engine.AddWorkflowObject(bigOutputWithChild);
            var result = engine.ExecuteAll();
            Console.WriteLine(result.ObjectId + " " + result.Successful + " " + result.ErrorMessage);
            Console.ReadLine();
        }
    }
}
