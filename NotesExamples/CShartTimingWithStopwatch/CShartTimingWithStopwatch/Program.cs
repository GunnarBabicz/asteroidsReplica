/******************************************************
dvb Jan 2016 - timing study comparing C# in visual studio using stop watch. 
resolution. seems to be around 380 nano seconds.
*********************************************************/
using System;
using System.Diagnostics;
using System.Threading;

namespace timingCode1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CSharp Timing with Stopwatch");
            Stopwatch stopwatch = new Stopwatch();
            if (Stopwatch.IsHighResolution)
                Console.WriteLine("high resolution");
              else
                 Console.WriteLine("low resolution");
            long frequency = Stopwatch.Frequency;
            Console.WriteLine("timer frequency in ticks per second = {0}", frequency);
            long nanosecPerTick = (1000L * 1000L * 1000L) / frequency;
            Console.WriteLine("timer is accurate within {0} nanoseconds", nanosecPerTick);
            const System.Int64 size = 512; //max 16000
            System.Int64[,] a = new System.Int64[size, size];
            System.Int64 r, c,i;
            // access array into memory/cashe before initiate timing
            i = 10;
            for (r = 0; r < size; r++)
                for (c = 0; c < size; c++)
                    a[r, c] = i + i + 1 ;
            //begin timing
                stopwatch.Start();
                // row major tester.
            for(i=0;i<1000;i++) // adjust depending on array size as needed
                for (r = 0; r < size; r++)
                    for (c = 0; c < size; c++)
                        a[r, c] = i+i+2;
                // Stop timing.
                stopwatch.Stop();
                // Console.WriteLine("Time elapsed in milliseconds: {0}", stopwatch.ElapsedMilliseconds);
                Console.WriteLine("Row Major Time elapsed: {0}", stopwatch.Elapsed);
                // access array into memory/cashe
             for (c = 0; c < size; c++)
                 for (r = 0; r < size; r++)
                     a[r, c] = i+i+1;
                //start timing
                stopwatch.Start();
            // col major tester
            for (i = 0; i < 1000; i++) // adjust depending on array size as needed
                for (c = 0; c < size; c++)
                    for (r = 0; r < size; r++)
                        a[r, c] = i + i + 2 ;

                stopwatch.Stop();
                //Console.WriteLine("Time elapsed in milliseconds: {0}", stopwatch.ElapsedMilliseconds);
                Console.WriteLine("Col Major Time elapsed: {0}", stopwatch.Elapsed);
                Console.ReadLine();
        }
    }
}
