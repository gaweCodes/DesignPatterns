using System;

namespace Adapter
{
    public class WorkflowObjectOutputBig
    {
        private readonly string _outputText;
        public WorkflowObjectOutputBig(string outputText)
        {
            _outputText = outputText;
        }
        public WorkflowResultB Start()
        {
            Console.WriteLine(_outputText.ToUpper());
            return new WorkflowResultB {Result = 1};
        }
    }
}
