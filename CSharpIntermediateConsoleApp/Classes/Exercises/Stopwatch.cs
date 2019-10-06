using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Classes.Exercises
{
    class Stopwatch
    {
        public TimeSpan Duration { get; private set; }
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
            Duration = DateTime.Now - _startTime;
            _hasStarted = false;
        }
    }
}
