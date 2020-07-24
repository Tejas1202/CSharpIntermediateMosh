using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Exercise
{
    // Hence here, Workflow engine doesn't care about concrete implementation of activities, all it cares about is these activities
    // have a common interface that provides a method Execute()
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
