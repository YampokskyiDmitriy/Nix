using System;

namespace Lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int amount = Amount();
            int[] array = CreateArray(amount);
            char[] array1 = FindFirstArray(array);
            char[] array2 = FindSecondArray(array);
            int count1 = Count(array1);
            int count2 = Count(array2);
            string start = string.Empty;
            string first = string.Empty;
            string second = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                start += array[i] + " ";
            }

            for (int i = 0; i < array1.Length; i++)
            {
                first += array1[i] + " ";
            }

            for (int i = 0; i < array2.Length; i++)
            {
                second += array2[i] + " ";
            }

            Console.WriteLine("Start array:");
            Console.WriteLine(start);
            Console.WriteLine("First array:");
            Console.WriteLine(first);
            Console.WriteLine("Second array:");
            Console.WriteLine(second);
            Console.WriteLine("First in upper case: ");
            Console.Write(count1);
            Console.WriteLine("\nSecond in upper case: ");
            Console.Write(count2);
            if (count1 > count2)
            {
                Console.WriteLine("\nMore in first");
            }
            else
            {
                Console.WriteLine("\nMore in second");
            }

            Console.ReadLine();
        }

        public static int Amount()
        {
            bool result = false;
            int amount = 0;
            Console.WriteLine("Enter amount of elements in array");
            while (!result)
            {
                result = int.TryParse(Console.ReadLine(), out amount);
            }

            return amount;
        }

        public static int[] CreateArray(int num)
        {
            var random = new Random();
            int[] array = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 27);
            }

            return array;
        }

        public static char[] FindFirstArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }

            char[] result = new char[count];
            int arrayCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result[arrayCount] = Convert.ToChar(array[i] + 96);
                    arrayCount++;
                }
            }

            return result;
        }

        public static char[] FindSecondArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    count++;
                }
            }

            char[] result = new char[count];
            int arrayCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    result[arrayCount] = Convert.ToChar(array[i] + 96);
                    arrayCount++;
                }
            }

            return result;
        }

        public static int Count(char[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'a' || array[i] == 'e' || array[i] == 'i' || array[i] == 'd' || array[i] == 'h' || array[i] == 'j')
                {
                    array[i] = Convert.ToChar(array[i] - 32);
                    count++;
                }
            }

            return count;
        }
    }
}
