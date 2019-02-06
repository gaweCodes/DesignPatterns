using System.Collections.Generic;

namespace Adapter
{
    public class WorkflowEngine
    {
        private List<WorkflowObject> _workflowObjects;
        public WorkflowEngine()
        {
            _workflowObjects = new List<WorkflowObject>();
        }
        public void AddWorkflowObject(WorkflowObject workflowObject)
        {
            _workflowObjects.Add(workflowObject);
        }
        public WorkflowResult ExecuteAll()
        {
            foreach (var workflowObject in _workflowObjects)
            {
                var result = workflowObject.Execute();
                if (!result.Successful)
                    return result;
            }
            return new WorkflowResult("Engine") {Successful = true};
        }
    }
}
