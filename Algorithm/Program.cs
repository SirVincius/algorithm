namespace Algorithm
{

    class Bubblesort
    {
        public static void sort(int[] ints)
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
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program running!");

            Random random = new Random();

            //Int arrays creations
            int[] intArray1 = new int[10];
            int[] intArray2 = new int[10];
            int[] intArray3 = new int[10];
            int[] intArray4 = new int[10];
            int[] intArray5 = new int[10];

            //Adding each array to an array
            int[][] everyIntArrays = new int[5][];
            everyIntArrays[0] = intArray1;
            everyIntArrays[1] = intArray2;
            everyIntArrays[2] = intArray3;
            everyIntArrays[3] = intArray4;
            everyIntArrays[4] = intArray5;

            //Filling int arrays with int
            for (int i = 0; i < everyIntArrays.Length; i++)
            {
                for (int j = 0; j < everyIntArrays[i].Length; j++)
                {
                    everyIntArrays[i][j] = random.Next(1, 101);
                }
            }

            for (int i = 0; i < everyIntArrays.Length; i++)
            {
                Bubblesort.sort(everyIntArrays[i]);
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