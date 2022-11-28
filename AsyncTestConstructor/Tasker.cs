using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTestConstructor
{
    internal class Tasker
    {
        public async Task<string> GetStringAsync(int delaySeconds)
        {
            return await Task.Run(async () => {
                Console.WriteLine($"Start processing GetStringAsync with delay {delaySeconds}");
                ////if (delaySeconds == 10)
                ////{
                ////    throw new Exception();
                ////}

                await Task.Delay(delaySeconds);
                Thread.Sleep(delaySeconds * 1000);
                Console.WriteLine($"End processing GetStringAsync with delay {delaySeconds}");
                return $"task_{delaySeconds}";
            });
        }
    }
}
