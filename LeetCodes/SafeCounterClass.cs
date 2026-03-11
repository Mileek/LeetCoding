using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class SafeCounterClass
    {
        private int value = 0;
        private readonly object _lock = new();

        public void Increment()
        {
            Parallel.For(0, 100_000, _ =>
            {
                Interlocked.Increment(ref value);
                lock (_lock)
                {
                    //value++;
                    Console.WriteLine(Get());
                }
            });

        }

        public int Get()
        {
            return value;
        }

        public void Run()
        {
            Increment();
        }
    }
    public class SafeCounter2Class
    {

        private int value = 0;
        private readonly object _lock = new();

        public void Increment()
        {
            lock (_lock) 
            {
                value++;
            }
        }

        public int Get()
        {
            return value;
        }

        public void Run()
        {
            var tasks = new List<Task>();

            for (int i = 0; i < 50; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        Increment();
                    }
                }));
            }

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine(Get());
        }
    }

}
