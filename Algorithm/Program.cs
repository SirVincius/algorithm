using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Algorithm
{

    class Sorting
    {
        public static void BubbleSort(int[] ints)
        {
            int temp;
            int l = ints.Length;
            for (int i = 0; i < l - 1; i++)
            {
                for (int j = 0; j < l - i - 1; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        temp = ints[j + 1];
                        ints[j + 1] = ints[j];
                        ints[j] = temp;
                    }
                }
            }
        }
        public static void SelectionSort(int[] ints)
        {
            int minIndex;
            int l = ints.Length;
            for (int i = 0; i < l - 1; i++)
            {
                int temp;
                minIndex = i;
                for (int j = i + 1; j < l; j++)
                {
                    if (ints[j] < ints[minIndex])
                        minIndex = j;
                }
                temp = ints[i];
                ints[i] = ints[minIndex];
                ints[minIndex] = temp;
            }
        }

        public static void InsertionSort(int[] ints)
        {
            int l = ints.Length;
            int currentValue;
            int index;
            for (int i = 1; i < l; i++)
            {
                currentValue = ints[i];
                index = i - 1;
                while (index >= 0 && currentValue < ints[index])
                {
                    ints[index + 1] = ints[index];
                    index--;
                }
                ints[index+1] = currentValue;
            }
        }
        
    }

    class DataGeneration
    {
        public static int[] GenerateIntArray()
        {
            Random random = new Random();
            int[] intArray = new int[10];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(1, 101);
            }
            return intArray;
        }

        public static int[][] generateArrayOfIntArray()
        {
            int[][] arrayOfIntArray = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                arrayOfIntArray[i] = GenerateIntArray();
            }
            return arrayOfIntArray;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program running!");

            Random random = new Random();

            //Int arrays creations
            int[] intArray1 = DataGeneration.GenerateIntArray();
            int[] intArray2 = DataGeneration.GenerateIntArray();
            int[] intArray3 = DataGeneration.GenerateIntArray();
            int[] intArray4 = DataGeneration.GenerateIntArray();
            int[] intArray5 = DataGeneration.GenerateIntArray();

            //Adding each array to an array
            int[][] everyIntArrays = DataGeneration.generateArrayOfIntArray();

            //Sorting every int array
            for (int i = 0; i < everyIntArrays.Length; i++)
            {
                Sorting.InsertionSort(everyIntArrays[i]);
            }

            //Printing every arrays
            for (int i = 0; i < everyIntArrays.Length; i++)
            {
                for (int j = 0; j < everyIntArrays[i].Length; j++)
                {
                    Console.Write(everyIntArrays[i][j] + "  ");
                }
                Console.WriteLine("");
            }
        }
    }
}