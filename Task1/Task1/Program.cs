using System;
using System.Threading;
using System.Threading.Tasks;
namespace Task1
{

    class Program
    {
        static Random rand = new Random();

        static void Main()
        {
            // Wait on a single task with no timeout specified.
            Task taskA = Task.Run(() => Thread.Sleep(20000));
            Console.WriteLine("1 : taskA Status: {0}", taskA.Status);
            try
            {
                taskA.Wait(5000);
                Console.WriteLine("2 : taskA Status: {0}", taskA.Status);
            }
            catch (AggregateException)
            {
                Console.WriteLine("Exception in taskA.");
            }
        }
    }
    // The example displays output like the following:
    //     taskA Status: WaitingToRun
    //     taskA Status: RanToCompletion
}
