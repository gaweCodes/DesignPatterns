using System;

namespace Adapter
{
    public class WorkflowObjectOutput : WorkflowObject
    {
        private readonly string _outputText;
        public WorkflowObjectOutput(string id, string outputText) : base(id)
        {
            _outputText = outputText;
        }
        public override WorkflowResult Execute()
        {
            var result = GetResultObject();
            try
            {
                Console.WriteLine(_outputText);
                return base.Execute();
            }
            catch (Exception ex)
            {
                result.Successful = false;
                result.ErrorMessage = ex.Message;
                return result;
            }
        }
    }
}