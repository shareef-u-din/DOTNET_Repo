using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PassingDataToThreads
{
    public class Program
    {
        public static void Main()
        {
            // Supply the state information required by the task.
            ThreadWithState tws = new ThreadWithState(
                "This report displays the number {0}.", 42);

            // Create a thread to execute the task, and then
            // start the thread.
            Thread t = new Thread(new ThreadStart(tws.ThreadProc));
            t.Start();
            Console.WriteLine("Main thread does some work, then waits.");
            Thread.Sleep(3000);
            t.Join();
            Console.WriteLine(
                "Independent task has completed; main thread ends.");
        }
    }
    public class ThreadWithState
    {
        // State information used in the task.
        private string boilerplate;
        private int value;

        // The constructor obtains the state information.
        public ThreadWithState(string text, int number)
        {
            boilerplate = text;
            value = number;
        }

        // The thread procedure performs the task, such as formatting
        // and printing a document.
        public void ThreadProc()
        {
            Console.WriteLine(boilerplate, value);
        }
    }

}