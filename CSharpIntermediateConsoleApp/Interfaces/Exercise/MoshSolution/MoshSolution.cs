using System;
using System.Collections.Generic;

namespace CSharpIntermediateConsoleApp.Interfaces.Exercise.MoshSolution
{
    class MoshSolution
    {
        public void Caller()
        {
            var workFlow = new WorkFlow();
            workFlow.AddWorkFlowObject(new VideoUploader());
            workFlow.AddWorkFlowObject(new CallWebService());
            workFlow.AddWorkFlowObject(new SendEmail());
            workFlow.AddWorkFlowObject(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);
        }

    }

    public interface ITask
    {
        void Execute();
    }

    #region Activities
    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded to cloud storage");
        }
    }

    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Video ready for encoding");
        }
    }

    class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Your video processing has started. Please check email");
        }
    }

    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Database result: Processing");
        }
    }
    #endregion

    public interface IWorkFlow
    {
        void AddWorkFlowObject(ITask task);
        void RemoveWorkFlowObject(ITask task);
        IEnumerable<ITask> GetTasks();
    }

    public class WorkFlow : IWorkFlow
    {
        private readonly List<ITask> _tasks;

        public WorkFlow()
        {
            _tasks = new List<ITask>();
        }

        public void AddWorkFlowObject(ITask task)
        {
            _tasks.Add(task);
        }

        public void RemoveWorkFlowObject(ITask task)
        {
            _tasks.Remove(task);
        }

        //Returning IEnumerable instead of a List to make sure we return a readonly list as IEnumerable is an interface which does not
        //have methods like Add/Remove unlike List. So this way, our list is not compromised and IEnumerable can be iterated through
        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }

    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach(var task in workFlow.GetTasks())
            {
                task.Execute();
            }
        }
    }
}
