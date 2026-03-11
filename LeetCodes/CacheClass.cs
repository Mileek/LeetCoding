using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class CacheClass
    {
        private ExpensiveService service = new ExpensiveService();
        private int? value = null;
        private readonly object _lock = new();

        public int GetValue()
        {
            if (value == null)
            {
                lock (_lock)
                {
                    if (value == null)
                    {
                        value = service.Calculate();
                    }
                }
            }

            return value.Value;
        }

        public async Task Run()
        {
            var cache = new CacheClass();

            var tasks = Enumerable.Range(0, 10)
                .Select(_ => Task.Run(() =>
                {
                    var value = cache.GetValue();
                    Console.WriteLine(value);
                }));

            await Task.WhenAll(tasks);
        }
    }
    class ExpensiveService
    {
        public int Calculate()
        {
            Thread.Sleep(1000);
            return 42;
        }
    }
}
