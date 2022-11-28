using System.Diagnostics;

namespace AsyncTestConstructor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ClassA myClass;
            var swatch = new Stopwatch();
            swatch.Start();
            var myTasker = new Tasker();

            //! VER 1 - parallel
            var result1Task = myTasker.GetStringAsync(5);
            var result2Task = myTasker.GetStringAsync(10);
            var result3Task = myTasker.GetStringAsync(15);

            var result1 = await result1Task;
            var result2 = await result2Task;
            var result3 = await result3Task;

            myClass = new ClassA(result1, result2, result3);
            //this is the same as above...
            //myClass = new ClassA(await result1Task, await result2Task, await result3Task);

            //! VER 2 - sequential

            //var result1 = await myTasker.GetStringAsync(5);
            //var result2 = await myTasker.GetStringAsync(10);
            //var result3 = await myTasker.GetStringAsync(15);

            //myClass = new ClassA(result1, result2, result3);

            //! VER 3 - parallel with exception
            //? some question
            //x some removed
            // some removed
            //var result1Task = myTasker.GetStringAsync(5);
            //var result2Task = myTasker.GetStringAsync(10);
            //var result3Task = myTasker.GetStringAsync(15);
            //ar result = await Task.WhenAll(result1Task, result2Task, result3Task);

            //myClass = new ClassA(result[0], result[1], result[2]);

            Console.WriteLine(myClass);

            swatch.Stop();
            Console.WriteLine($"Ellapsed time: {swatch.Elapsed}");
        }
    }
}