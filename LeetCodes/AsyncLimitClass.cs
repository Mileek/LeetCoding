using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class AsyncLimitClass
    {
        static async Task ProcessAsync(int id)
        {
            Console.WriteLine($"Start {id}");
            await Task.Delay(1000);
            Console.WriteLine($"End {id}");
        }

        public async Task Run()
        {
            SemaphoreSlim semaphore = new SemaphoreSlim(3);
            var tasks = Enumerable.Range(1, 20)
            .Select(async i =>
            {
                await semaphore.WaitAsync();
                try
                {
                    await ProcessAsync(i);
                }
                finally
                {
                    semaphore.Release();
                }
            });

            await Task.WhenAll(tasks);
        }
    }
}
