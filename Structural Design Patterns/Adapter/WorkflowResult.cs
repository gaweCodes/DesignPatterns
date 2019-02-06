namespace Adapter
{
    public class WorkflowResult
    {
        public string ObjectId { get; }
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; }
        public WorkflowResult(string id)
        {
            ObjectId = id;
        }
    }
}
