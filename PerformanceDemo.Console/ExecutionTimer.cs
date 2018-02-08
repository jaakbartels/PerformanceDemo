using System;
using System.Diagnostics;

namespace PerformanceDemo
{
    public class ExecutionTimer : IDisposable
    {

        public ExecutionTimer(string message)
        {
            Console.WriteLine($"starting: {message}");
            _stopwatch = new Stopwatch();
            _message = message;
            _stopwatch.Start();
        }

        private Stopwatch _stopwatch;
        private string _message;

        public void Dispose()
        {
            _stopwatch.Stop();
            Console.WriteLine($"{_message} took {_stopwatch.ElapsedMilliseconds} ms");
        }
    }
}