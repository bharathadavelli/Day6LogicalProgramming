using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class Stopwatch
    {
        public int Elapsed { get; private set; }

        public static void stopwatch()
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            object value = stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("HI");
            }
            // Stop timing
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",
                stopwatch.Elapsed);
            Console.ReadLine();
        }

        private void Stop()
        {
            throw new NotImplementedException();
        }

        private object Start()
        {
            throw new NotImplementedException();
        }
    }
}