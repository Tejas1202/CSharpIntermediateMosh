using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Exercise
{
    class WorkFlowEngine
    {
        public void Run(WorkFlow workFlow)
        {
            foreach (var activity in workFlow.ActivitiesList)
            {
                if (activity == null)
                    throw new ArgumentException("Activities cannot be null");

                activity.Execute();
            }
        }
    }
}
