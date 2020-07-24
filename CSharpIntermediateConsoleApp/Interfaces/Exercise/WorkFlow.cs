using System;
using System.Collections.Generic;

namespace CSharpIntermediateConsoleApp.Interfaces.Exercise
{
    class WorkFlow
    {
        // From the exercise, it's mentioned that a workflow is a series of steps/activities, hence creating list of Activities
        public IList<IActivity> ActivitiesList { get; }

        public WorkFlow(IList<IActivity> activityList)
        {
            ActivitiesList = activityList ?? throw new ArgumentNullException("activityList", "cannot pass null list as parameter");
        }

    }
}
