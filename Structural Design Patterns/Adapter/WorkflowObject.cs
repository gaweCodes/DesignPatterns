using System;
using System.Collections.Generic;

namespace Adapter
{
    public abstract class WorkflowObject
    {
        private readonly List<WorkflowObject> _workflowObjects;
        private readonly string _objectId;
        protected WorkflowObject(string id)
        {
            _workflowObjects = new List<WorkflowObject>();
            _objectId = id;
        }
        public void AddWorkflowObject(WorkflowObject workflowObject)
        {
            _workflowObjects.Add(workflowObject);
        }
        protected WorkflowResult GetResultObject()
        {
            return new WorkflowResult(_objectId);
        }
        public virtual WorkflowResult Execute()
        {
            var result = new WorkflowResult(_objectId);
            foreach (var workflowObject in _workflowObjects)
            {
                try
                {
                    var resultChildObject = workflowObject.Execute();
                    if (!resultChildObject.Successful)
                        return resultChildObject;
                }
                catch (Exception ex)
                {
                    result.Successful = false;
                    result.ErrorMessage = ex.Message;
                    return result;
                }
            }
            result.Successful = true;
            return result;
        }
    }
}
