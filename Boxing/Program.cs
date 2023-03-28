using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Boxing
{
    class Program
    {
        private static void Main(string[] args)
        {
            int count = 100000000;
            int val = 123;

            List<object> obj_list = new List<object>();
            obj_list.Capacity = count;

            List<int> val_list = new List<int>();
            val_list.Capacity = count;

            var sw = Stopwatch.StartNew();
            for (int i = 0; i < count; ++i)
                obj_list.Add(val);
            var time = sw.ElapsedMilliseconds;

            Console.WriteLine("Boxing: {0} ms", time);

            sw = Stopwatch.StartNew();
            for (int i = 0; i < count; ++i)
                val_list.Add(val);
            var time2 = sw.ElapsedMilliseconds;

            Console.WriteLine("No boxing: {0} ms", time2);

            Console.ReadLine();
        }
    }
}

