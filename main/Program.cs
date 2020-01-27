using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace main
{
    class Storage
    {
        public int[] a;
        public Storage next;
        public Storage(Storage next)
        {
            const int max_length = 10000;
            this.a = new int[max_length];
            for (int i = 0; i < max_length; i++)
            {
                this.a[i] = 0;
            }
            this.next = next;
        }
    }
    class Program
    {
        static int blocksToFill = 100000;
        static void FillMemory()
        {
            Storage storage = null;
            for (int i = 0; i < blocksToFill; i++)
            {
                storage = new Storage(storage);
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Thread thread = new Thread(FillMemory);
                thread.Start();
            }
        }
    }
}
