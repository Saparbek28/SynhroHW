using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynhroHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var threads = new Thread[5];
            var banks = new Bank();

           // Timer timer = new Timer(PrintTime, null, TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(1));

            for(int i = 0; i < threads.Length; i++)
            {
                var thread = new Thread(banks.PrintNumber);
                thread.Name = $"поток под номером {thread.ManagedThreadId}";
                threads[i] = thread;
            }

            foreach (var thread in threads)
            {
                thread.Start();
            }

            Console.ReadLine();
        }
    }
}
