using System;

namespace FindTheNonRepeatingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the non-repeating number in the array!");
            Console.WriteLine("-------------------------------------------");

            try
            {
                Console.WriteLine("Enter the number of elements in the array");
                int noOfElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String elementsString = Console.ReadLine();
                String[] elements = elementsString.Split(' ');
                int[] array = new int[noOfElements];
                for (int i = 0; i < noOfElements; i++) {
                    array[i] = int.Parse(elements[i]);
                }

                GetNonRepeatingElement(array);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }

            Console.ReadLine();
        }

        private static void GetNonRepeatingElement(int[] array) {
            int nonRepeatingElement = -1;

            int xorSum = 0;
            for (int i = 0; i < array.Length; i++) {
                xorSum ^= array[i];
            }

            if (isXORResultAnElement(xorSum, array)) {
                nonRepeatingElement = xorSum;
            }

            if (nonRepeatingElement == -1) {
                Console.WriteLine("There are no non-repeating elements!");
                return;
            }

            Console.WriteLine("The first non-repeating element is "+nonRepeatingElement);
        }

        private static bool isXORResultAnElement(int xorSum, int[] array) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == xorSum) {
                    return true;
                }
            }
            return false;
        }

    }
}
