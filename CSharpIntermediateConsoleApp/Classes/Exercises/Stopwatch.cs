using System;

namespace CSharpIntermediateConsoleApp.Classes.Exercises
{
    class Stopwatch
    {
        public TimeSpan Duration { get; private set; }

        /// <summary>
        /// As this field is about the implementation detail, it's related to the concept of this class, so we define it as a private field
        /// as we don't want other class to mess up with this. Also we're not declaring this as a get private set property as there's no point
        /// in getting this property outside of a class. Hence private field is the best thing to do
        /// </summary>
        private DateTime _startTime;

        private bool _hasStarted;

        public void Start()
        {
            if (_hasStarted)
                throw new InvalidOperationException("The stop watch has already been started before");

            _startTime = DateTime.Now;
            _hasStarted = true;
        }

        public void Stop()
        {
            if (!_hasStarted)
                throw new InvalidOperationException("Stopwatch is not running!");

            Duration = DateTime.Now - _startTime;
            _hasStarted = false;
        }
    }
}
