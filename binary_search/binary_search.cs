using System;

namespace BinarySearch
{
    class BinarySearch{
    // Iterative Implementation of Binary Search
        public static int BinaryIterativeSearch(int[] inputArray, int target)
        {
            int minIndex = 0;
            int maxIndex = inputArray.Length - 1;

            while( minIndex <= maxIndex )
            {
                int midpoint = ( minIndex + maxIndex ) / 2;

                if( target == inputArray[midpoint] )
                {
                    return midpoint;
                }
                else if( target < inputArray[midpoint] )
                {
                    maxIndex = midpoint - 1;
                }
                else
                {
                    minIndex = midpoint + 1;
                }
            }

            return -1;
        }

        public static int BinaryRecursiveSearch(int[] inputArray, int target, int minIndex, int maxIndex)
        {
            if( minIndex > maxIndex )
            {
                return -1;
            } 
            else
            {
                int midpoint = ( minIndex + maxIndex ) / 2;

                if( target == inputArray[midpoint] )
                {
                    return midpoint;
                }
                else if( target < inputArray[midpoint] )
                {
                    return BinaryRecursiveSearch(inputArray, target, minIndex, midpoint - 1);
                }
                else
                {
                    return BinaryRecursiveSearch(inputArray, target, midpoint + 1, maxIndex);
                }
            }
        }

        public static void Main()
        {
            int[] testArray1 = { 1, 2, 3, 4, 5 };
            int target1 = 5;
            int[] testArray2 = { -100, 10, 0, 10, 100 };
            int target2 = -100;

            int result = BinaryIterativeSearch(testArray1, target1);

            if( result == -1 )
            {
                Console.WriteLine("Iterative Binary Search target value not found.");
            }
            else
            {
                Console.WriteLine("Iterative Binary Search target value found at index: " + result);
            }

            result = BinaryRecursiveSearch(testArray1, target1, 0, testArray1.Length);

            if( result == -1 )
            {
                Console.WriteLine("Recursive Binary Search target value not found.");
            }
            else
            {
                Console.WriteLine("Recursive Binary Search target value found at index: " + result);
            }

            result = BinaryIterativeSearch(testArray2, target2);

            if( result == -1 )
            {
                Console.WriteLine("Iterative Binary Search target value not found.");
            }
            else
            {
                Console.WriteLine("Iterative Binary Search target value found at index: " + result);
            }

            result = BinaryRecursiveSearch(testArray2, target2, 0, testArray1.Length);

            if( result == -1 )
            {
                Console.WriteLine("Recursive Binary Search target value not found.");
            }
            else
            {
                Console.WriteLine("Recursive Binary Search target value found at index: " + result);
            }
        }
    }
}