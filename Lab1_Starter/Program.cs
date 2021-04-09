using System;
using System.Diagnostics;

namespace Lab1_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTestLinearSearch(66);
            RunTestBinarySearch(66);



        }

        public static int LinearSearch(int[] array, int value)
        {   /// Write your code here and remove the 'return -1'
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }


        public static int BinarySearch(int[] array, int value)
        {
            int min = 0;
            int N = array.Length;
            int max = N - 1;
            do
            {
                int mid = (min + max) / 2;
                if (value > array[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (array[mid] == value)
                    return mid;
                //if (min > max)
                //   break;
            } while (min <= max);

            return -1;
            /// Write your code here and remove the 'return -1'
        }

        public static void SortingMethod1(int[] array)
        {

            //Basic bubble sort

            int i, j;
            int N = array.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }

                }

            }
            /// Write your code here for the first 
            /// sorting algorithm you have chosen
        }





      
            private static void Quick_Sort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(arr, left, right);

                    if (pivot > 1)
                    {
                        Quick_Sort(arr, left, pivot - 1);
                    }
                    if (pivot + 1 < right)
                    {
                        Quick_Sort(arr, pivot + 1, right);
                    }
                }

            }

            private static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[left];
                while (true)
                {

                    while (arr[left] < pivot)
                    {
                        left++;
                    }

                    while (arr[right] > pivot)
                    {
                        right--;
                    }

                    if (left < right)
                    {
                        if (arr[left] == arr[right]) return right;

                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;


                    }
                    else
                    {
                        return right;
                    }
                }
            }/// Write your code here for the second 
             /// sorting algorithm you have chosen
        



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
        public static void RunTestLinearSearch(int x)
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
                LinearSearch(testArray, x);

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

        public static void RunTestBinarySearch(int x)
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
                BinarySearch(testArray, x);

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

        public static void RunTestSortingMethod1()
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
                SortingMethod1(testArray);
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

        public static void RunTestSortingMethod2()
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
                Quick_Sort(testArray,0,testArray.Length);
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
