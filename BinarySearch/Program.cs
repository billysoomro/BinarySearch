using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intArray = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14 };
            var binarySearchWithRecursion = BinarySearchWithRecursion(intArray, 2, 0, intArray.Length);
            var binarySearchWithIteration = BinarySearchWithIteration(intArray, 12);

            Console.WriteLine($"Index with Recursion: {binarySearchWithRecursion}");
            Console.WriteLine($"Index with Iteration: {binarySearchWithIteration}");
            Console.ReadLine();
        }

        public static int BinarySearchWithRecursion(int[] array, int target, int leftPointer, int rightPointer)
        {
            while (leftPointer <= rightPointer)
            {
                var middle = (leftPointer + rightPointer) / 2;

                if (array[middle] == target)
                {
                    return array[middle];
                }

                else if (array[middle] > target)
                {
                    return BinarySearchWithRecursion(array, target, leftPointer, middle - 1);
                }

                else
                {
                    return BinarySearchWithRecursion(array, target, middle + 1, rightPointer);
                }
            }
            
            return -1;
        }

        public static int BinarySearchWithIteration(int[] array, int target)
        {
            var leftPointer = 0;
            var rightPointer = array.Length;

            while (leftPointer <= rightPointer)
            {
                var middle = (leftPointer + rightPointer) / 2;

                if (array[middle] == target)
                {
                    return array[middle];
                }

                else if (array[middle] > target)
                {
                    rightPointer = array[middle] - 1;
                }

                else
                {
                    leftPointer = array[middle] + 1;
                }
            }

            return -1;
        }
    }
}
