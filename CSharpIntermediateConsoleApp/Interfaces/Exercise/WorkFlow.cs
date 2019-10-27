using System;
using System.Collections.Generic;

namespace CSharpIntermediateConsoleApp.Interfaces.Exercise
{
    class WorkFlow
    {
        public IList<IActivity> ActivitiesList { get; }

        public WorkFlow(List<IActivity> activityList)
        {
            ActivitiesList = activityList ?? throw new ArgumentNullException("activityList", "cannot pass null list as parameter");
        }

    }
}
