using System.Diagnostics;

namespace AsyncTestConstructor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var swatch = new Stopwatch();
            swatch.Start();
            var myTasker = new Tasker();

            //! VER 1
            var result1 = await myTasker.GetStringAsync(5);
            var result2 = await myTasker.GetStringAsync(10);
            var result3 = await myTasker.GetStringAsync(15);
            var myA = new ClassA(result1, result2, result3);

            //! VER 2
            ////var task1 = myTasker.GetStringAsync(5);
            ////var task2 = myTasker.GetStringAsync(10);
            ////var task3 = myTasker.GetStringAsync(15);

            ////var result = await Task.WhenAll(task1, task2, task3);
            ////var myA = new ClassA(result[0], result[1], result[2]);

            swatch.Stop();
            Console.WriteLine(swatch.Elapsed);
        }
    }
}