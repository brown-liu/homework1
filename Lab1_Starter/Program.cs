using System;
using System.Diagnostics;

namespace Lab1_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Run the methods from here


        }

        public static int LinearSearch(int[] array, int value)
        {
            /// Write your code here and remove the 'return -1'
            return -1;
        }

        public static int BinarySearch(int[] array, int value)
        {
            /// Write your code here and remove the 'return -1'
            return -1;
        }

        public static void SortingMethod1(int[] array)
        {
            /// Write your code here for the first 
            /// sorting algorithm you have chosen
        }

        public static void SortingMethod2(int[] array)
        {
            /// Write your code here for the second 
            /// sorting algorithm you have chosen
        }



        /////////////////////////////////////////////////////
        //////////////////HELPER FUNCTIONS///////////////////
        /////////////////////////////////////////////////////

        /// Sets all elements of an array to a random number
        /// within the specified min and max values.
        public static void FillRandom(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }

        /// Test method to run a function with varying array
        /// sizes as inputs. Prints results to console.
        public static void RunTest(Action<int[]> runFunc)
        {
            /// Create 2 arrays, 1 for test sizes, 1 for holding the elapsed times
            int[] inputLengths = { 100, 1000, 10000, 100000 };
            TimeSpan[] elapsedTimes = new TimeSpan[4];
            int[] testArray;
            Console.WriteLine("Beginning tests...");

            /// start the timer
            var watch = Stopwatch.StartNew();

            /// loop over the test lengths
            for (int i = 0; i < inputLengths.Length; i++)
            {
                testArray = new int[inputLengths[i]];
                FillRandom(testArray, 1, 2000);
                /// restart the timer
                watch.Restart();
                Console.Write("Running function with {0} length...", inputLengths[i]);

                /// call the passed method with the test length as parameter
                runFunc(testArray);

                /// save the time taken to perform
                elapsedTimes[i] = watch.Elapsed;
                Console.WriteLine("Function completed execution.");
            }

            /// print out the results for the tests
            Console.WriteLine("\nFinished tests... Results below:\n");
            for (int i = 0; i < elapsedTimes.Length; i++)
            {
                Console.WriteLine("iterations: {0:0000000}\t Elapsed Time: {1}", inputLengths[i], elapsedTimes[i]);
            }
        }
    }
}
