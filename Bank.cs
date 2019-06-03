using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynhroHW
{
    public class Bank
    {
        private int money = 100;
        private object lockObject = new object();

            
        //public void Generation()
        //{
        //    string[] GiveTaken = { "Дали", "Забрали" };
        //    Random ran = new Random();

        //    for (int i = 0; i < money; i++)
        //    {
        //        switch (ran.Next(2))
        //        {
        //            case 0:
        //                Console.WriteLine(GiveTaken[0]);
        //                money += 10;
        //                break;
        //            case 1:
        //                Console.WriteLine(GiveTaken[1]);
        //                money -= 10;
        //                break;
        //        }
        //    }
        //}

        public void PrintNumber()
        {
            //lock (lockObject)
            //{
                var currentThread = Thread.CurrentThread;
                Console.WriteLine($"Поток с ID {currentThread.ManagedThreadId} начал работу");

                for (int i = 0; i < 1; i++)
                {
                    string[] GiveTaken = { "Дали", "Забрали" };
                    Random ran = new Random();

                    for (int j = 0; j < 1; j++)
                    {
                        switch (ran.Next(2))
                        {
                            case 0:
                                Console.WriteLine(GiveTaken[0]);
                                money += 10;
                                Console.WriteLine(money);
                                break;
                            case 1:
                                Console.WriteLine(GiveTaken[1]);
                                money -= 10;
                                Console.WriteLine(money);
                                break;
                        }
                    }
                    Thread.Sleep(1000);
                }

                Console.WriteLine($"\nПоток с ID {currentThread.ManagedThreadId} завершил работу");
            //}
        }

    }   
}
