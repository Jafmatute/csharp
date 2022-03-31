using System;
using System.Threading;

namespace CSharpIntermediate.Exercises
{
    class Stopwatch
    {

       
        private DateTime _startStopwatch;
        private DateTime _endStopwatch;
        private bool _running;

        public void Start()
        {
           
            if (_running)
                throw new InvalidOperationException("Stopwatch running ");

            _startStopwatch = DateTime.Now;
            _running = true;

            Console.WriteLine("Start: {0}", _startStopwatch.ToString("mm\\:ss\\.ff"));

        }

        public void Stop()
        {
            if(!_running)
                throw new InvalidOperationException("Stopwatch is not running ");

            _endStopwatch = DateTime.Now;
            _running = true;

        }


        public TimeSpan GetIntervaSpan() => _endStopwatch - _startStopwatch;
    }
}
