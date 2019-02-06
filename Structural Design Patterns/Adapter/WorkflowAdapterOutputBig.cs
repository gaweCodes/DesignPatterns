namespace Adapter
{
    public class WorkflowAdapterOutputBig : WorkflowObject
    {
        private readonly WorkflowObjectOutputBig _instance;
        public WorkflowAdapterOutputBig(string id, string outputText) : base(id)
        {
            _instance = new WorkflowObjectOutputBig(outputText);
        }
        public override WorkflowResult Execute()
        {
            var result = GetResultObject();
            var resultB = _instance.Start();
            if (resultB.Result > 0)
                result.Successful = true;
            else
            {
                result.Successful = false;
                result.ErrorMessage = "n/a";
            }
            return result.Successful ? base.Execute() : result;
        }
    }
}
